import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IUsersTypesModel } from 'src/app/Models/UsersTypes/users-types-model';
import { map } from 'rxjs/operators';

@Injectable()
export class UsersTypeService {

  _IUsersTypes: IUsersTypesModel[];

  readonly ApiPath= '/API/UsersTypes';

  constructor(private http: HttpClient) {
  }

  //Getting UsersData through httpClient of Angular -> ApiPath 

  getUsersType(): Observable<IUsersTypesModel[]>{
    return this.http.get<IUsersTypesModel[]>(this.ApiPath);  
  }

  getUsersTypeById(Id: Number): Observable<IUsersTypesModel>{
    return this.http.get<IUsersTypesModel>(this.ApiPath + '/' + Id);  
  }
  
  postUsersType(_IUsersTypeModel: IUsersTypesModel): Observable<IUsersTypesModel>{
    return this.http.post<IUsersTypesModel>(this.ApiPath, _IUsersTypeModel)
      .pipe(
        map(user => {
          return user;
        }
      ));
  }

  putUsersType(_IUsersTypeModel: IUsersTypesModel): Observable<IUsersTypesModel>{

    return this.http.put<IUsersTypesModel>(`${this.ApiPath}/${_IUsersTypeModel.id_UsersType}`,  _IUsersTypeModel);
  }

  deleteUsersType(IdUserDelete : number): Observable<any>{
    return this.http.delete<any>(this.ApiPath + "/" + IdUserDelete);
  }

}