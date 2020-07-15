import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AssetsTypesModel } from 'src/app/Models/Accouting/AssetsTypes/assets-types-model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AssetsTypesService {

  _IAssetsType: AssetsTypesModel[];

  readonly ApiPath= '/API/AssetsTypes';

  constructor(private http: HttpClient) {
  }

  //Getting AssetsTypesData through httpClient of Angular -> ApiPath 

  getAssetsTypes(): Observable<AssetsTypesModel[]>{
    return this.http.get<AssetsTypesModel[]>(this.ApiPath);  
  }

  getAssetsTypesById(Id: Number): Observable<AssetsTypesModel>{
    return this.http.get<AssetsTypesModel>(`${this.ApiPath}/${Id}`);
  }

  postAssetsType(_IAssetsType: AssetsTypesModel): Observable<AssetsTypesModel>{
    return this.http.post<AssetsTypesModel>(this.ApiPath, _IAssetsType)
      .pipe(
        map(assetstype => {
          return assetstype;
        }
      ));
  }

  putAssetsType(_IAssetsType: AssetsTypesModel): Observable<AssetsTypesModel>{
    return this.http.put<AssetsTypesModel>(`${this.ApiPath}/${_IAssetsType.id_AssetsType}`,  _IAssetsType);
  }

  deleteAssetsType(IdAssetsTypeDelete: Number): Observable<AssetsTypesModel>{
    return this.http.delete<AssetsTypesModel>(`${this.ApiPath}/${IdAssetsTypeDelete}`);
  }


}
