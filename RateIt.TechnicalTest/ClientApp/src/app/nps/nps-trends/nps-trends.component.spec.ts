import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NpsTrendsComponent } from './nps-trends.component';

describe('NpsTrendsComponent', () => {
  let component: NpsTrendsComponent;
  let fixture: ComponentFixture<NpsTrendsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NpsTrendsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NpsTrendsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
