import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RandomGeneratorService } from './services/random-generator.service';

@Component({
  selector: 'app-random-number-generate-module',
  templateUrl: './random-number-generate-module.component.html',
  styleUrls: ['./random-number-generate-module.component.css']
})
export class RandomNumberGenerateModuleComponent implements OnInit {

  sizeOfFile: number;

  constructor(private router: Router, private randomGeneratorService: RandomGeneratorService) { }

  ngOnInit(): void {
  }

  Start() {
    //console.log(this.sizeOfFile);
    this.randomGeneratorService.getReport(this.sizeOfFile).subscribe((response: any) => {
      if (response.success) {
        //this.sessionList = response.payload;
        console.log(response.payload.output);
      }
    })
  }

  navToReportPage() {
    this.router.navigateByUrl('reportPage');
  }

}
