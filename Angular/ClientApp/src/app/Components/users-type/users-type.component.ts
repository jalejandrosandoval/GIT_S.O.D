import { Component, OnInit } from '@angular/core';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { IUsersTypes } from 'src/app/Interfaces/Users/users-type';
import { Router } from '@angular/router';

@Component({
  selector: 'app-users-type',
  templateUrl: './users-type.component.html',
  styleUrls: ['./users-type.component.css']
})
export class UsersTypeComponent implements OnInit {

  //Declarations of Variables 

  _IUsersTypes: IUsersTypesModel[];
 
  constructor(private userTypeService: UsersTypeService, private router: Router) { }

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

  preUpdate(_IUTypes: IUsersTypesModel){
    //this.userTypeService._UpdateUType = _IUTypes;

    var Id_UsersType = _IUTypes.id_UsersType;

    var ruta = `userstypes/edit/`;

    var data =Object.values(_IUTypes);

    console.log("Objeto Chingon:" + Object.values(_IUTypes));

    console.log('Id CHingona: ' + data['IdUsersType']); 

    this.router.navigateByUrl(ruta + `${Id_UsersType}`).then(e => {
          if (e) {
            console.log("Navigation is successful!");
          } else {
            console.log("Navigation has failed! :(");
          }
    });

    //console.log("ID: "+ _IUTypes.IdUsersType);//Object.values(_IUTypes));
  }
  
}