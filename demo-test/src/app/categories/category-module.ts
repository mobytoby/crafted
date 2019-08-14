import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule } from '@angular/common/http';
import { CategoryDetailComponent } from './components/category-detail.component';
import { CategoryListComponent } from './components/category-list.component';
import { CategoryManageComponent } from './containers/category-manage.component';
import { CategoryService } from './category-service';


@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
  ],
  declarations: [
    CategoryManageComponent,
    CategoryDetailComponent,
    CategoryListComponent,
  ],
  exports: [
    CategoryManageComponent,
  ],
  providers: [
    CategoryService,
  ]
})
export class CategoryModule { }
