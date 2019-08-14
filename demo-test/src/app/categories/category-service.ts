import { Injectable } from '@angular/core';
import { Category } from './models/category-interface';
import { HttpClient } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class CategoryService {
  API_URL = 'http://localhost:32768/api/Categories';

  constructor(private http: HttpClient) { }

  getCategories(): Observable<Category[]> {
    this.http.get<Category[]>(this.API_URL)
      .pipe(
        map(x => console.log(x)),
      ).subscribe();
    const cat = { id: 1, name: 'test', imageUrl: '', categories: null} as Category;
    const cats = [cat];
    return of (cats);
  }

}
