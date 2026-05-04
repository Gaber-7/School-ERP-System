import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  imports: [CommonModule],
  templateUrl: './nav-menu.html',
  styleUrl: './nav-menu.css',
})
export class NavMenu {


isMenuOpen = false;

  navItems = [
    { label: 'الرئيسية', link: '#' },
    { label: 'الخدمات', link: '#' },
    { label: 'عن الشركة', link: '#' },
    { label: 'اتصل بنا', link: '#' },
  ];

  toggleMenu() {
    this.isMenuOpen = !this.isMenuOpen;
  }

  
}
