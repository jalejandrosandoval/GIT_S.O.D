import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdersproductionComponent } from './ordersproduction.component';

describe('OrdersproductionComponent', () => {
  let component: OrdersproductionComponent;
  let fixture: ComponentFixture<OrdersproductionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrdersproductionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdersproductionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
