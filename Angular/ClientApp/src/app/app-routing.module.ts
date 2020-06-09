import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'login', component: LoginComponent },
    { path: 'about', component: AboutComponent },
    { path: 'recovery', component: RecoveryComponent },
    { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
