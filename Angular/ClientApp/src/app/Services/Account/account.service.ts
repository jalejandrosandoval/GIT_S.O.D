import { Injectable, ɵConsole } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login/login-model';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { IUsers } from 'src/app/Interfaces/Users/users';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  // Declarations Variables 

  readonly ApiPath= '/API/Account' ;

  public cUser : LoginModel;
  public currentUser: Observable<IUsersModel>;
  private currentUserSubject: BehaviorSubject<IUsersModel>;
  
  constructor(private http: HttpClient, private router: Router){

    this.currentUserSubject = new BehaviorSubject<IUsersModel>(
                              JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();

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
  
  getCurrentUser(): Observable<any> {

    if(this.cUser == null){

      return;
    
    }else{
    
      return this.http.post<any>(this.ApiPath + '/GetUser', this.cUser);
    
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
    this.currentUserSubject.next(null);
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

}