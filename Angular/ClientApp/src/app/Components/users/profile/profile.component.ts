import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { UsersService } from 'src/app/Services/Users/users.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  _IUsers: IUsersModel[];
  _SelectedUser: IUsersModel;
  
  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private toastr: ToastrService,
    private userService: UsersService) { }

  UProfileForm = this.formBuilder.group({
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

  ngOnInit(): void {
  }

}
