import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatDatepickerModule, MatFormFieldModule, MatInputModule, MatSelectModule } from '@angular/material';
import { ChartModule } from 'angular-highcharts';
import { CompanyModule } from './../company/company.module';
import { NpsRoutingModule } from './nps-routing.module';
import { NpsTrendsService } from './nps-trends.service';
import { NpsTrendsFiltersComponent } from './nps-trends/nps-trends-filters/nps-trends-filters.component';
import { NpsTrendsComponent } from './nps-trends/nps-trends.component';

@NgModule({
  imports: [
    CommonModule,
    ReactiveFormsModule,
    CompanyModule,
    ChartModule,
    NpsRoutingModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule
  ],
  declarations: [
    NpsTrendsComponent, 
     NpsTrendsFiltersComponent
  ],
  providers: [NpsTrendsService]
})
export class NpsModule { }
