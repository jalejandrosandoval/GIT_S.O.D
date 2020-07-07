import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IUsersTypes } from '../../Interfaces/Users/users-type';

@Injectable()
export class UsersTypeService {

  readonly ApiPath= '/API/UsersTypes';

  constructor(private http: HttpClient) {
  }

  //Getting UsersData through httpClient of Angular -> ApiPath 

  getUsersType(): Observable<IUsersTypes[]>{
    return this.http.get<IUsersTypes[]>(this.ApiPath);  
  }
  
  postUsersType(){
    return this.http.post
  }

}
