import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AutsisComponent } from './autsis.component';

describe('AutsisComponent', () => {
  let component: AutsisComponent;
  let fixture: ComponentFixture<AutsisComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AutsisComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AutsisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
