import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/Account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'navbar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})

export class NavBarComponent {

  constructor(private accountservice: AccountService, private router: Router){

  }

  nb_Logout(){
    this.accountservice.Logout();
    this.router.navigate(["/Login"]);
  }

  nb_LoggedIn(){
    return this.accountservice.LoggedIn();
  }

}