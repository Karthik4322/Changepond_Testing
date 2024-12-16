import { Component } from '@angular/core';

@Component({
  selector: 'app-toogleimage',
  standalone: true,
  imports: [],
  templateUrl: './toogleimage.component.html',
  styleUrl: './toogleimage.component.css'
})

  export class ToogleImageComponent {
    
    images = [
      { src: 'assets/image1.jpg', name: 'Image 1' },
      { src: 'assets/image2.jpg', name: 'Image 2' }
    ];
    currentIndex = 0;

    get currentImage() {
      return this.images[this.currentIndex];
    }

    switchImage() {
      this.currentIndex = (this.currentIndex + 1) % this.images.length;
    }
  }

