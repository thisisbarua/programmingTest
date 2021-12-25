import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const headerOption = {
  headers: new HttpHeaders({ 
    'Access-Control-Allow-Origin':'*',
    'Content-Type': 'application/json' })
};

@Injectable({
  providedIn: 'root'
})
export class RandomGeneratorService {

  constructor(private httpcall: HttpClient) { }

  getReport(sizeOfFile: number) {
    return this.httpcall.get('https://localhost:44306/api/TestReport/getTestReport/' + sizeOfFile );
  }
}
