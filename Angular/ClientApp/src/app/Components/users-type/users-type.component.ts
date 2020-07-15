import { Component, OnInit } from '@angular/core';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { IUsersTypes } from 'src/app/Interfaces/Users/users-type';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-users-type',
  templateUrl: './users-type.component.html',
  styleUrls: ['./users-type.component.css']
})
export class UsersTypeComponent implements OnInit {

  //Declarations of Variables 

  _IUsersTypes: IUsersTypesModel[];
 
  constructor(
    private userTypeService: UsersTypeService, 
    private router: Router,
    private toastr: ToastrService) { }

  //Initializing form fields

  ngOnInit() {
    this.toastr.toastrConfig.preventDuplicates = false;
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.userTypeService
      .getUsersType()
      .subscribe(UsersTypes_AWS => this._IUsersTypes = UsersTypes_AWS,
        error => this.getError(error));
  }

  preUpdate(_IUTypes: IUsersTypesModel){

    var Id_UsersType = _IUTypes.id_UsersType;

    var ruta = `userstypes/edit/`;

    this.router.navigateByUrl(ruta + `${Id_UsersType}`);
  }
  
  preDelete(_IUTypes: IUsersTypesModel){
    this.userTypeService.deleteUsersType(_IUTypes.id_UsersType).subscribe(
      res =>
      {
        location.reload(),
        this.toastr.warning("Eliminación de Usuario")
      }
    );

  }

  getError(_Error){

    if (_Error && _Error.error) {
      
      return this.toastr.warning(_Error.error[""], "Error en la Carga de Datos");
      
    }
   
  }


}