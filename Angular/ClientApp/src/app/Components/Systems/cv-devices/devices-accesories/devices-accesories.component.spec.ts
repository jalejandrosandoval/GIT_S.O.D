import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevicesAccesoriesComponent } from './devices-accesories.component';

describe('DevicesAccesoriesComponent', () => {
  let component: DevicesAccesoriesComponent;
  let fixture: ComponentFixture<DevicesAccesoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevicesAccesoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesAccesoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
