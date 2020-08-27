import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { THumanComponent } from './thuman.component';

describe('THumanComponent', () => {
  let component: THumanComponent;
  let fixture: ComponentFixture<THumanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ THumanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(THumanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
