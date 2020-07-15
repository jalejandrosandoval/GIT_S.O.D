import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UsersTypeService } from 'src/app/Services/UsersType/users-type.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-users-type-create',
  templateUrl: './users-type-create.component.html',
  styleUrls: ['./users-type-create.component.css']
})
export class UsersTypeCreateComponent implements OnInit {

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService,
    private userTypeService: UsersTypeService,
    private router: Router) { }

  ngOnInit(): void {
  }

  UTypeCreateForm = this.formBuilder.group({
    UTypeId: [null],
    usersTypeName: ['', {
      Validators: [Validators.required]
    }]
  });

  get gUsername() {
    return this.UTypeCreateForm.get('usersTypeName');
  }

  onCreate(){

    
    if(this.UTypeCreateForm.value.UTypeId == null){

      this.userTypeService.postUsersType(this.UTypeCreateForm.value)
        .subscribe(  
        res => {
          this.toastr.success("¡Creación Exitosa!", "Tipo de Usuarios:"), 
          this.UTypeCreateForm.reset(),
          this.router.navigate(["/userstypes"]);
        },
        error => this.getError(error)  
        );

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.UTypeCreateForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error");
      
    }
   
  }
  
}
