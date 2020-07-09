import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IUsersTypes } from '../../Interfaces/Users/users-type';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { map } from 'rxjs/operators';

@Injectable()
export class UsersTypeService {

  _IUsersTypes: IUsersTypes[];
  _UpdateUType: IUsersTypes[];

  readonly ApiPath= '/API/UsersTypes';

  constructor(private http: HttpClient) {
  }

  //Getting UsersData through httpClient of Angular -> ApiPath 

  getUsersType(): Observable<IUsersTypes[]>{
    return this.http.get<IUsersTypes[]>(this.ApiPath);  
  }
  
  postUsersType(_IUsersTypeModel: IUsersTypesModel): Observable<IUsersTypesModel[]>{
    return this.http.post<IUsersTypesModel[]>(this.ApiPath, _IUsersTypeModel)
      .pipe(
        map(user => {
          return user;
        }
      ));
  }

  putUsersType(_IUsersTypeModel: IUsersTypesModel): Observable<any>{
    return this.http.put<any>(this.ApiPath + "/",  _IUsersTypeModel);
  }

}