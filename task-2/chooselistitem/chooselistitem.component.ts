import { Component } from '@angular/core';
@Component({
  selector: 'app-chooselistitem',
  standalone: true,
  imports: [],
  templateUrl: './chooselistitem.component.html',
  styleUrl: './chooselistitem.component.css'
})
export class ChooselistitemComponent {


  cars: string[] = ['Toyota', 'Honda', 'Ford'];
    bikes: string[] = ['Yamaha', 'Suzuki', 'Kawasaki'];
    selectedList: string = 'car';
    selectedItem: string | null = null;

    showList(list: string) {
      this.selectedList = list;
      this.selectedItem = null; // Reset selected item when switching lists
    }

    selectItem(item: string) {
      this.selectedItem = item;
    }
    
  }


