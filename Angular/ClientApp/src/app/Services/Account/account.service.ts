import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login/login-model';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { IUsers } from 'src/app/Interfaces/Users/users';

@Injectable({
  providedIn: 'root'
})
export class AccountService implements OnInit {

  // Declarations Variables 

  _SUserCurrent : string;

  readonly ApiPath= '/API/Account' ;
  
  constructor(private http: HttpClient, private router: Router){
    
  }

  ngOnInit(): void {
   
  }

  //Getting Token from LocalStorage

  getToken(): string{
    return localStorage.getItem("Token");
  }

  //Getting Expiration Token from LocalStorage

  getExpirationToken(): string {
    return localStorage.getItem("TokenExpiration");
  }

  // CurrentUser
  
  getCurrentUser(_LoginModel: LoginModel): Observable<IUsers[]> {
    return this.http.post<IUsers[]>(this.ApiPath + '/GetUser', _LoginModel);
  }  

  UsernameCurentUser(){

    if(this._SUserCurrent == null){
    
      console.log("Account Null " + this._SUserCurrent);
      return null;
    
    }else{
      console.log("Account Else " + this._SUserCurrent);
      return this._SUserCurrent;
    }

  }

  //Request through httpClient of Angular -> ApiPath 

  Login(_LoginModel: LoginModel): Observable<any> {
    
    return this.http.post<any>(this.ApiPath + '/Login', _LoginModel)
      .pipe(map(user => {
        localStorage.setItem('currenteUser',
          JSON.stringify(user))
        return user;
      }
      ));
  
  }

  Logout(){
    localStorage.removeItem("Token");
    localStorage.removeItem("TokenExpiration");
  }

  //Method for Validations loggedIn

  LoggedIn(){
    
    var expiration = this.getExpirationToken();

    if(!expiration){

      this.Logout();
      return false;
      
    }

    var DateExpiration = new Date(expiration);
    var DateNow = new Date().getTime();

    if(DateNow >= DateExpiration.getTime()){

      this.Logout();
      return false;

    }else{

      return true;

    }

  }

  onLoginRedirect(): void {
    this.router.navigate(['/default']);
  }

}