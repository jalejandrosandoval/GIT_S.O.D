import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { LoginModel } from 'src/app/Models/Login/login-model';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  readonly ApiPath= '/API/Account/Login' ;

  public currentUser: Observable<IUsersModel>;
  private currentUserSubject: BehaviorSubject<IUsersModel>;
  
  constructor(private http: HttpClient){

    this.currentUserSubject = new BehaviorSubject<IUsersModel>(
                              JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();

  }

  getToken(): string{
    return localStorage.getItem("Token");
  }

  getExpirationToken(): string {
    return localStorage.getItem("TokenExpiration");
  }

  getCurrentUser(): IUsersModel{
    return this.currentUserSubject.value;
  }

  Login(_LoginModel: LoginModel): Observable<any> {
    return this.http.post<any>(this.ApiPath, _LoginModel)
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
