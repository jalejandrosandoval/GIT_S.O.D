import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cv-devices-create-characteristics',
  templateUrl: './cv-devices-create-characteristics.component.html',
  styleUrls: ['./cv-devices-create-characteristics.component.css']
})
export class CvDevicesCreateCharacteristicsComponent implements OnInit {

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
