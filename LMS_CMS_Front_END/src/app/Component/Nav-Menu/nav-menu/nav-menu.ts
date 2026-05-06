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
    { label: 'Home', link: '#' },
    { label: 'Services', link: '#' },
    { label: 'About Us', link: '#' },
    { label: 'Contact Us', link: '#' },
  ];

  toggleMenu() {
    this.isMenuOpen = !this.isMenuOpen;
  }

  
}
