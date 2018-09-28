import { NpsModule } from './nps.module';

describe('NpsModule', () => {
  let npsModule: NpsModule;

  beforeEach(() => {
    npsModule = new NpsModule();
  });

  it('should create an instance', () => {
    expect(npsModule).toBeTruthy();
  });
});
