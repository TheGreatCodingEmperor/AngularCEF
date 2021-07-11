import { TestBed } from '@angular/core/testing';

import { CefCustomObjectService } from './cef-custom-object.service';

describe('CefCustomObjectService', () => {
  let service: CefCustomObjectService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CefCustomObjectService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
