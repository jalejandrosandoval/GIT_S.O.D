import { TestBed } from '@angular/core/testing';

import { UsersTypeService } from './users-type.service';

describe('UsersTypeService', () => {
  let service: UsersTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UsersTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
