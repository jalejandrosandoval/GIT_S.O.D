import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FixedAssetsEditComponent } from './fixed-assets-edit.component';

describe('FixedAssetsEditComponent', () => {
  let component: FixedAssetsEditComponent;
  let fixture: ComponentFixture<FixedAssetsEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FixedAssetsEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FixedAssetsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
