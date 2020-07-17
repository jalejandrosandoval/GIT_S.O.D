import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CVDevicesComponent } from './cv-devices.component';

describe('CVDevicesComponent', () => {
  let component: CVDevicesComponent;
  let fixture: ComponentFixture<CVDevicesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CVDevicesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CVDevicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
