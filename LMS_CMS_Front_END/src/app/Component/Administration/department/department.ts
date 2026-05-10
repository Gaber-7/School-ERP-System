
import { Component } from '@angular/core';
import { Department } from '../../../Models/Administration/department';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ServiceDepartment } from '../../../Services/Administration/service-department';

@Component({
  selector: 'app-department',
  imports: [FormsModule, CommonModule],
  templateUrl: './department.html',
  styleUrl: './department.css',
})
export class DepartmentComponent {

  TableData: Department[] = [];
  department: Department = new Department();

  isModalVisible: boolean = false;
  mode: string = '';
  isLoading = false;

  constructor(
    private departmentservice: ServiceDepartment,

  ) { }

  ngOnInit(): void {

    this.GetAllData();
    

  }

  // Get All Data from API and bind to table 
  GetAllData() {
    this.TableData = [];
    this.departmentservice.getDepartmentsAsync().subscribe((d) => {
      this.TableData = d;
    });
  }

  // Open Create Modal and Clear Form Data 
  Create() {
    this.mode = 'Create';
    this.department = new Department();  
    this.OpenModel();

  }

Edit(department: Department) {
    this.mode = 'Edit';
    this.departmentservice.GetById(department.id).subscribe((d) => {
      this.department = d;
      this.OpenModel();
    });
  }

  // Save Data to API
  Save() {
    this.isLoading = true;
    if (this.mode === 'Create') {
      this.departmentservice.Add(this.department).subscribe(() => {
        this.GetAllData();
        this.CloseModel();
        this.isLoading = false;
      });
    } else if (this.mode === 'Edit') {
      this.departmentservice.Edit(this.department).subscribe(() => {
        this.GetAllData();
        this.CloseModel();
        this.isLoading = false;
      });
    }
  }

Delete(id: number) {
    if (confirm('Are you sure you want to delete this department?')) {
      this.departmentservice.Delete(id).subscribe(() => {
        this.GetAllData();
      });
    }

  }

// Open Modal 
  OpenModel() {
    this.isModalVisible = true;
  }

  // Close Modal and Clear Form Data
  CloseModel() {
    this.isModalVisible = false;

  }
}