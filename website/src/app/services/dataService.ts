import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Person } from '../model/person';
import { environment } from '../../environments/environment';

@Injectable()
export class DataService {
  constructor(
    private httpClient: HttpClient
  ) { }

  getPeople(): Observable<Person[]> {
    return this.httpClient.get<Person[]>(`http://${environment.apiHost}:5001/api/person`);
  }

  addPerson(person: Person): Observable<any> {
    return this.httpClient.post(`http://${environment.apiHost}:5001/api/person`, person);
  }
}
