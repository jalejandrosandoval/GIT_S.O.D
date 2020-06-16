
Estado del repositorio
![Petroco .NET Core](https://github.com/wkrea/GIT_S.O.D/workflows/Petroco%20.NET%20Core/badge.svg)

# FrontEnd

## Instalando nvm
    descargar el instalador desde [Aquí](https://github.com/coreybutler/nvm-windows/releases) y seguir [el instructivo](https://docs.microsoft.com/en-us/windows/nodejs/setup-on-windows)

## Instalar node con nvm
    Abrir una consola cmd o cualquiera que se tenga disponible y ejecutar:

    ```bash
    nvm install node
    ```
    > 🎯 **Tip**: sirve para verificar versiones disponibles
    > ```bash
    > nvm list
    > ```

### Activar la version instalada
* ejecutar el comando, ajustando la versión entregada por `nvm list`
    ```bash
    nvm use <VERSIÓN>
    ```
* verificar
    ```bash
    node -v
    ```

## Instalando Angular
utilizando el mismo **nvm**
```bash
npm install -g @angular/cli
```
verificar
```bash
ng --version
```

## Restaurar los paquetes de FrontEnd Angular

* Restaurar dependecias
    ```bash
    cd Angular\ClientApp
    npm install
    ```
> ⏳🚶☕️ Esto puede **tardar buen tiempo**

* ejecutar el frontend
    ```bash
    ng serve
    ```
* verificar el frontend
Basta con acceder a [http://localhost:4200](http://localhost:4200)


# BackEnd

> ## Desarrollo

Instalar:
* vscode o visual studio
* netcore [SDK](https://dotnet.microsoft.com/download/dotnet-core)
* Instalar nuggets
  * Microsoft.AspNetCore.Authentication.JwtBearer --version:???
  * Microsoft.AspNetCore.Identity.EntityFrameworkCore --version:???
  * Microsoft.AspNetCore.Mvc.NewtonsoftJson --version:???
    * **VisualStudio PM>** `Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson --Version 3.1.2`
    * **vscode CLI** `dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --Version 3.1.2`
  * Microsoft.EntityFrameworkCore" --version:???
  * Microsoft.EntityFrameworkCore.InMemory --version:???
    * **VisualStudio PM>** `Install-Package Microsoft.EntityFrameworkCore.InMemory --Version 3.1`
    * **vscode CLI** 
    `dotnet add package Microsoft.EntityFrameworkCore.InMemory -Version 3.1`
  * Microsoft.EntityFrameworkCore.Sqlite --version:???
  * Microsoft.EntityFrameworkCore.SqlServer --version:???
  * Microsoft.EntityFrameworkCore.Tools --version:???

>## Ejecución
* compilar y ejecutar el proyecto
    ```bash
    cd Modular\API
    dotnet build && dotnet run
    ```
* verificar el backend
* hacer una consulta desde FrontEnd 
* hacer un request con [Postman](https://www.postman.com/downloads/) a la url [http://localhost:5000](http://localhost:5000)


# Referencias
* https://docs.microsoft.com/en-us/windows/nodejs/setup-on-windows
* https://medium.com/devschile/m%C3%BAltiples-versiones-de-node-con-nvm-63b2ac715c38
* https://dxtright.com/index.php/2018/06/25/setting-angular-environment-using-nvm/
* https://thecodebuzz.com/jsonexception-possible-object-cycle-detected-object-depth/
* https://github.com/dotnet/efcore/issues/11776
* https://stackoverflow.com/questions/55812331/ef-core-include-list-of-list/55813418#55813418