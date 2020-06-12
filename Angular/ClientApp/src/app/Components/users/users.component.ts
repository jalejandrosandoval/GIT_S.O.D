import { Component, OnInit } from '@angular/core';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { UsersService } from 'src/app/Services/Users/users.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  _IUsers: IUsersModel[];
  
  constructor(private userService: UsersService) { }

  ngOnInit() {
    this.getData();
  }

  getData() {
    this.userService
      .getUsers()
      .subscribe(Users_AWS => this._IUsers = Users_AWS,
        error => console.error(error));
  }
}
