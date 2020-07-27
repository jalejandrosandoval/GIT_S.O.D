import { Component, OnInit } from '@angular/core';
import { IDepartmentsModel } from 'src/app/Models/Departments/departments';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { DepartmentsService } from 'src/app/Services/Departments/departments.service';

@Component({
  selector: 'app-departments-create',
  templateUrl: './departments-create.component.html',
  styleUrls: ['./departments-create.component.css']
})
export class DepartmentsCreateComponent implements OnInit {

  constructor(private formBuilder: FormBuilder,  
    private router: Router,
    private departmentService: DepartmentsService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  DepartmentsCreateForm = this.formBuilder.group({
    DeparmentsId: [null],
    DepartmentsName: ['', {
      Validators: [Validators.required]
    }]
  });

  get gDepartmentsName() {
    return this.DepartmentsCreateForm.get('DepartmentsName');
  }

  onCreate(){

    if(this.DepartmentsCreateForm.value.UTypeId == null){

      this.departmentService.postDepartments(this.DepartmentsCreateForm.value)
        .subscribe(  
        res => {
          this.toastr.success("¡Creación Exitosa!", "Departamentos:"), 
          this.DepartmentsCreateForm.reset(),
          this.router.navigate(["/departments"]);
        },
        error => this.getError(error)  
        );

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.DepartmentsCreateForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error");
      
    }
   
  }

}
