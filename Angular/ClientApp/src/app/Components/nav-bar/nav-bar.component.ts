import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/Account/account.service';
import { Router } from '@angular/router';
import { IUsersModel } from 'src/app/Models/Users/users-model';

@Component({
  selector: 'navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})

export class NavBarComponent {

  //Declarations Variables

  _IUser: IUsersModel[];

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
    this.accountservice.getCurrentUser()
      .subscribe(User_AWS => this._IUser = User_AWS,
          error => console.error(error));
  }

  // Service consumption "AccountService"
  
  nb_LoggedIn(){
    return this.accountservice.LoggedIn();
  }

}