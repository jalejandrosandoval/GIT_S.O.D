import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevicesMantenainceComponent } from './devices-mantenaince.component';

describe('DevicesMantenainceComponent', () => {
  let component: DevicesMantenainceComponent;
  let fixture: ComponentFixture<DevicesMantenainceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevicesMantenainceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesMantenainceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
