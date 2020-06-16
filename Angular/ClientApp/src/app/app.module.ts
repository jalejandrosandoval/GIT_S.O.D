import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { ReactiveFormsModule } from '@angular/forms';

//TOASTR
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

//COMPONENTS
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { FooterComponent } from './Components/footer/footer.component';
import { LoginComponent } from './Components/Auth/login/login.component';
import { AboutComponent } from './Components/about/about.component';
import { RecoveryComponent } from './Components/Auth/recovery/recovery.component';
import { HomeComponent } from './Components/home/home.component';
import { UsersComponent } from './Components/users/users.component';
import { UserscreateComponent } from './Components/users/userscreate/userscreate.component';

//SERVICES
import { UsersService } from './Services/Users/users.service';
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    FooterComponent,
    LoginComponent,
    AboutComponent,
    RecoveryComponent,
    HomeComponent,
    UsersComponent,
    UserscreateComponent,
    UserseditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    CommonModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([]), 
    ToastrModule.forRoot({
      closeButton: true,
      positionClass: "toast-top-right"
    }),
    HttpClientModule
  ],
  providers: [UsersService],
  bootstrap: [AppComponent]
})

export class AppModule { }
