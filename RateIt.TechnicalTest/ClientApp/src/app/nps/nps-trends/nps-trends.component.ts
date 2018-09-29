import { NPSRating, NPSTrendFilter, NPSTrendPeriod } from './../nps-trends.service';
import { CompanyService, Company } from './../../company/company.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NpsTrendsService } from '../nps-trends.service';
import { debounceTime } from 'rxjs/operators';
import { Chart } from 'angular-highcharts';
import * as moment from 'moment';
import { DataPoint } from 'highcharts';

@Component({
  selector: 'app-nps-trends',
  templateUrl: './nps-trends.component.html',
  styleUrls: ['./nps-trends.component.scss']
})
export class NpsTrendsComponent implements OnInit {
  public trends: NPSRating[];
  public chart: Chart;

  constructor(private _npsts: NpsTrendsService) { }

  async ngOnInit() {
    this.chart = new Chart({
      chart: {
        type: 'line'
      },
      credits: {
        enabled: false
      },
      title: {
        text: 'Net Promoter Score'
      },
      xAxis: {
        type: 'datetime',
        title: {
          text: 'Time'
        }
      },
      yAxis: {
        title: {
          text: 'Score'
        },
        ceiling: 100,
        floor: -100
      }
    });
    this.loadTrends();
  }

  async loadTrends(filter?: NPSTrendFilter) {
    filter = filter || {};
    try {
      this.chart.removeSerie(0);

      this.trends = await this._npsts.getNPSTrends(filter).toPromise();

      const format = filter.trendPeriod === NPSTrendPeriod.Daily ?
        'D MMM YYYY' : filter.trendPeriod === NPSTrendPeriod.Weekly ? '[Week starting] D MMM YYYY' : 'MMM YYYY';

      const data = this.trends.map(trend => ({
        y: trend.score,
        x: new Date(trend.trendTime),
        name: moment(trend.trendTime).format(format)
      }) as any);

      this.chart.addSerie({ name: 'NPS', data: data });
    } catch (e) {
      console.log(e);
      // todo: handle error;
    }
  }
}
