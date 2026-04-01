import { TestBed } from '@angular/core/testing';

import { GameSystemApiService } from './game-system-api.service';

describe('GameSystemApiService', () => {
  let service: GameSystemApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GameSystemApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
