import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProvidersTypeCreateComponent } from './providers-type-create.component';

describe('ProvidersTypeCreateComponent', () => {
  let component: ProvidersTypeCreateComponent;
  let fixture: ComponentFixture<ProvidersTypeCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProvidersTypeCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProvidersTypeCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
