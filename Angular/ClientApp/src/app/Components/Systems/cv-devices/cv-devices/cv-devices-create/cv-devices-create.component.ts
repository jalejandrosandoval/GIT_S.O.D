import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cv-devices-create',
  templateUrl: './cv-devices-create.component.html',
  styleUrls: ['./cv-devices-create.component.css']
})
export class CvDevicesCreateComponent implements OnInit {

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
