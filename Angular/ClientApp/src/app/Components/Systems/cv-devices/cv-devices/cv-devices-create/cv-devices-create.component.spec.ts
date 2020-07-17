import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CvDevicesCreateComponent } from './cv-devices-create.component';

describe('CvDevicesCreateComponent', () => {
  let component: CvDevicesCreateComponent;
  let fixture: ComponentFixture<CvDevicesCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CvDevicesCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CvDevicesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
