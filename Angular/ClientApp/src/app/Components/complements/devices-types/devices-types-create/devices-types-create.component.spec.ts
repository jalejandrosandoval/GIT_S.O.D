import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevicesTypesCreateComponent } from './devices-types-create.component';

describe('DevicesTypesCreateComponent', () => {
  let component: DevicesTypesCreateComponent;
  let fixture: ComponentFixture<DevicesTypesCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevicesTypesCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesTypesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
