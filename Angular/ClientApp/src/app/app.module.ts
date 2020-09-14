//MODULES
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { DataTablesModule } from 'angular-datatables';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

//TOASTR
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

//SERVICES
import { UsersService } from './Services/Users/users.service';
import { AuthGuardService } from './Services/Auth/auth-guard.service';
import { AccountService } from './Services/Account/account.service';
import { UsersTypeService } from './Services/UsersType/users-type.service';

//INTERCEPTORS OF HTTP
import { AuthInterceptorService } from './Services/Auth/auth-interceptor.service';
import { ErrorInterceptorService } from './Services/Auth/error-interceptor.service';

// ----------- COMPONENTS -----------

// MENU
import { HomeComponent } from './Components/home/home.component';
import { NavBarComponent } from './Components/Menu/nav-bar/nav-bar.component';
import { FooterComponent } from './Components/Menu/footer/footer.component';
import { SidebarComponent } from './Components/Menu/sidebar/sidebar.component';

//AUTH
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';

import { DefaultComponent } from './Components/default/default.component';
import { MantenainceComponent } from './Components/mantenaince/mantenaince/mantenaince.component';
import { EquipmentsComponent } from './Components/Mantenaince/equipments/equipments/equipments.component';

//PURCHASES

import { ProvidersComponent } from './Components/purchases/providers/providers/providers.component';
import { ProvidersCreateComponent } from './Components/purchases/providers/providers-create/providers-create.component';
import { ProvidersEditComponent } from './Components/purchases/providers/providers-edit/providers-edit.component';

import { OrdersPurchasesComponent } from './Components/purchases/OrdersPurchases/orders-purchases/orders-purchases.component';
import { OrdersPurchasesCreateComponent } from './Components/purchases/OrdersPurchases/orders-purchases-create/orders-purchases-create.component';

import { PageNotFoundComponent } from './Components/page-not-found/page-not-found.component';
import { FabricationComponent } from './Components/fabrication/fabrication/fabrication.component';

//COMPLEMENTS

import { ComplementsComponent } from './Components/complements/complements/complements.component';

import { ProvidersTypeComponent } from './Components/complements/providers-type/providers-type/providers-type.component';
import { ProvidersTypeEditComponent } from './Components/Complements/providers-type/providers-type-edit/providers-type-edit.component';
import { ProvidersTypeCreateComponent } from './Components/Complements/providers-type/providers-type-create/providers-type-create.component';

import { DevicesTypesComponent } from './Components/complements/devices-types/devices-types/devices-types.component';
import { DevicesTypesEditComponent } from './Components/Complements/devices-types/devices-types-edit/devices-types-edit.component';
import { DevicesTypesCreateComponent } from './Components/Complements/devices-types/devices-types-create/devices-types-create.component';

import { FixedAssetsComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets/fixed-assets.component';
import { AccountingComponent } from './Components/Accounting/Accounting/accounting.component';
import { PurchasesComponent } from './Components/purchases/purchases/purchases.component';
import { AssetsTypeComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type/assets-type.component';
import { AssetsTypeCreateComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-create/assets-type-create.component';
import { AssetsTypeEditComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-edit/assets-type-edit.component';
import { SystemsComponent } from './Components/Systems/systems/systems.component';
import { CVDevicesComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices/cv-devices.component';
import { DevicesAccesoriesComponent } from './Components/Systems/CV-Devices/devices-accesories/devices-accesories.component';
import { DevicesMantenainceComponent } from './Components/Systems/CV-Devices/devices-mantenaince/devices-mantenaince.component';
import { CellComponent } from './Components/Cell/Cell/cell/cell.component';
import { CvDevicesCreateComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create/cv-devices-create.component';
import { CvDevicesCreateCharacteristicsComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create-characteristics/cv-devices-create-characteristics.component';
import { CvDevicesCreateAccesoriesComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create-accesories/cv-devices-create-accesories.component';

import { ProfileComponent } from './Components/configuration/users/profile/profile.component';
import { LendingsComponent } from './Components/mantenaince/lendings/lendings/lendings.component';
import { MantenaincesComponent } from './Components/mantenaince/mantenainces/mantenainces.component';
import { ScheduleComponent } from './Components/fabrication/schedule/schedule.component';
import { OrdersproductionComponent } from './Components/fabrication/ordersproduction/ordersproduction.component';
import { RegistersComponent } from './Components/fabrication/registers/registers.component';
import { TracingsComponent } from './Components/fabrication/tracings/tracings.component';
import { DepartmentsComponent } from './Components/complements/departments/departments/departments.component';
import { DepartmentsCreateComponent } from './Components/complements/departments/departments-create/departments-create.component';
import { FixedAssetsCreateComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets-create/fixed-assets-create.component';
import { FixedAssetsEditComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets-edit/fixed-assets-edit.component';
import { EquipmentsCreateComponent } from './Components/mantenaince/equipments/equipments-create/equipments-create.component';
import { EquipmentsEditComponent } from './Components/mantenaince/equipments/equipments-edit/equipments-edit.component';
import { LendingsCreateComponent } from './Components/mantenaince/lendings/lendings-create/lendings-create.component';
import { LendingsEditComponent } from './Components/mantenaince/lendings/lendings-edit/lendings-edit.component';
import { HelpComponent } from './Components/menu/help/help.component';

//CONFIGURATION

import { ConfigurationComponent } from './Components/configuration/configuration/configuration.component';

//Config-Users
import { UsersComponent } from './Components/configuration/users/users/users/users.component';
import { UserscreateComponent } from './Components/configuration/users/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/configuration/users/users/usersedit/usersedit.component';

import { UsersTypeComponent } from './Components/configuration/users/users-type/users-type/users-type.component';
import { UsersTypeCreateComponent } from './Components/configuration/users/Users-Type/users-type-create/users-type-create.component';
import { UsersTypeEditComponent } from './Components/configuration/users/users-type/users-type-edit/users-type-edit.component';

import { UsersMenuComponent } from './Components/configuration/users/users-menu/users-menu.component';

import { DatabaseComponent } from './Components/configuration/database/database.component';
import { MigrationsComponent } from './Components/configuration/migrations/migrations.component';
import { LogsComponent } from './Components/configuration/logs/logs.component';

//THUMAN
import { THumanComponent } from './Components/Thuman/thuman/thuman.component';

//EMPLOYEES
import { EmployeeComponent } from './Components/THuman/Employees/Employees/employee/employee.component';
import { EmployeeCreateComponent } from './Components/THuman/Employees/Employees/employee-create/employee-create.component';
import { EmployeeEditComponent } from './Components/THuman/Employees/Employees/employee-edit/employee-edit.component';

import { EmployeeTypeComponent } from './Components/THuman/Employees/Employees-Type/employee-type/employee-type.component';
import { EmployeeTypeCreateComponent } from './Components/THuman/Employees/Employees-Type/employee-type-create/employee-type-create.component';
import { EmployeeTypeEditComponent } from './Components/THuman/Employees/Employees-Type/employee-type-edit/employee-type-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    FooterComponent,
    LoginComponent,
    AboutComponent,
    RecoveryComponent,
    UsersComponent,
    UserscreateComponent,
    UserseditComponent,
    DefaultComponent,
    ComplementsComponent,
    MantenainceComponent,
    EquipmentsComponent,
    ProvidersComponent,
    PageNotFoundComponent,
    FabricationComponent,
    UsersTypeComponent,
    UsersTypeCreateComponent,
    ProvidersTypeComponent,
    UsersTypeEditComponent,
    FixedAssetsComponent,
    AccountingComponent,
    PurchasesComponent,
    AssetsTypeComponent,
    AssetsTypeCreateComponent,
    AssetsTypeEditComponent,
    SystemsComponent,
    CVDevicesComponent,
    DevicesTypesComponent,
    DevicesAccesoriesComponent,
    DevicesMantenainceComponent,
    CellComponent,
    CvDevicesCreateComponent,
    CvDevicesCreateCharacteristicsComponent,
    CvDevicesCreateAccesoriesComponent,
    ConfigurationComponent,
    ProfileComponent,
    DatabaseComponent,
    MigrationsComponent,
    LogsComponent,
    LendingsComponent,
    MantenaincesComponent,
    ScheduleComponent,
    OrdersproductionComponent,
    RegistersComponent,
    TracingsComponent,
    DepartmentsComponent,
    DepartmentsCreateComponent,
    FixedAssetsCreateComponent,
    FixedAssetsEditComponent,
    EquipmentsCreateComponent,
    EquipmentsEditComponent,
    LendingsCreateComponent,
    LendingsEditComponent,
    THumanComponent,
    SidebarComponent,
    HelpComponent,
    OrdersPurchasesComponent,
    OrdersPurchasesCreateComponent,
    ProvidersCreateComponent,
    ProvidersEditComponent,
    UsersMenuComponent,
    EmployeeComponent,
    EmployeeCreateComponent,
    EmployeeEditComponent,
    EmployeeTypeCreateComponent,
    EmployeeTypeEditComponent,
    EmployeeTypeComponent,
    HomeComponent,
    ProvidersTypeEditComponent,
    ProvidersTypeCreateComponent,
    DevicesTypesEditComponent,
    DevicesTypesCreateComponent
  ],
  imports: [
    BrowserModule,
    DataTablesModule,
    AppRoutingModule,
    ReactiveFormsModule,
    CommonModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([]), 
    ToastrModule.forRoot({
      closeButton: true,
      positionClass: "toast-top-right"
    }),
    HttpClientModule,    
  ],
  providers: [
    UsersService, 
    UsersTypeService,
    AuthGuardService,
    AccountService,
    { 
      provide: HTTP_INTERCEPTORS, 
      useClass: ErrorInterceptorService, 
      multi: true 
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptorService,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }