import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportGenerateModuleComponent } from './report-generate-module.component';

describe('ReportGenerateModuleComponent', () => {
  let component: ReportGenerateModuleComponent;
  let fixture: ComponentFixture<ReportGenerateModuleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportGenerateModuleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportGenerateModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
