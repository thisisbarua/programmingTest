import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RandomNumberGenerateModuleComponent } from './random-number-generate-module.component';

describe('RandomNumberGenerateModuleComponent', () => {
  let component: RandomNumberGenerateModuleComponent;
  let fixture: ComponentFixture<RandomNumberGenerateModuleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RandomNumberGenerateModuleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RandomNumberGenerateModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
