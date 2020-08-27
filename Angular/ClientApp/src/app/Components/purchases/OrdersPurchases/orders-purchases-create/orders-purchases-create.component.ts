import { Component, OnInit } from '@angular/core';
import { Variable } from '@angular/compiler/src/render3/r3_ast';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { ProvidersService } from 'src/app/Services/Providers/providers.service';
import { IProvidersModel } from 'src/app/Models/Providers/providers';
import { DepsCitiesColService } from 'src/app/Services/DepsCities-Col/deps-cities-col.service';
import { IDeparmentsColModel } from 'src/app/Models/DepsCitiesCol/Deparments/deparments-model';
import { ICitiesModel } from 'src/app/Models/DepsCitiesCol/Cities/cities-model';

@Component({
  selector: 'app-orders-purchases-create',
  templateUrl: './orders-purchases-create.component.html',
  styleUrls: ['./orders-purchases-create.component.css']
})
export class OrdersPurchasesCreateComponent implements OnInit {

  private year: number = new Date().getFullYear();
  public num : any;

  _IProvidersModel: IProvidersModel[];
  _Provider: IProvidersModel
  _IDepartmentsCol: IDeparmentsColModel[];
  _ICitiesCol: ICitiesModel[];

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService,
    private router: Router,
    private providersService: ProvidersService,
    private depsCitiesColService: DepsCitiesColService) {
    
  }

  OPurchasesCreateForm =  this.formBuilder.group({ 
    Nit_Provider: [''],
    NameProvider: [''],
    Departments: ['', {
      Validators: [Validators.required]
    }],
    Cities: ['', {
      Validators: [Validators.required]
    }]
  });
 
  ngOnInit(): void {
    this.getDepsCities();
    this.getProviders();
    this.num =  this.year.toString().substr(-2);
  }

  getDepsCities(){
    this.depsCitiesColService
      .getDeparmentsCol()
      .subscribe(
        Deps_AWS => this._IDepartmentsCol = Deps_AWS,
        error => this.getError(error)
      );

    this.depsCitiesColService
      .getCitiesCol()
      .subscribe(
        Cities_AWS => this._ICitiesCol = Cities_AWS,
        error => this.getError(error)
      );
  }


  getProviders() {
    this.providersService
      .getProviders()
      .subscribe(UsersTypes_AWS => this._IProvidersModel = UsersTypes_AWS,
        error => console.error(error));
  }

  getProviderSelected(_Provider: IProvidersModel){
    var id_Providers = _Provider.id_Providers;

    console.log("IdProv: " + _Provider.id_Providers);
    console.log("NITPROVEEDOR: " + _Provider.identification);
    // console.log(Object.values(_Provider));

    this.providersService.getProvidersById(id_Providers).subscribe(
      res =>
      {
        this._Provider = res,
        this.OPurchasesCreateForm = this.formBuilder.group({
          Nit_Provider: [this._Provider.identification],
          NameProvider: [this._Provider.providerName]
        }),
        error => this.getError(error)
      }
    );
   
  }
  
  getError(_Error){

    if (_Error && _Error.error) {
      
      return this.toastr.warning(_Error.error[""], "Error en la Generación de la Orden de Compra!");
      
    }
   
  }
  
}
