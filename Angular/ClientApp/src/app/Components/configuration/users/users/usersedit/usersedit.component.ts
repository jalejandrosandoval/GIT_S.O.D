import { Component, OnInit } from '@angular/core';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { UsersService } from 'src/app/Services/Users/users.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-usersedit',
  templateUrl: './usersedit.component.html',
  styleUrls: ['./usersedit.component.css']
})
export class UserseditComponent implements OnInit {
  
  //Declarations of Variables 

  UserEditForm : FormGroup;

  _IUsers: IUsersModel[];
  _SelectedUser: IUsersModel;

  UType: IUsersTypesModel;

  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute,
    private toastr: ToastrService,
    private userService: UsersService,
    private usertypeService: UsersTypeService,) { }

  ngOnInit(): void {

    const UTypeId = this.route.snapshot.params['IdUsers'];

    this.setForm(UTypeId);

  }

  private setForm(_UserId: Number){

    this.userService.getUsersById(_UserId).subscribe(
      res => 
      {
        this._SelectedUser = res,
        this.usertypeService.getUsersTypeById(this._SelectedUser.id_UsersType).pipe(
          (map(res=>{
            this.UType = res;
          }))
        ),
        this.UserEditForm = this.formBuilder.group({
          id_Users: [this._SelectedUser.id_Users, {Validators: [Validators.required]}],
          firstName: [this._SelectedUser.firstName, {Validators: [Validators.required]}],
          lastName: [this._SelectedUser.lastName, {Validators: [Validators.required]}],
          username: [this._SelectedUser.username, {Validators: [Validators.required]}],
          n_Identification: [this._SelectedUser.n_Identification, {Validators: [Validators.required]}],
          typeDocument: [this._SelectedUser.typeDocument, {Validators: [Validators.required]}],       
          userPassword: [this._SelectedUser.userPassword, {Validators: [Validators.required]}],
          status: [this._SelectedUser.status, {Validators: [Validators.required]}],
          id_UsersType: [this._SelectedUser.id_UsersType]
        })
      }
    );
      
  }

  get UserEditFormData() { 
    return this.UserEditForm.controls; 
  }

  onEdit(){

    if (this.UserEditForm.invalid) {

      return;
    
    }else{
      
      this.userService.putUsers(this.UserEditForm.value).subscribe(
        res => {
          this.toastr.info("¡Actualización Exitosa!", "Usuarios:"),
          this.router.navigateByUrl("config/users")
        },
        error => this.getError(error), 
      );
      
      console.log(Object.values(this.UserEditForm));

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.UserEditForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error al Actualizar Tipo de Usuarios!");
      
    }
   
  }

}
