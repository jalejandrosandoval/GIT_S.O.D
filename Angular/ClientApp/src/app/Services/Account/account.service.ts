import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login/login-model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  readonly ApiPath= '/API/Account/Login' ;
  
  constructor(private http: HttpClient) {
  }

  Login(_LoginModel: LoginModel): Observable<any>{
    return this.http.post<any>(this.ApiPath, _LoginModel);
  }

  getToken(): string{
    return localStorage.getItem("Token");
  }

  getExpirationToken(): string {
    return localStorage.getItem("TokenExpiration");
  }

  Logout(){
    localStorage.removeItem("Token");
    localStorage.removeItem("TokenExpiration");
  }

  LoggedIn(){
    
    var expiration = this.getExpirationToken();

    if(!expiration){

      return false;
      this.Logout();
      
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

}
