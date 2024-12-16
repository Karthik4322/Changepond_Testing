import { Component } from '@angular/core';
@Component({
  selector: 'app-changeimage',
  templateUrl: './changeimage.component.html',
  styleUrls: ['./changeimage.component.css']
})
export class ChangeimageComponent  {
  images = [
    { src: 'assets/image1.jpg', name: 'Image 1' },
    { src: 'assets/image2.jpg', name: 'Image 2' },
    { src: 'assets/image3.jpg', name: 'Image 3' },
    { src: 'assets/image4.jpg', name: 'Image 4' }
  ];
  currentIndex = 0;

  get currentImage() {
    return this.images[this.currentIndex];
  }

  switchImage(index: number) {
    this.currentIndex = index;
  }
}


