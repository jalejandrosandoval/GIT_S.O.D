import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeTypeCreateComponent } from './employee-type-create.component';

describe('EmployeeTypeCreateComponent', () => {
  let component: EmployeeTypeCreateComponent;
  let fixture: ComponentFixture<EmployeeTypeCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeeTypeCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeTypeCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
