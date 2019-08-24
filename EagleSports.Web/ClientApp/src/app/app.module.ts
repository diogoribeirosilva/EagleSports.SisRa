import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AtletaComponent } from './atleta/atleta.component';
import { EsporteComponent } from './esporte/esporte.component';
import { CategoriaComponent } from './categoria/categoria.component';
import { HistoricoVideosComponent } from './historicoVideos/historicoVideos.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AtletaComponent,
    EsporteComponent,
    CategoriaComponent,
    HistoricoVideosComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'atleta', component: AtletaComponent },
      { path: 'esporte', component: EsporteComponent },
      { path: 'categoria', component: CategoriaComponent },
      { path: 'historicoVideos', component: HistoricoVideosComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
