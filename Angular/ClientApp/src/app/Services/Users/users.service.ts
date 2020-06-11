import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UsersModel } from '../../Models/Users/users-model';


@Injectable()
export class UsersService {

  url = 'https://localhost:44349/API/Users/Login';
  constructor(private http: HttpClient) {

  }
}
