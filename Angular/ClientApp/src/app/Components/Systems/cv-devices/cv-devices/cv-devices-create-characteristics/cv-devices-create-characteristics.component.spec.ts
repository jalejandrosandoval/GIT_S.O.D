import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CvDevicesCreateCharacteristicsComponent } from './cv-devices-create-characteristics.component';

describe('CvDevicesCreateCharacteristicsComponent', () => {
  let component: CvDevicesCreateCharacteristicsComponent;
  let fixture: ComponentFixture<CvDevicesCreateCharacteristicsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CvDevicesCreateCharacteristicsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CvDevicesCreateCharacteristicsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
