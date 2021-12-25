import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule }   from '@angular/forms';
import { CommonModule, DatePipe } from '@angular/common';
import { ReportGenerateModuleComponent } from './report-generate-module/report-generate-module.component';
import { RandomNumberGenerateModuleComponent } from './random-number-generate-module/random-number-generate-module.component';
//import { ToastrModule } from 'ngx-toastr';


@NgModule({
  declarations: [
    AppComponent,
    RandomNumberGenerateModuleComponent,
    ReportGenerateModuleComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CommonModule,
    //ToastrModule.forRoot(),
    FormsModule
    //BsDatepickerModule.forRoot(),
    //NgxPaginationModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
