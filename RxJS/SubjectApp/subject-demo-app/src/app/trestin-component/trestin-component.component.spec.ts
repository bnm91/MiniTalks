import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TrestinComponentComponent } from './trestin-component.component';

describe('TrestinComponentComponent', () => {
  let component: TrestinComponentComponent;
  let fixture: ComponentFixture<TrestinComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrestinComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrestinComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
