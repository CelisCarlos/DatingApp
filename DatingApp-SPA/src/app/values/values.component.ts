import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styles: []
})
export class ValuesComponent implements OnInit {
  message = 'Values Component';
  objectStoredfromAPI: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }
  /* GET Request Without Parameters */
  getValues() {
    this.http.get('http://localhost:5000/api/values').subscribe(objectfromAPI => {
      this.objectStoredfromAPI = objectfromAPI;
    }, error => {
      console.log(error);
    });
  }
}

