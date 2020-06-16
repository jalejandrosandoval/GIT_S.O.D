import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';
import { UsersComponent } from './Components/users/users.component';
import { UserscreateComponent } from './Components/users/userscreate/userscreate.component';
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'login', component: LoginComponent },
    { path: 'about', component: AboutComponent },
    { path: 'recovery', component: RecoveryComponent },
    { path: 'users', component: UsersComponent},
    { path: 'users/create', component: UserscreateComponent},
    { path: 'users/edit', component: UserseditComponent},
    { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
