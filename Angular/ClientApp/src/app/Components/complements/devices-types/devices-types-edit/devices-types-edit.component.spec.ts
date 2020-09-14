import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevicesTypesEditComponent } from './devices-types-edit.component';

describe('DevicesTypesEditComponent', () => {
  let component: DevicesTypesEditComponent;
  let fixture: ComponentFixture<DevicesTypesEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevicesTypesEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevicesTypesEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
