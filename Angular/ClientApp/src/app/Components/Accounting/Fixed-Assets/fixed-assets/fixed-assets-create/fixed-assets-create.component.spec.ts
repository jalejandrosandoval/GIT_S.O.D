import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FixedAssetsCreateComponent } from './fixed-assets-create.component';

describe('FixedAssetsCreateComponent', () => {
  let component: FixedAssetsCreateComponent;
  let fixture: ComponentFixture<FixedAssetsCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FixedAssetsCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FixedAssetsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
