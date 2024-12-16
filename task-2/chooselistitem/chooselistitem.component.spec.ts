import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChooselistitemComponent } from './chooselistitem.component';

describe('ChooselistitemComponent', () => {
  let component: ChooselistitemComponent;
  let fixture: ComponentFixture<ChooselistitemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ChooselistitemComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ChooselistitemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
