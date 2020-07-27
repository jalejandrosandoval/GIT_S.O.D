import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MantenaincesComponent } from './mantenainces.component';

describe('MantenaincesComponent', () => {
  let component: MantenaincesComponent;
  let fixture: ComponentFixture<MantenaincesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MantenaincesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MantenaincesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
