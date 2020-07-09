import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IProviders } from 'src/app/Interfaces/providers/providers';

@Injectable({
  providedIn: 'root'
})
export class ProvidersService {

  readonly ApiPath= '/API/Providers';
  
  constructor(private http: HttpClient) {
  }
  
  //Getting UsersData through httpClient of Angular -> ApiPath 
   
  getProviders(): Observable<IProviders[]>{
    return this.http.get<IProviders[]>(this.ApiPath);  
  }

}
