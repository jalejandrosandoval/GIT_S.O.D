import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/Account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  
  constructor(private accountservice: AccountService, private router: Router){
    
  }
  
  ngOnInit() {
    
  }

  //Method for Logout the App

  nb_Logout(){
    this.accountservice.Logout();
    this.router.navigate(["/Login"]);
  }

  // Service consumption "AccountService"
  
  nb_LoggedIn(){
    return this.accountservice.LoggedIn();
  }

}
