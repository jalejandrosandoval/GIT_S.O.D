import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/Services/Account/account.service';
import { LoginModel } from 'src/app/Models/Login/login-model';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { Observable } from 'rxjs';
import { IConfigInitial } from 'src/app/Models/Config/config-initial';
import { ConfigInitialService } from 'src/app/Services/Config/config-initial.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  _IConfigInit: IConfigInitial;
  _IUsers: IUsersModel[];
  _InUserCurrent : Observable<IUsersModel[]>;

  constructor(
    private configInitService: ConfigInitialService,
    private accountservice: AccountService, 
    private router: Router,
    private formBuilder: FormBuilder, 
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.dataConfig();
  }

  private dataConfig(){
    
    var _ConfigId = 1;

    // this.configInitService.getConfigInit().subscribe(res=> {this._IConfigInit = res 
    //   });

    this.configInitService.getConfigInitById(_ConfigId).subscribe(
      res => 
      {
        this._IConfigInit = res
        // console.log(Object.values(this._IConfigInit))
      }
    );    // this.configInitService
    //   .getConfigInitById(_ConfigId)
    //   .subscribe(
    //     res =>
    //     {
    //       this._IConfigInit = res
    //     },
    //     error => this.getError(error)
    //   );

      

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