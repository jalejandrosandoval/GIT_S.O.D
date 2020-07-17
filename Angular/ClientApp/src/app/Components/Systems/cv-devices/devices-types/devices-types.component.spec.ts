import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevicesTypesComponent } from './devices-types.component';

describe('DevicesTypesComponent', () => {
  let component: DevicesTypesComponent;
  let fixture: ComponentFixture<DevicesTypesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevicesTypesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesTypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
