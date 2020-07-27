import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IUsersModel } from 'src/app/Models/Users/users-model';
import { map } from 'rxjs/operators';

@Injectable()
export class UsersService {
  
  _IUsers: IUsersModel[];

  readonly ApiPath = '/API/Users';

  constructor(private http: HttpClient) {
  }

  //Getting UsersData through httpClient of Angular -> ApiPath 

  getUsers(): Observable<IUsersModel[]>{
    return this.http.get<IUsersModel[]>(this.ApiPath);  
  }

  getUsersById(Id: Number): Observable<IUsersModel>{
    return this.http.get<IUsersModel>(`${this.ApiPath}/${Id}`);
  }

  postUsersType(_IUsersModel: IUsersModel): Observable<IUsersModel>{
    return this.http.post<IUsersModel>(this.ApiPath, _IUsersModel)
      .pipe(
        map(user => {
          return user;
        }
      ));
  }

  putUsers(_IUsersModel: IUsersModel): Observable<IUsersModel>{
    return this.http.put<IUsersModel>(`${this.ApiPath}/${_IUsersModel.id_Users}`,  _IUsersModel);
  }
  
  deleteUsers(IdUserDelete : number): Observable<any>{
    return this.http.delete<any>(`${this.ApiPath}/${IdUserDelete}`);
  }
}
