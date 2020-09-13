import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IConfigInitial } from 'src/app/Models/Config/config-initial';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ConfigInitialService {

  readonly ApiPath = '/API/Config_Initi';

  constructor(private http: HttpClient) {
  }

  //Getting ConfigInitial through httpClient of Angular -> ApiPath 
   
  getConfigInit(): Observable<IConfigInitial[]>{
    return this.http.get<IConfigInitial[]>(this.ApiPath);  
  }

  getConfigInitById(Id: Number): Observable<IConfigInitial>{
    return this.http.get<IConfigInitial>(`${this.ApiPath}/${Id}`);
  }

  postConfigInit(_IConfig: IConfigInitial): Observable<IConfigInitial>{
    return this.http.post<IConfigInitial>(this.ApiPath, _IConfig)
      .pipe(
        map(config => {
          return config;
        }
      ));
  }
  
  putConfigInit(_IConfig: IConfigInitial): Observable<IConfigInitial>{
    return this.http.put<IConfigInitial>(`${this.ApiPath}/${_IConfig.id_ConfigInit}`, _IConfig);
  }
  
  deleteConfigInit(IdConfig : number): Observable<any>{
    return this.http.delete<any>(`${this.ApiPath}/${IdConfig}`);
  }

}