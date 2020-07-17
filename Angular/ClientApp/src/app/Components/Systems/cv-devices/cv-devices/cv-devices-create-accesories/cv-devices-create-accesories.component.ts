import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cv-devices-create-accesories',
  templateUrl: './cv-devices-create-accesories.component.html',
  styleUrls: ['./cv-devices-create-accesories.component.css']
})
export class CvDevicesCreateAccesoriesComponent implements OnInit {

  options: string[];
  
  constructor() { }

  ngOnInit(): void {
    this.options = [
      'option 1',
      'option 2',
      'option 3',
   ];
  }

}
