import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../category-service';
import { Category } from '../models/category-interface';

@Component({
  selector: 'category-manage',
  template: `
    <category-list [categories]="categories"></category-list>
  `
})
export class CategoryManageComponent implements OnInit {
  categories: Category[];

  constructor(private service: CategoryService) {  }

  ngOnInit() {
    this.service.getCategories()
      .subscribe(cats => {
        this.categories = cats;
      });
  }
}
