import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CategoryModule } from './categories/category-module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    CategoryModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
