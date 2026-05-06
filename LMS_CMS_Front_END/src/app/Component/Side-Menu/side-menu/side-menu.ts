import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-side-menu',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './side-menu.html',
  styleUrl: './side-menu.css',
})
export class SideMenu {

  isCollapsed = false;

  menuItems = [
    { label: 'DashBoard', icon: 'dashboard', active: true },
    { label: 'Administration', icon: 'Administration', active: false },
    { label: 'Management System', icon: 'Management System', active: false },
    { label: 'Registration', icon: 'Registration', active: false },
    { label: 'Projects', icon: 'folder', active: false },
    { label: 'Tasks', icon: 'check_circle', active: false },
    { label: 'Settings', icon: 'settings', active: false },
  ];

  toggleSidebar() {
    this.isCollapsed = !this.isCollapsed;
  }
}