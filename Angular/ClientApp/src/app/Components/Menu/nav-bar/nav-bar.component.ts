import { Component, OnInit, Input } from '@angular/core';
import { AccountService } from 'src/app/Services/Account/account.service';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { IUsersModel } from 'src/app/Models/Users/users-model';

@Component({
  selector: 'navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})

export class NavBarComponent {

  //Declarations Variables
  
  @Input() userCurrent : string = 'Username';
  
  //Loading Initial Data in this component

  ngOnInit() {
    this.nb_UserName();
  }

  constructor(private accountservice: AccountService, private router: Router){
    
  }

  //Method for Logout the App

  nb_Logout(){
    this.accountservice.Logout();
    this.router.navigate(["/Login"]);
  }

  //Show the User Data like the username

  nb_UserName(){
    
  }

  // Service consumption "AccountService"
  
  nb_LoggedIn(){
    return this.accountservice.LoggedIn();
  }

}