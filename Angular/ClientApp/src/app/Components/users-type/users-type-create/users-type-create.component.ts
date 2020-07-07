import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-users-type-create',
  templateUrl: './users-type-create.component.html',
  styleUrls: ['./users-type-create.component.css']
})
export class UsersTypeCreateComponent implements OnInit {

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  UTypeCreateForm = this.formBuilder.group({
    UTypeName: ['', {
      Validators: [Validators.required]
    }]
  });

  get gUsername() {
    return this.UTypeCreateForm.get('UTypeName');
  }

  onCreate(){

  }

}
