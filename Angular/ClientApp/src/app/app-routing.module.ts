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

import { UsersComponent } from './Components/users/users.component';
import { UserscreateComponent } from './Components/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';

import { UsersTypeComponent } from './Components/users-type/users-type.component';
import { UsersTypeCreateComponent } from './Components/Users-Type/users-type-create/users-type-create.component';
import { UsersTypeEditComponent } from './Components/users-type/users-type-edit/users-type-edit.component';

// MANTENAICE 

import { MantenainceComponent } from './Components/mantenaince/mantenaince.component';

// MANTENAICE - EQUIPMENTS

import { EquipmentsComponent } from './Components/Mantenaince/equipments/equipments.component';

// FABRICATION

import { FabricationComponent } from './Components/fabrication/fabrication.component';

// PURCHASES

import { PurchasesComponent } from './Components/purchases/purchases.component';

// PURCHASES - PROVIDERS

import { ProvidersComponent } from './Components/providers/providers.component';
import { ProvidersTypeComponent } from './Providers-Type/providers-type/providers-type.component';

// ACCOUNTING

import { AccountingComponent } from './Components/Accounting/accounting.component';

import { FixedAssetsComponent } from './Components/Accounting/Fixed-Assets/fixed-assets/fixed-assets.component';

import { AssetsTypeComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type.component';
import { AssetsTypeCreateComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-create/assets-type-create.component';
import { AssetsTypeEditComponent } from './Components/Accounting/Fixed-Assets/assets-type/assets-type-edit/assets-type-edit.component';

// COMPLEMENTS

import { ComplementsComponent } from './Components/complements/complements.component';

/// SERVICE AUTHGUARD

import { AuthGuardService } from './Services/Auth/auth-guard.service';

const routes: Routes = [
  
    { path: '',  component: HomeComponent },
    { path: 'login', component: LoginComponent},
    { path: 'about', component: AboutComponent },
    { path: 'recovery', component: RecoveryComponent },
    { path: 'default', component: DefaultComponent, canActivate: [AuthGuardService]},
    { path: 'users', component: UsersComponent, canActivate: [AuthGuardService]},
    { path: 'users/create', component: UserscreateComponent, canActivate: [AuthGuardService]},
    { path: 'users/edit', component: UserseditComponent, canActivate: [AuthGuardService]},
    { path: 'complements', component: ComplementsComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince', component: MantenainceComponent, canActivate: [AuthGuardService]},
    { path: 'mantenaince/equipments', component: EquipmentsComponent, canActivate: [AuthGuardService]},
    { path: 'providers', component: ProvidersComponent, canActivate: [AuthGuardService]},
    { path: 'fabrication', component: FabricationComponent, canActivate: [AuthGuardService]}, 
    { path: 'userstypes', component: UsersTypeComponent},
    { path: 'userstypes/create', component: UsersTypeCreateComponent},
    { path: 'userstypes/edit/:Id_UsersType', component: UsersTypeEditComponent},
    { path: 'providerstypes', component: ProvidersTypeComponent},
    { path: 'purchases', component: PurchasesComponent},
    { path: 'accounting', component: AccountingComponent},
    { path: 'accounting/fixed-assets', component: FixedAssetsComponent},
    { path: 'accounting/assetstypes', component: AssetsTypeComponent},
    { path: 'accounting/assetstypes/create', component: AssetsTypeCreateComponent},
    { path: 'accounting/assetstypes/edit', component: AssetsTypeEditComponent},
    { path: '**', redirectTo: ''}//component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }