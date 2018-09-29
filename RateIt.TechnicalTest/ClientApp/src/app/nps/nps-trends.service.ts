import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import * as querystring from 'querystring';

export class NPSRating {
  trendPeriod: NPSTrendPeriod;
  trendTime: Date;
  score?: number;
}

export class NPSTrendFilter {
  from?: Date;
  to?: Date;
  companyIds?: number[];
  trendPeriod?: NPSTrendPeriod;
}


export enum NPSTrendPeriod {
  Daily = 1,
  Weekly = 2,
  Monthly = 3
}

@Injectable({
  providedIn: 'root'
})
export class NpsTrendsService {

  constructor(@Inject('BASE_URL') private _baseUrl, private _http: HttpClient) { }

  public getNPSTrends(filter?: NPSTrendFilter): Observable<NPSRating[]> {
    const paramString = querystring.stringify({
      ...filter,
      to: filter.to && filter.to.toISOString(),
      from: filter.from && filter.from.toISOString()
    });

    const params = new HttpParams({ fromString: paramString });

    return this._http.get<NPSRating[]>(`${this._baseUrl}api/nps/trends`, { params: params });
  }
}
