import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AssetsTypeCreateComponent } from './assets-type-create.component';

describe('AssetsTypeCreateComponent', () => {
  let component: AssetsTypeCreateComponent;
  let fixture: ComponentFixture<AssetsTypeCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AssetsTypeCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AssetsTypeCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
