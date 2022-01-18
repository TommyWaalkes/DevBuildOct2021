import { TestBed } from '@angular/core/testing';

import { TempConverterService } from './temp-converter.service';

describe('TempConverterService', () => {
  let service: TempConverterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TempConverterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
