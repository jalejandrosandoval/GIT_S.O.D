import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AssetsTypesService } from 'src/app/Services/Accouting/AssetsTypes/assets-types.service';

@Component({
  selector: 'app-assets-type-create',
  templateUrl: './assets-type-create.component.html',
  styleUrls: ['./assets-type-create.component.css']
})
export class AssetsTypeCreateComponent implements OnInit {

  constructor(private formBuilder: FormBuilder, 
    private toastr: ToastrService,
    private assetstypeservice: AssetsTypesService ,
    private router: Router) { }

  ngOnInit(): void {
  }

  ATypeCreateForm = this.formBuilder.group({
    ATypeId: [null],
    assetsTypeName: ['', {
      Validators: [Validators.required]
    }]
  });

  get gATypeName() {
    return this.ATypeCreateForm.get('assetsTypeName');
  }


  onCreate(){
    
    if(this.ATypeCreateForm.value.UTypeId == null){

      this.assetstypeservice.postAssetsType(this.ATypeCreateForm.value)
        .subscribe(  
        res => {
          this.toastr.success("¡Creación Exitosa!", "Tipo de Activos Fijos:"), 
          this.ATypeCreateForm.reset(),
          this.router.navigate(["/accounting/assetstypes"]);
        },
        error => this.getError(error)  
        );

    }

  }

  getError(_Error){

    if (_Error && _Error.error) {

      this.ATypeCreateForm.reset;
      
      return this.toastr.warning(_Error.error[""], "Error");
      
    }
   
  }
}
