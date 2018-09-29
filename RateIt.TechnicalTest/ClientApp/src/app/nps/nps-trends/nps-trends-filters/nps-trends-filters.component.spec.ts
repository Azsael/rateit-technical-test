import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NpsTrendsFiltersComponent } from './nps-trends-filters.component';

describe('NpsTrendsFiltersComponent', () => {
  let component: NpsTrendsFiltersComponent;
  let fixture: ComponentFixture<NpsTrendsFiltersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NpsTrendsFiltersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NpsTrendsFiltersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
