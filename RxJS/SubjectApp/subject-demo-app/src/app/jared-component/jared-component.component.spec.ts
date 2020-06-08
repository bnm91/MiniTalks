import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JaredComponentComponent } from './jared-component.component';

describe('JaredComponentComponent', () => {
  let component: JaredComponentComponent;
  let fixture: ComponentFixture<JaredComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JaredComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JaredComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
