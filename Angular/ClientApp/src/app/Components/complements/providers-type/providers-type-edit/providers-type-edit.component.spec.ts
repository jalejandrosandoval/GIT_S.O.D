import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProvidersTypeEditComponent } from './providers-type-edit.component';

describe('ProvidersTypeEditComponent', () => {
  let component: ProvidersTypeEditComponent;
  let fixture: ComponentFixture<ProvidersTypeEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProvidersTypeEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProvidersTypeEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
