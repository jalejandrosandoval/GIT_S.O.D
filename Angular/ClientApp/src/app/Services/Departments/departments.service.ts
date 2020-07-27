import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IDepartmentsModel } from 'src/app/Models/Departments/departments';

@Injectable({
  providedIn: 'root'
})
export class DepartmentsService {

  _IDepartments: IDepartmentsModel[];

  readonly ApiPath= '/API/Departments';

  constructor(private http: HttpClient) {
  }

  //Getting DepartmentsData through httpClient of Angular -> ApiPath 

  getDepartments(): Observable<IDepartmentsModel[]>{
    return this.http.get<IDepartmentsModel[]>(this.ApiPath);  
  }

  getDepartmentsById(Id: Number): Observable<IDepartmentsModel>{
    return this.http.get<IDepartmentsModel>(`${this.ApiPath}/${Id}`);
  }
  
  postDepartments(_IDepartmentsModel: IDepartmentsModel): Observable<IDepartmentsModel>{
    return this.http.post<IDepartmentsModel>(this.ApiPath, _IDepartmentsModel)
      .pipe(
        map(Department => {
          return Department;
        }
      ));
  }

  putDepartments(_IDepartmentsModel: IDepartmentsModel): Observable<IDepartmentsModel>{
    return this.http.put<IDepartmentsModel>(`${this.ApiPath}/${_IDepartmentsModel.id_Departments}`,  _IDepartmentsModel);
  }

  deleteDepartments(IdDepartmentDelete : number): Observable<any>{
    return this.http.delete<any>(`${this.ApiPath}/${IdDepartmentDelete}`);
  }
}
