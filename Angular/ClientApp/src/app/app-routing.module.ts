import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// COMPONENTS

//import { PageNotFoundComponent } from './Components/page-not-found/page-not-found.component';

import { HomeComponent } from './Components/home/home.component';

// AUTH
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';

// USERS

import { DefaultComponent } from './Components/default/default.component';

import { UsersComponent } from './Components/users/users/users/users.component';
import { UserscreateComponent } from './Components/users/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/users/users/usersedit/usersedit.component';

import { UsersTypeComponent } from './Components/users/users-type/users-type/users-type.component';
import { UsersTypeCreateComponent } from './Components/users/Users-Type/users-type-create/users-type-create.component';
import { UsersTypeEditComponent } from './Components/users/users-type/users-type-edit/users-type-edit.component';

import { ConfigurationComponent } from './Components/configuration/configuration/configuration.component';
import { ProfileComponent } from './Components/users/profile/profile.component';

// MANTENAICE 

import { MantenainceComponent } from './Components/mantenaince/mantenaince/mantenaince.component';

// MANTENAICE - EQUIPMENTS

import { EquipmentsComponent } from './Components/Mantenaince/equipments/equipments/equipments.component';
import { EquipmentsCreateComponent } from './Components/mantenaince/equipments/equipments-create/equipments-create.component';
import { EquipmentsEditComponent } from './Components/mantenaince/equipments/equipments-edit/equipments-edit.component';

// FABRICATION

import { FabricationComponent } from './Components/fabrication/fabrication/fabrication.component';
import { ScheduleComponent } from './Components/fabrication/schedule/schedule.component';
import { OrdersproductionComponent } from './Components/fabrication/ordersproduction/ordersproduction.component';
import { TracingsComponent } from './Components/fabrication/tracings/tracings.component';
import { RegistersComponent } from './Components/fabrication/registers/registers.component';

// PURCHASES

import { PurchasesComponent } from './Components/purchases/purchases.component';

// PURCHASES - PROVIDERS

import { ProvidersComponent } from './Components/providers/providers/providers.component';
import { ProvidersTypeComponent } from './Components/providers/providers-type/providers-type.component';

// ACCOUNTING

import { AccountingComponent } from './Components/Accounting/Accounting/accounting.component';

import { FixedAssetsComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets/fixed-assets.component';
import { FixedAssetsCreateComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets-create/fixed-assets-create.component';

import { AssetsTypeComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type.component';
import { AssetsTypeCreateComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-create/assets-type-create.component';
import { AssetsTypeEditComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-edit/assets-type-edit.component';

// SYSTEMS

import { DatabaseComponent } from './Components/configuration/database/database.component';

import { SystemsComponent } from './Components/Systems/systems/systems.component';
import { CVDevicesComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices/cv-devices.component';
import { CvDevicesCreateComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create/cv-devices-create.component';
import { CvDevicesCreateCharacteristicsComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create-characteristics/cv-devices-create-characteristics.component';
import { CvDevicesCreateAccesoriesComponent } from './Components/Systems/cv-devices/cv-devices/cv-devices-create-accesories/cv-devices-create-accesories.component';
import { DevicesTypesComponent } from './Components/Systems/CV-Devices/devices-types/devices-types.component';

// CELL

import { CellComponent } from './Components/Cell/Cell/cell/cell.component';

// COMPLEMENTS

import { ComplementsComponent } from './Components/complements/complements/complements.component';

import { DepartmentsComponent } from './Components/complements/departments/departments/departments.component';
import { DepartmentsCreateComponent } from './Components/complements/departments/departments-create/departments-create.component';

/// SERVICE AUTHGUARD

import { AuthGuardService } from './Services/Auth/auth-guard.service';
import { MigrationsComponent } from './Components/configuration/migrations/migrations.component';
import { LogsComponent } from './Components/configuration/logs/logs.component';
import { LendingsComponent } from './Components/mantenaince/lendings/lendings/lendings.component';
import { MantenaincesComponent } from './Components/mantenaince/mantenainces/mantenainces.component';

const routes: Routes = [
  
    { path: '',  component: HomeComponent },
    { path: 'login', component: LoginComponent},
    { path: 'about', component: AboutComponent },
    { path: 'recovery', component: RecoveryComponent },
    { path: 'default', component: DefaultComponent, canActivate: [AuthGuardService]},
    { path: 'configuration', component: ConfigurationComponent, canActivate: [AuthGuardService]},

    { path: 'configuration/database', component: DatabaseComponent, canActivate: [AuthGuardService]},
    { path: 'configuration/migrations', component: MigrationsComponent, canActivate: [AuthGuardService]},
    { path: 'configuration/logs', component: LogsComponent, canActivate: [AuthGuardService]},

    { path: 'profile', component: ProfileComponent, canActivate: [AuthGuardService]},
    { path: 'users', component: UsersComponent, canActivate: [AuthGuardService]},
    { path: 'users/create', component: UserscreateComponent, canActivate: [AuthGuardService]},
    { path: 'users/edit/:IdUsers', component: UserseditComponent, canActivate: [AuthGuardService]},

    { path: 'userstypes', component: UsersTypeComponent, canActivate: [AuthGuardService]},
    { path: 'userstypes/create', component: UsersTypeCreateComponent, canActivate: [AuthGuardService]},
    { path: 'userstypes/edit/:Id_UsersType', component: UsersTypeEditComponent, canActivate: [AuthGuardService]},

    { path: 'complements', component: ComplementsComponent, canActivate: [AuthGuardService]},
    { path: 'departments', component: DepartmentsComponent, canActivate: [AuthGuardService]},
    { path: 'departments/create', component: DepartmentsCreateComponent, canActivate: [AuthGuardService]},
    
    { path: 'mantenaince', component: MantenainceComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince/lendings', component: LendingsComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince/mantenainces', component: MantenaincesComponent , canActivate: [AuthGuardService]},

    { path: 'mantenaince/equipments', component: EquipmentsComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince/equipments/create', component: EquipmentsCreateComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince/equipments/edit', component: EquipmentsEditComponent, canActivate: [AuthGuardService]},

    { path: 'fabrication', component: FabricationComponent, canActivate: [AuthGuardService]}, 
    { path: 'fabrication/schedule', component: ScheduleComponent, canActivate: [AuthGuardService]}, 
    { path: 'fabrication/registers', component: RegistersComponent, canActivate: [AuthGuardService]}, 
    { path: 'fabrication/ordersproduction', component: OrdersproductionComponent, canActivate: [AuthGuardService]}, 
    { path: 'fabrication/tracings', component: TracingsComponent , canActivate: [AuthGuardService]}, 

    { path: 'providers', component: ProvidersComponent, canActivate: [AuthGuardService]},
    { path: 'providerstypes', component: ProvidersTypeComponent, canActivate: [AuthGuardService]},
    { path: 'purchases', component: PurchasesComponent, canActivate: [AuthGuardService]},

    { path: 'accounting', component: AccountingComponent, canActivate: [AuthGuardService]},
    { path: 'accounting/fixed-assets', component: FixedAssetsComponent, canActivate: [AuthGuardService]},
    { path: 'accounting/fixed-assets/create', component: FixedAssetsCreateComponent, canActivate: [AuthGuardService]},
    { path: 'accounting/assetstypes', component: AssetsTypeComponent, canActivate: [AuthGuardService]},
    { path: 'accounting/assetstypes/create', component: AssetsTypeCreateComponent, canActivate: [AuthGuardService] },
    { path: 'accounting/assetstypes/edit', component: AssetsTypeEditComponent, canActivate: [AuthGuardService]},
    
    { path: 'systems', component: SystemsComponent, canActivate: [AuthGuardService]},
    { path: 'systems/cv-devices', component: CVDevicesComponent, canActivate: [AuthGuardService]},
    { path: 'systems/cv-devices/create', component: CvDevicesCreateComponent, canActivate: [AuthGuardService]},
    { path: 'systems/cv-devices/create/characteristics', component: CvDevicesCreateCharacteristicsComponent, canActivate: [AuthGuardService]}, 
    { path: 'systems/cv-devices/create/accesories', component: CvDevicesCreateAccesoriesComponent, canActivate: [AuthGuardService]},      
    { path: 'devices-types', component: DevicesTypesComponent, canActivate: [AuthGuardService]},
    
    { path: 'cell', component: CellComponent, canActivate: [AuthGuardService]},
    { path: '**', redirectTo: ''}//component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }