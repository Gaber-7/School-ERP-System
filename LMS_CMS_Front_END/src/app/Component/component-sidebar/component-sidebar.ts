import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { PageMenu } from '../../Models/page-menu';
import { SidebarService } from '../../Services/sidebar-service';

@Component({
  selector: 'app-component-sidebar',
  standalone: true,
  imports: [CommonModule, RouterModule , ],
  templateUrl: './component-sidebar.html',
  styleUrl: './component-sidebar.css',
})
export class ComponentSidebar implements OnInit {

  isCollapsed: boolean = false;
  menuItems: PageMenu[] = [];

  constructor(private sidebarService: SidebarService) { }

  ngOnInit(): void {
    this.loadMenu();
  }

  loadMenu(): void {

    this.sidebarService.getMenu().subscribe({

      next: (response) => {

        // مهم جدًا: clone لتجنب reference issues
        this.menuItems = response ?? [];

      },

      error: (error) => {
        console.log(error);
        this.menuItems = [];
      }

    });

  }

  toggleSidebar(): void {
    this.isCollapsed = !this.isCollapsed;
  }

  toggleMenu(item: PageMenu): void {
    item.isExpanded = !item.isExpanded;
  }
}