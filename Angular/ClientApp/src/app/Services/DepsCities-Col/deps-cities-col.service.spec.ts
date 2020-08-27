import { TestBed } from '@angular/core/testing';

import { DepsCitiesColService } from './deps-cities-col.service';

describe('DepsCitiesColService', () => {
  let service: DepsCitiesColService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DepsCitiesColService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
