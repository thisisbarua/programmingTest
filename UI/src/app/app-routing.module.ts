import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RandomNumberGenerateModuleComponent } from './random-number-generate-module/random-number-generate-module.component';
import { ReportGenerateModuleComponent } from './report-generate-module/report-generate-module.component';



const routes: Routes = [

  { path: '', component:  RandomNumberGenerateModuleComponent},
  { path: 'reportPage', component:  ReportGenerateModuleComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
