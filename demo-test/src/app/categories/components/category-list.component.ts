import { Component, Input } from '@angular/core';
import { Category } from '../models/category-interface';

@Component({
  selector: 'category-list',
  template: `
    <category-detail
      *ngFor="let category of categories;"
      [category]="category" >
    </category-detail>
  `
})
export class CategoryListComponent {

  @Input()
  categories: Category[];
}
