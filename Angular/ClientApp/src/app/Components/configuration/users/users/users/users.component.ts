import { Component, OnInit } from '@angular/core';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { UsersService } from 'src/app/Services/Users/users.service';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  //Declarations of Variables 

  _IUsers: IUsersModel[];
  _SelectedUser: IUsersModel;
  UType: IUsersTypesModel;

  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private toastr: ToastrService,
    private userService: UsersService,
    private usertypeService: UsersTypeService,) { }

  //Initializing form fields

  ngOnInit() {
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.userService
      .getUsers()
      .subscribe(Users_AWS => this._IUsers = Users_AWS,
        error => console.error(error));
  }

  UViewForm = this.formBuilder.group({
    id_Users: [''],
    firstName: [''],
    lastName: [''],
    username: [''],
    n_Identification: [''],
    typeDocument: [''],        
    userPassword: [''],
    status: [''],
    userType: ['']
  });

  getDataByIdModal(_IUsers: IUsersModel){

    var Id_Users = _IUsers.id_Users;
    var Id_UType = _IUsers.id_UsersType;

    this.usertypeService.getUsersTypeById(Id_UType).subscribe(
      res =>
      {
        this.UType = res,
        error => this.getError(error) 
      }
    );

    this.userService.getUsersById(Id_Users).subscribe(
      res => 
      {
        this._SelectedUser =  res,
        this.UViewForm = this.formBuilder.group({
          id_Users: [this._SelectedUser.id_Users],
          firstName: [this._SelectedUser.firstName],
          lastName: [this._SelectedUser.lastName],
          username: [this._SelectedUser.username],
          n_Identification: [this._SelectedUser.n_Identification],
          typeDocument: [this._SelectedUser.typeDocument],          
          userPassword: [this._SelectedUser.userPassword],
          status: [this._SelectedUser.status ? 'Activo' : 'Inactivo'],
          userType: [this.UType.usersTypeName]
        }),
        error => this.getError(error) 
      }
    );   

  }

  preUpdate(_IUsers: IUsersModel){

    var IdUsers = _IUsers.id_Users;

    var ruta = `config/users/edit/`;

    this.router.navigateByUrl(ruta + `${IdUsers}`);
  }

  deactivateUser(_IUsers: IUsersModel){
    
    var idUser = _IUsers.id_Users;
    var idUType = _IUsers.id_UsersType; 
    var status = _IUsers.status;

    if(status = false){

      status = true;
      console.log("False: " + status + " Chingon");

    }else{

      status = false;
      console.log("True: " + status + " Chingon");

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {
      
      return this.toastr.warning(_Error.error[""], "Error al Actualizar Tipo de Usuarios!");
      
    }
   
  }
  
}