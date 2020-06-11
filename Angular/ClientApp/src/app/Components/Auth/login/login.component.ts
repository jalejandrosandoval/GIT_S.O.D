import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private formBuilder : FormBuilder, private toastr: ToastrService) { }
  
  ngOnInit(): void {
    }

  loginForm = this.formBuilder.group({
    _username: ['', {
      Validators: [Validators.required]
    }],

    _password: ['', {
      Validators: [Validators.required]
    }],

    _rememberme : [true]

  });

  get gUsername() {
    return this.loginForm.get('_username');
  }

  get gPassword() {
    return this.loginForm.get('_password');
  }

  
  onReset(){
    this.loginForm.reset();
  }
  
  onLogin(){

    if(this.loginForm.valid){
      
      this.toastr.success("Campos Correctos: ", "Exito!");
      //console.log('Form->',this.loginForm.value);

    }else{
      
      this.toastr.error("Error","Campos Incorrectos");
      //console.log('Form X');
      //this.onReset();
    }

  }

}
