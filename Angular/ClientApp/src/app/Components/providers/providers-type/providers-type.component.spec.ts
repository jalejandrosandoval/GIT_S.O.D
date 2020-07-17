import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProvidersTypeComponent } from './providers-type.component';

describe('ProvidersTypeComponent', () => {
  let component: ProvidersTypeComponent;
  let fixture: ComponentFixture<ProvidersTypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProvidersTypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProvidersTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
