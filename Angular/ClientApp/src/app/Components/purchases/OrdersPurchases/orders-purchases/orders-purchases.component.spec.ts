import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdersPurchasesComponent } from './orders-purchases.component';

describe('OrdersPurchasesComponent', () => {
  let component: OrdersPurchasesComponent;
  let fixture: ComponentFixture<OrdersPurchasesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrdersPurchasesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdersPurchasesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
