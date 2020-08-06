import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EquipmentsCreateComponent } from './equipments-create.component';

describe('EquipmentsCreateComponent', () => {
  let component: EquipmentsCreateComponent;
  let fixture: ComponentFixture<EquipmentsCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EquipmentsCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EquipmentsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
