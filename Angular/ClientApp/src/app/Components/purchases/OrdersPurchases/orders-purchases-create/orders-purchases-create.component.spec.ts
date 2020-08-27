import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdersPurchasesCreateComponent } from './orders-purchases-create.component';

describe('OrdersPurchasesCreateComponent', () => {
  let component: OrdersPurchasesCreateComponent;
  let fixture: ComponentFixture<OrdersPurchasesCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrdersPurchasesCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdersPurchasesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
