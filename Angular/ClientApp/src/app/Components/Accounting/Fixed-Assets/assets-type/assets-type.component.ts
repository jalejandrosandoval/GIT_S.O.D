import { Component, OnInit } from '@angular/core';
import { AssetsTypesModel } from 'src/app/Models/Accouting/AssetsTypes/assets-types-model';
import { AssetsTypesService } from 'src/app/Services/Accouting/AssetsTypes/assets-types.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-assets-type',
  templateUrl: './assets-type.component.html',
  styleUrls: ['./assets-type.component.css']
})
export class AssetsTypeComponent implements   OnInit {

  //Declarations of Variables 

  _IAssetsTypes: AssetsTypesModel[];
 
  constructor(
    private assetstypesservice: AssetsTypesService,
    private router: Router) { }

  //Initializing form fields

  ngOnInit() {
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.assetstypesservice
      .getAssetsTypes()
      .subscribe(UsersTypes_AWS => this._IAssetsTypes = UsersTypes_AWS,
        error => console.error(error));
  }

  preUpdate(_IAssetsTypes: AssetsTypesModel){

    //var Id_UsersType = _IUTypes.id_UsersType;

    var ruta = `/accounting/assetstypes/`;

    this.router.navigateByUrl(ruta); //+ `${Id_UsersType}`);
  }
  
  preDelete(_IAssetsTypes: AssetsTypesModel){
    /*this.userTypeService.deleteUsersType(_IUTypes.id_UsersType).subscribe(
      res =>
      {
        location.reload(),
        this.toastr.warning("Eliminación de Usuario")
      }
    );*/

  }

}