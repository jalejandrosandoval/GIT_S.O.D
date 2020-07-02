import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-recovery',
  templateUrl: './recovery.component.html',
  styleUrls: ['./recovery.component.css']
})

export class RecoveryComponent implements OnInit {

  constructor(private formBuilder : FormBuilder) { }
  
  //Initializing form field, in this Cases only field 

  recoveryForm = this.formBuilder.group({
    _identificationUser: [''],
  });

  //Getting Data from fields

  get gIdentificationUser() {
    return this.recoveryForm.get('_identificationUser');
  }

  ngOnInit(): void {
  }

  //Method for submit the data 

  submit(){
    console.log(this.recoveryForm.value);
  }

}
