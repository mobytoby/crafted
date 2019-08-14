import { Component, Input } from '@angular/core';
import { Category } from '../models/category-interface';

@Component({
  selector: 'category-detail',
  template: `
    <div>
      <div>{{category?.name}}<div>
      <div>{{category?.imageUrl}}</div>
    </div>
  `
})
export class CategoryDetailComponent {
  @Input()
  category: Category;
}
