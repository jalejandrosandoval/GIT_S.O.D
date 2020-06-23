import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/Account/account.service';
import { LoginModel } from 'src/app/Models/Login/login-model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {


  constructor(private accountservice: AccountService, private router: Router,
    private formBuilder: FormBuilder, private toastr: ToastrService) { }

  ngOnInit(): void {
    
  }

  loginForm = this.formBuilder.group({
    Username: ['', {
      Validators: [Validators.required]
    }],

    UserPassword: ['', {
      Validators: [Validators.required]
    }]

  });

  get gUsername() {
    return this.loginForm.get('Username');
  }

  get gPassword() {
    return this.loginForm.get('UserPassword');
  }

  onReset() {
    this.loginForm.reset();
  }

  getTokenAPI(_Token) {
    localStorage.setItem('Token', _Token.token);
    localStorage.setItem('TokenExpiration', _Token.expiration);
    this.router.navigate(["/Login"]);
  }

  onLogin() {

    if (this.loginForm.valid) {

      let _LoginModel: LoginModel;
      
      _LoginModel = Object.assign({}, this.loginForm.value);

      this.accountservice.Login(_LoginModel).subscribe(token => this.getTokenAPI(token),
      error => this.getError(error));

      this.toastr.warning("Username: ", _LoginModel.Username + " " + _LoginModel.UserPassword);

    }
    
  }

  getError(_Error){

    if (_Error && _Error.error) {
      this.toastr.error("Error", _Error.error[""]);
    }
   
  }

}
