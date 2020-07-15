import { TestBed } from '@angular/core/testing';

import { AssetsTypesService } from './assets-types.service';

describe('AssetsTypesService', () => {
  let service: AssetsTypesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AssetsTypesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
