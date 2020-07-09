import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/Account/account.service';
import { LoginModel } from 'src/app/Models/Login/login-model';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { IUsers } from 'src/app/Interfaces/Users/users';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  _IUsers: IUsersModel[];
  _InUserCurrent : Observable<IUsers[]>;

  constructor(private accountservice: AccountService, private router: Router,
    private formBuilder: FormBuilder, private toastr: ToastrService) { }

  ngOnInit(): void {
    
  }

  //Initializing form fields

  loginForm = this.formBuilder.group({
    Username: ['', {
      Validators: [Validators.required]
    }],

    UserPassword: ['', {
      Validators: [Validators.required]
    }]

  });

  //Getting Data Fields
  
  get gUsername() {
    return this.loginForm.get('Username');
  }

  get gPassword() {
    return this.loginForm.get('UserPassword');
  }

  //Reset Fields

  onReset() {
    this.loginForm.reset();
  }

  //Getting Token from API REST

  getTokenAPI(_Token) {
    localStorage.setItem('Token', _Token.token);
    localStorage.setItem('TokenExpiration', _Token.expiration);
    this.router.navigate(["/Login"]);
  }

  //Method for Loging User 

  onLogin() {

    if (this.loginForm.valid) {

      let _LoginModel: LoginModel;
      
      _LoginModel = Object.assign({}, this.loginForm.value);

      this.currentUser(_LoginModel);
      
      this.accountservice
        .Login(_LoginModel)
        .subscribe(
          res => {
            this.getTokenAPI(res)
            this.router.navigate(['/default']);
          },
          error => this.getError(error), 
      );

    }
    
  }

  currentUser(_LoginModel: LoginModel){

    //this._InUserCurrent. = this.accountservice.getCurrentUser(_LoginModel);
    
  }
 
  //Getting Error from Web Api and Show the error from toastr window

  getError(_Error){

    if (_Error && _Error.error) {

      this.loginForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error");
      
    }
   
  }

}