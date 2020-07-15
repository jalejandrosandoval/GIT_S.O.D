import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-type-edit',
  templateUrl: './users-type-edit.component.html',
  styleUrls: ['./users-type-edit.component.css']
})
export class UsersTypeEditComponent implements OnInit {

  //Declarations of Variables 

  _SelectedUserType: IUsersTypesModel;
  UTypeEditForm : FormGroup;

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService,
    private userTypeService: UsersTypeService,
    private route: ActivatedRoute,
    private router: Router) {

    }

  ngOnInit(): void {
    
    const UTypeId = this.route.snapshot.params['Id_UsersType'];

    this.setForm(UTypeId);
   
  }

  private setForm(_UTypeId: Number){

    this.userTypeService.getUsersTypeById(_UTypeId).subscribe(
      res => 
      {
        this._SelectedUserType = res,
        this.UTypeEditForm = this.formBuilder.group({
          id_UsersType: [this._SelectedUserType.id_UsersType],
          usersTypeName: [this._SelectedUserType.usersTypeName, {
            Validators: [Validators.required]
          }]
        })
      }
    );
      
  }

  get UTypeEditFormData() { 
    return this.UTypeEditForm.controls; 
  }

  onEdit(){

    if (this.UTypeEditForm.invalid) {

      return;
    
    }else{
      
      this.userTypeService.putUsersType(this.UTypeEditForm.value).subscribe(
        res => {
          this.toastr.show("¡Actualización Exitosa!", "Tipo de Usuarios:"),
          this.router.navigateByUrl("userstypes")
        },
        error => this.getError(error), 
      );

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.UTypeEditForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error al Actualizar Tipo de Usuarios!");
      
    }
   
  }

}