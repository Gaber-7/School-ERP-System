import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentSidebar } from './component-sidebar';

describe('ComponentSidebar', () => {
  let component: ComponentSidebar;
  let fixture: ComponentFixture<ComponentSidebar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponentSidebar],
    }).compileComponents();

    fixture = TestBed.createComponent(ComponentSidebar);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
