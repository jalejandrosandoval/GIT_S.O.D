import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IDeparmentsColModel } from 'src/app/Models/DepsCitiesCol/Deparments/deparments-model';
import { ICitiesModel } from 'src/app/Models/DepsCitiesCol/Cities/cities-model';

@Injectable({
  providedIn: 'root'
})
export class DepsCitiesColService {

  readonly ApiPath= '/API/DepAndCities';

  constructor(private http: HttpClient) { }

  //Getting UsersData through httpClient of Angular -> ApiPath 
   
  getDeparmentsCol(): Observable<IDeparmentsColModel[]>{
    return this.http.get<IDeparmentsColModel[]>(this.ApiPath + '/GetDeparments');  
  }
  
  getCitiesCol(): Observable<ICitiesModel[]>{
    return this.http.get<ICitiesModel[]>(this.ApiPath + '/GetCities');  
  }

 

}
