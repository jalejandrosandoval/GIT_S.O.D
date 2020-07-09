import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';

@Component({
  selector: 'app-users-type-edit',
  templateUrl: './users-type-edit.component.html',
  styleUrls: ['./users-type-edit.component.css']
})
export class UsersTypeEditComponent implements OnInit {

  //Declarations of Variables 

  _IUsersTypes: IUsersTypesModel[];

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService,
    private userTypeService: UsersTypeService) {

    }

  ngOnInit(): void {
    this._IUsersTypes = this.userTypeService._UpdateUType;
    console.log("NOnInit: " + Object.values(this._IUsersTypes));
  }

  UTypeEditForm = this.formBuilder.group({
    Id_UsersType: [''],
    usersTypeName: ['', {
      Validators: [Validators.required]
    }]
  });
  
  get gUsername() {
    return this.UTypeEditForm.get('usersTypeName');
  }

  onEdit(){
    
    /**if(this.UTypeEditForm.value.UTypeId != null){
      this.userTypeService.putUsersType(this.UTypeEditForm.value)
        .subscribe(  
        res => {this.toastr.show("¡Actualización Exitosa!", "Tipo de Usuarios:")},
        error => this.getError(error)  
        );
      }*/

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.UTypeEditForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error");
      
    }
   
  }

}
