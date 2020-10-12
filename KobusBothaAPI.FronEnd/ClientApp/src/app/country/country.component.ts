import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-country',
    templateUrl: './country.component.html'
})
export class CountryComponent {
    public countries: Country[];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<Country[]>(baseUrl + 'api/country').subscribe(result => {
            this.countries = result;
        }, error => console.error(error));
    }
}

interface Country {
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
