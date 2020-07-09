import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersTypeEditComponent } from './users-type-edit.component';

describe('UsersTypeEditComponent', () => {
  let component: UsersTypeEditComponent;
  let fixture: ComponentFixture<UsersTypeEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsersTypeEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersTypeEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
