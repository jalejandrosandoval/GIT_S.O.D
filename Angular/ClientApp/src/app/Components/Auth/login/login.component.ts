import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private formBuilder : FormBuilder) { }
  
  loginForm = this.formBuilder.group({
    _username: [''],
    _password: [''],
    _rememberme : true
  });

  ngOnInit(): void {
  }

  submit(){
    console.log(this.loginForm.value);
  }

}
