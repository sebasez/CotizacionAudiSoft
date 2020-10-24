import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cotizacion',
  templateUrl: './cotizacion.component.html',
  styleUrls: ['./cotizacion.component.css']
})
export class CotizacionComponent implements OnInit {
  formCotizacion = new FormGroup({
    ruc: new FormControl(''),
    price: new FormControl(''),
    tax: new FormControl(''),
    discount: new FormControl(''),
    clientId: new FormControl(''),
    productId: new FormControl(''),
    sellerId: new FormControl(''),
  });
  public clients: Client[];
  public sellers: Seller[];
  public products: Product[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Client[]>(baseUrl + 'api/Clients').subscribe(result => {
      this.clients = result;
    }, error => console.error(error));
    http.get<Seller[]>(baseUrl + 'api/Sellers').subscribe(result => {
      this.sellers = result;
    }, error => console.error(error));
    http.get<Product[]>(baseUrl + 'api/Products').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
  ngOnInit() {
  }
  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.formCotizacion.value);
  }
}
