import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-recovery',
  templateUrl: './recovery.component.html',
  styleUrls: ['./recovery.component.css']
})
export class RecoveryComponent implements OnInit {

  constructor(private formBuilder : FormBuilder) { }
  
  recoveryForm = this.formBuilder.group({
    _identificationUser: [''],
  });

  ngOnInit(): void {
  }

  submit(){
    console.log(this.recoveryForm.value);
  }

}
