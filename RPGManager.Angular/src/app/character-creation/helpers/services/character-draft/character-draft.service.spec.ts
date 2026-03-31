import { TestBed } from '@angular/core/testing';

import { CharacterDraftService } from './character-draft.service';

describe('CharacterDraftService', () => {
  let service: CharacterDraftService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CharacterDraftService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
