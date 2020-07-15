import { Injectable } from '@angular/core';
import { IAssetsTypes } from 'src/app/Interfaces/Accouting/assets-types';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AssetsTypesService {

  readonly ApiPath= '/API/AssetsTypes';

  constructor(private http: HttpClient) {
  }

  //Getting UsersData through httpClient of Angular -> ApiPath 

  getAssetsTypes(): Observable<IAssetsTypes[]>{
    return this.http.get<IAssetsTypes[]>(this.ApiPath);  

  }
}
