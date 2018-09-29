import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NpsTrendsComponent } from './nps-trends/nps-trends.component';

const routes: Routes = [
  {
    path: '',
    component: NpsTrendsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class NpsRoutingModule { }
