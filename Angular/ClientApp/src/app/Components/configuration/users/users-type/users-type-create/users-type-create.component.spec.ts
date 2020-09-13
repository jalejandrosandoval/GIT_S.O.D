import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersTypeCreateComponent } from './users-type-create.component';

describe('UsersTypeCreateComponent', () => {
  let component: UsersTypeCreateComponent;
  let fixture: ComponentFixture<UsersTypeCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsersTypeCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersTypeCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
