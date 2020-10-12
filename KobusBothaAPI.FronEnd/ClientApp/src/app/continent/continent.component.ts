import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-continent',
  templateUrl: './continent.component.html'
})
export class ContinentComponent {
  public continents: Continent[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Continent[]>(baseUrl + 'api/continent').subscribe(result => {
        this.continents = result;
    }, error => console.error(error));
  }
}

interface Continent {
    name: string;
    cases: Cases;
    deaths: Basic;
    tests: Basic;
}

interface Cases {
    totalNew: number;
    totalActive: number;
    percentageTotal: number;
    percentageActive: number;
}

interface Basic {
    total: number;
    percentage: number;
}
