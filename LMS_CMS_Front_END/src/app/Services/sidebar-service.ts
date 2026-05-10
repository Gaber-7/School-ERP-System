import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PageMenu } from '../Models/page-menu';

@Injectable({
  providedIn: 'root',
})
export class SidebarService {

  constructor(private http: HttpClient) { }

  apiUrl = 'https://localhost:7076/api/Page';

  getMenu(): Observable<PageMenu[]> {

    return this.http.get<PageMenu[]>(this.apiUrl);

  }
}