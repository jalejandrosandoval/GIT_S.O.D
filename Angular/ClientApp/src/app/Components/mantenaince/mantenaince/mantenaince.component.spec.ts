import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MantenainceComponent } from './mantenaince.component';

describe('MantenainceComponent', () => {
  let component: MantenainceComponent;
  let fixture: ComponentFixture<MantenainceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MantenainceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MantenainceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
