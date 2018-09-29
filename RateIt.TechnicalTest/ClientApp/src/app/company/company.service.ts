import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export class Company {
  companyId: number;
  name: string;
  timezone: string;
}

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(@Inject('BASE_URL') private _baseUrl, private _http: HttpClient) { }

  public getCompanies(): Observable<Company[]> {
    return this._http.get<Company[]>(`${this._baseUrl}api/companies`);
  }
}
