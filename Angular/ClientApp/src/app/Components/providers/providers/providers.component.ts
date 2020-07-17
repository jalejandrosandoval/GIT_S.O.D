import { Component, OnInit } from '@angular/core';
import { IProvidersModel } from 'src/app/Models/Providers/providers';
import { ProvidersService } from 'src/app/Services/Providers/providers.service';

@Component({
  selector: 'app-providers',
  templateUrl: './providers.component.html',
  styleUrls: ['./providers.component.css']
})
export class ProvidersComponent implements OnInit {

  //Declarations of Variables 

   _IProvidersModel: IProvidersModel[];

  constructor(private providersService: ProvidersService) { }

  //Initializing form fields

  ngOnInit() {
    this.getData();
  }

  //Getting Users Informations from WebAPI

  getData() {
    this.providersService
      .getProviders()
      .subscribe(UsersTypes_AWS => this._IProvidersModel = UsersTypes_AWS,
        error => console.error(error));
  }

}
