import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cotizaciones',
  templateUrl: './cotizaciones.component.html',
  styleUrls: ['./cotizaciones.component.css']
})
export class CotizacionesComponent implements OnInit {
  public quotes: Quote[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    console.log(baseUrl);
    http.get<Quote[]>(baseUrl + 'api/quotes').subscribe(result => {
      this.quotes = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}
