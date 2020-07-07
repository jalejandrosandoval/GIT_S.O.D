import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

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
import { UserseditComponent } from './Components/users/usersedit/usersedit.component';
import { DefaultComponent } from './Components/default/default.component';
import { ComplementsComponent } from './Components/complements/complements.component';
import { MantenainceComponent } from './Components/mantenaince/mantenaince.component';
import { EquipmentsComponent } from './Components/Mantenaince/equipments/equipments.component';
import { ProvidersComponent } from './Components/providers/providers.component';
import { PageNotFoundComponent } from './Components/page-not-found/page-not-found.component';
import { FabricationComponent } from './Components/fabrication/fabrication.component';
import { UsersTypeComponent } from './Components/users-type/users-type.component';

//SERVICES
import { UsersService } from './Services/Users/users.service';
import { AuthGuardService } from './Services/Auth/auth-guard.service';
import { AccountService } from './Services/Account/account.service';
import { UsersTypeService } from './Services/UsersType/users-type.service';

//INTERCEPTORS OF HTTP
import { AuthInterceptorService } from './Services/Auth/auth-interceptor.service';
import { ErrorInterceptorService } from './Services/Auth/error-interceptor.service';
import { UsersTypeCreateComponent } from './Components/Users-Type/users-type-create/users-type-create.component';

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
    UserseditComponent,
    DefaultComponent,
    ComplementsComponent,
    MantenainceComponent,
    EquipmentsComponent,
    ProvidersComponent,
    PageNotFoundComponent,
    FabricationComponent,
    UsersTypeComponent,
    UsersTypeCreateComponent
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