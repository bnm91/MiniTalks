import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BradComponentComponent } from './brad-component.component';

describe('BradComponentComponent', () => {
  let component: BradComponentComponent;
  let fixture: ComponentFixture<BradComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BradComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BradComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
