import { Component, OnInit } from '@angular/core';
import { DepartmentsService } from 'src/app/Services/Departments/departments.service';
import { IDepartmentsModel } from 'src/app/Models/Departments/departments';
import { Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cv-devices-create',
  templateUrl: './cv-devices-create.component.html',
  styleUrls: ['./cv-devices-create.component.css']
})
export class CvDevicesCreateComponent implements OnInit {

  options: any;
  _IDepartments: IDepartmentsModel[];
  
  constructor(
    private formBuilder: FormBuilder,  
    private router: Router,
    private toastr: ToastrService,
    private departmentsService: DepartmentsService) { }

  ngOnInit(): void {
    this.getData();
  }

  CVDevicesCreateForm = this.formBuilder.group({
    Date: ['',{
      Validators: [Validators.required]
    }],
    Departments: ['', {
      Validators: [Validators.required]
    }]
  });

  get gCVDevicesForm() {
    return this.CVDevicesCreateForm.controls;
  }

  getData(){
    this.departmentsService
      .getDepartments()
      .subscribe(
        UsersTypes_AWS => this._IDepartments = UsersTypes_AWS);
  }

}
