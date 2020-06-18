import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// components

import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';
import { UsersComponent } from './Components/users/users.component';
import { UserscreateComponent } from './Components/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';
import { DefaultComponent } from './Components/default/default.component';

// SERVICE AUTH
import { AuthGuardService } from './Services/Auth/auth-guard.service';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'login', component: LoginComponent },
    { path: 'about', component: AboutComponent },
    { path: 'recovery', component: RecoveryComponent },
    { path: 'default', component: DefaultComponent, canActivate: [AuthGuardService]},
    { path: 'users', component: UsersComponent, canActivate: [AuthGuardService]},
    { path: 'users/create', component: UserscreateComponent, canActivate: [AuthGuardService]},
    { path: 'users/edit', component: UserseditComponent, canActivate: [AuthGuardService]},
    { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }