import { TestBed } from '@angular/core/testing';

import { ConfigInitialService } from './config-initial.service';

describe('ConfigInitialService', () => {
  let service: ConfigInitialService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConfigInitialService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
