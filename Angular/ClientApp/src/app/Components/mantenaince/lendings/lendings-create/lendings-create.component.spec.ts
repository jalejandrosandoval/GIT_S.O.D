import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LendingsCreateComponent } from './lendings-create.component';

describe('LendingsCreateComponent', () => {
  let component: LendingsCreateComponent;
  let fixture: ComponentFixture<LendingsCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LendingsCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LendingsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
