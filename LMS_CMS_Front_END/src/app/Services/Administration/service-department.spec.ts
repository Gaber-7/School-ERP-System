import { TestBed } from '@angular/core/testing';

import { ServiceDepartment } from './service-department';

describe('ServiceDepartment', () => {
  let service: ServiceDepartment;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceDepartment);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
