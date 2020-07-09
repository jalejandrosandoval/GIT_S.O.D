import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// COMPONENTS

import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';
import { UsersComponent } from './Components/users/users.component';
import { UserscreateComponent } from './Components/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';
import { DefaultComponent } from './Components/default/default.component';
import { ComplementsComponent } from './Components/complements/complements.component';
import { MantenainceComponent } from './Components/mantenaince/mantenaince.component';
import { EquipmentsComponent } from './Components/Mantenaince/equipments/equipments.component';
import { ProvidersComponent } from './Components/providers/providers.component';
import { PageNotFoundComponent } from './Components/page-not-found/page-not-found.component';
import { FabricationComponent } from './Components/fabrication/fabrication.component';
import { UsersTypeComponent } from './Components/users-type/users-type.component';
import { UsersTypeCreateComponent } from './Components/Users-Type/users-type-create/users-type-create.component';
import { ProvidersTypeComponent } from './Providers-Type/providers-type/providers-type.component';
import { UsersTypeEditComponent } from './Components/users-type/users-type-edit/users-type-edit.component';

// SERVICE AUTHGUARD
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
    { path: 'userstypes/edit', component: UsersTypeEditComponent},
    { path: 'providerstypes', component: ProvidersTypeComponent},
    { path: '**', redirectTo: ''}//component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }