import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LendingsEditComponent } from './lendings-edit.component';

describe('LendingsEditComponent', () => {
  let component: LendingsEditComponent;
  let fixture: ComponentFixture<LendingsEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LendingsEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LendingsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
