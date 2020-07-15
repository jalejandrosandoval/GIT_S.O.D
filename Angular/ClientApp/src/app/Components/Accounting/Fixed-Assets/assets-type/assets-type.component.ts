import { Component, OnInit } from '@angular/core';
import { AssetsTypesModel } from 'src/app/Models/Accouting/AssetsTypes/assets-types-model';
import { AssetsTypesService } from 'src/app/Services/Accouting/AssetsTypes/assets-types.service';

@Component({
  selector: 'app-assets-type',
  templateUrl: './assets-type.component.html',
  styleUrls: ['./assets-type.component.css']
})
export class AssetsTypeComponent implements   OnInit {

  //Declarations of Variables 

  _IAssetsTypes: AssetsTypesModel[];
 
  constructor(private assetstypesservice: AssetsTypesService) { }

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

}