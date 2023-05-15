import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrbcoreComponent } from './orbcore.component';

describe('OrbcoreComponent', () => {
  let component: OrbcoreComponent;
  let fixture: ComponentFixture<OrbcoreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrbcoreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrbcoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
