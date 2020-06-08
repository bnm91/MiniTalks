import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KatyComponentComponent } from './katy-component.component';

describe('KatyComponentComponent', () => {
  let component: KatyComponentComponent;
  let fixture: ComponentFixture<KatyComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KatyComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KatyComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
