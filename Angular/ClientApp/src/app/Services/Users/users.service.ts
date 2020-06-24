import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IUsers } from '../../Interfaces/Users/users';

@Injectable()
export class UsersService {
  
  readonly ApiPath= '/API/Users';
  
  constructor(private http: HttpClient) {
  }

  getUsers(): Observable<IUsers[]>{
    return this.http.get<IUsers[]>(this.ApiPath);  
  }
  
}
