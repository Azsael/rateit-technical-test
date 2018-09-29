import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { debounceTime } from 'rxjs/operators';
import { Company, CompanyService } from '../../../company/company.service';
import { NPSTrendFilter, NPSTrendPeriod } from '../../nps-trends.service';

@Component({
  selector: 'app-nps-trends-filters',
  templateUrl: './nps-trends-filters.component.html',
  styleUrls: ['./nps-trends-filters.component.scss']
})
export class NpsTrendsFiltersComponent implements OnInit {
  @Output() change = new EventEmitter<NPSTrendFilter>();
  public NPSTrendPeriod = NPSTrendPeriod;
  public trendPeriods = [NPSTrendPeriod.Daily, NPSTrendPeriod.Weekly, NPSTrendPeriod.Monthly];
  public companies: Company[];
  public form: FormGroup;

  constructor(private _fb: FormBuilder, private _cs: CompanyService) { }

  async ngOnInit() {
    this.form = this._fb.group({
      from: [],
      to: [],
      companyIds: [],
      trendPeriod: [NPSTrendPeriod.Monthly]
    });
    this.companies = await this._cs.getCompanies().toPromise();

    this.form.valueChanges
      .pipe(debounceTime(300))
      .subscribe(x => this.change.emit(x));
  }
}
