import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { JaredComponentComponent } from './jared-component/jared-component.component';
import { TrestinComponentComponent } from './trestin-component/trestin-component.component';
import { KatyComponentComponent } from './katy-component/katy-component.component';
import { MattComponentComponent } from './matt-component/matt-component.component';
import { BradComponentComponent } from './brad-component/brad-component.component';

@NgModule({
  declarations: [
    AppComponent,
    JaredComponentComponent,
    TrestinComponentComponent,
    KatyComponentComponent,
    MattComponentComponent,
    BradComponentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
