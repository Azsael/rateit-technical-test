import { TestBed } from '@angular/core/testing';

import { NpsTrendsService } from './nps-trends.service';

describe('NpsTrendsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NpsTrendsService = TestBed.get(NpsTrendsService);
    expect(service).toBeTruthy();
  });
});
