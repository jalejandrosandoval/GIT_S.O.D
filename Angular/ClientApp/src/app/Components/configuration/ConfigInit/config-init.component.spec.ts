import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfigInitComponent } from './config-init.component';

describe('ConfigInitComponent', () => {
  let component: ConfigInitComponent;
  let fixture: ComponentFixture<ConfigInitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConfigInitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConfigInitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
