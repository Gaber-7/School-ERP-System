import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Department } from '../../Models/Administration/department';

@Injectable({
  providedIn: 'root',
})
export class ServiceDepartment {

  apiUrl = 'https://localhost:7076/api/Department';

  constructor(private http: HttpClient) { }

  getDepartmentsAsync(): Observable<Department[]> {
    return this.http.get<Department[]>(this.apiUrl);

  }

  GetById(id: number): Observable<Department> {
    return this.http.get<Department>(`${this.apiUrl}/${id}`);
  }

  Add(department: Department): Observable<any> {
    return this.http.post<any>(this.apiUrl, department);
  }

  Edit(department: Department): Observable<any> {
    return this.http.put<any>(this.apiUrl, department);
  }

  Delete(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/${id}`);
  }
}