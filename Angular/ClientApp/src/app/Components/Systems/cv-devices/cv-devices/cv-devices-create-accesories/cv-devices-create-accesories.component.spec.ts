import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CvDevicesCreateAccesoriesComponent } from './cv-devices-create-accesories.component';

describe('CvDevicesCreateAccesoriesComponent', () => {
  let component: CvDevicesCreateAccesoriesComponent;
  let fixture: ComponentFixture<CvDevicesCreateAccesoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CvDevicesCreateAccesoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CvDevicesCreateAccesoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
