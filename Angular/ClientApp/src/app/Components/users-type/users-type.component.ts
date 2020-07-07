import { Component, OnInit } from '@angular/core';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';

@Component({
  selector: 'app-users-type',
  templateUrl: './users-type.component.html',
  styleUrls: ['./users-type.component.css']
})
export class UsersTypeComponent implements OnInit {

  //Declarations of Variables 

  _IUsersTypes: IUsersTypesModel[];
  
  constructor(private userTypeService: UsersTypeService) { }

  //Initializing form fields

  ngOnInit() {
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.userTypeService
      .getUsersType()
      .subscribe(UsersTypes_AWS => this._IUsersTypes = UsersTypes_AWS,
        error => console.error(error));
  }

}