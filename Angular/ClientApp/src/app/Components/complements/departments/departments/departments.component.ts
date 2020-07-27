import { Component, OnInit } from '@angular/core';
import { IDepartmentsModel } from 'src/app/Models/Departments/departments';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { DepartmentsService } from 'src/app/Services/Departments/departments.service';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})
export class DepartmentsComponent implements OnInit {

  _IDepartments: IDepartmentsModel[];
  _SelectedDepartment: IDepartmentsModel;
 
  constructor(private formBuilder: FormBuilder,  
    private router: Router,
    private departmentService: DepartmentsService,
    private toastr: ToastrService) { }

  //Initializing form fields

  ngOnInit() {
    this.toastr.toastrConfig.preventDuplicates = false;
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.departmentService
      .getDepartments()
      .subscribe(UsersTypes_AWS => this._IDepartments = UsersTypes_AWS,
      error => this.getError(error));
  }

  DepartmentViewForm = this.formBuilder.group({
    id_Departments: [''],
    departmentsName: ['']
  });

  getDataByIdModal(_IDepartments: IDepartmentsModel){

    var idDepartments = _IDepartments.id_Departments;
    
    this.departmentService.getDepartmentsById(idDepartments).subscribe(
        res => 
        {
          this._SelectedDepartment =  res,
          this.DepartmentViewForm = this.formBuilder.group({
            id_Departments: [this._SelectedDepartment.id_Departments],
            departmentsName: [this._SelectedDepartment.departmentsName]
        })
      }
      );   
 
  }

  preUpdate(_IDepartments: IDepartmentsModel){

    var id_Departments = _IDepartments.id_Departments;

    var ruta = `departments/edit/`;

    this.router.navigateByUrl(ruta + `${id_Departments}`);
  }
  
  preDelete(_IDepartments: IDepartmentsModel){
    this.departmentService.deleteDepartments(_IDepartments.id_Departments).subscribe(
      res =>
      {
        location.reload(),
        this.toastr.warning("Eliminación de Departamentos")
      }
    );

  }

  getError(_Error){

    if (_Error && _Error.error) {
      
      return this.toastr.warning(_Error.error[""], "Error en la Carga de Datos");
      
    }
   
  }

}
