import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IProvidersModel } from 'src/app/Models/Providers/providers';

@Injectable({
  providedIn: 'root'
})
export class ProvidersService {

  readonly ApiPath= '/API/Providers';
  
  constructor(private http: HttpClient) {
  }
  
  //Getting UsersData through httpClient of Angular -> ApiPath 
   
  getProviders(): Observable<IProvidersModel[]>{
    return this.http.get<IProvidersModel[]>(this.ApiPath);  
  }

  getProvidersById(Id: Number): Observable<IProvidersModel>{
    return this.http.get<IProvidersModel>(`${this.ApiPath}/${Id}`);
  }

}
