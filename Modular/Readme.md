<p>
    <h2 align="center"> PETMAN - WEB API</h2>
</p>

## Instalar Paquetes

Con el Administrador de Paquetes o NuggetPackage Instalar los siguientes paquetes:

Proyecto Bussiness Logic: 

* System.ComponentModel.DataAnnotations -- Version: <b>(4.7.0)</b>.

Proyecto Web Api:

* Swashbuckle.AspNetCore -- Version: <b>(5.5.1)</b>.
* Microsoft.VisualStudio.Web.CodeGeneration.Design -- Version: <b>(3.1.4)</b>.
* Microsoft.EntityFrameworkCore -- Version: <b>(3.1.7)</b>.
* Microsoft.EntityFrameworkCore.SqlServer -- Version: <b>(3.1.7)</b>.
* Microsoft.EntityFrameworkCore.Tools -- Version: <b>(3.1.7)</b>.
* Microsoft.EntityFrameworkCore.Sqlite -- Version: <b>(3.1.7)</b>.
* Microsoft.AspNetCore.Mvc.NewtonsoftJson -- Version: <b>(3.1.7)</b>.
* Microsoft.AspNetCore.Authentication.JwtBearer -- Version: <b>(3.1.7)</b>.

### Configurar Swagger 

Para ello se requiere ir al archivo <b> Startup.cs </b>, del proyecto y agregar las siguientes lineas en el método ConfigureServices

```bash
public void ConfigureServices(IServiceCollection services)
{
  ...

  //Configuration the Swagger Docs

  services.AddSwaggerGen(config =>
    config.SwaggerDoc("V1.0", new OpenApiInfo
      {
        Title = "PETMAN - API V1.0",
        Version = "V1.0",
        Description = "PETMAN - WEB API"
      })
    );

  ...

}
```

Y también se debe ir al método Configure donde allí se agreguen las siguientes líneas:

```bash
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
  ...

  //SWAGGER
  app.UseSwagger();
  app.UseSwaggerUI(c =>
    {
      c.SwaggerEndpoint("/swagger/V1.0/swagger.json", "PETMAN - API V1.0");
  });

  ...
}
```

<b> NOTA #1: </b> Se debe tener especial cuidado a la hora de colocar los nombres a los atributos de <b> Tittle y Version </b> debido a que si por error se usa una mayuscula donde no va en el método configure inmmediatamente arrojará un error.

<b> NOTA #2: </b> Para consultar la vista de swagger basta con poner en la ruta del proyecto en el navegador la palabra <b> /swagger </b>

```bash
http://localhost:57764/swagger
```

## Conection Database

Para conectarse y crear una base de datos desde 0 a través de migraciones se debe modificar el appsettings.json del proyecto WebApi, más exactamente la siguiente linea:

```bash
"ConnectionStrings": {
    "DevConection": "Data Source='Server_Name';Database='DataBase_Name';Trusted_Connection=True"
  },
```

Allí se reemplaza 'DataBase_Name' por el nombre del servidor local o externo de la base de datos, en cuyo caso debe ser gestionado a través de el SGBD de SQLSERVER (SSMS).

## Migraciones

### Configuraciones Previas

Se debe tener en cuenta:

* Realizar las respectivas configuraciones en el archiivo STARTUP. Más exactamente en el metodo ConfigureServices; allí es donde realmente se realizan las configuraciones del Cors, del JWT, de Migracion de BD y de Serializar los archivos por JSON.

```bash
public void ConfigureServices(IServiceCollection services)
{

  // Migrations through DBContext

  services.AddDbContext<AppDbContext>(options =>
      options.UseSqlServer(
      Configuration.GetConnectionString("DevConectionBD")));

  // Enable Cors

  services.AddCors(options =>
    {
    options.AddPolicy("AllowSpecificOrigin",
      builder =>
      {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
      ;
    });
  });

  // Serializable by JSON

  services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
      options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
  );

  //JWT

  services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
      options.TokenValidationParameters = new TokenValidationParameters
      {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = Configuration["Jwt:Issuer"],
        ValidAudience = Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(Configuration["Key"])),
        ClockSkew = TimeSpan.Zero
      }
    );

  services.AddControllers();

}
```

### Sentencias para la Migración

Para ello se debe: 
* Abrir la consola de admistración de paquetes.
* Verificar que se encuentre en el Proyecto donde esta <DbContext>.
* Dar un nombre a la migración.

```bash
PM> Add-Migration 'NameMigration'
```

* Actualizar la Base de Datos o en su debido caso, crearla de 0.

```bash
PM> Update-Database
```
