import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarProdutoComponent } from './cadastrar-produto/cadastrar-produto.component';
import { RealizarVendaComponent } from './realizar-venda/realizar-venda.component';

@NgModule({
  declarations: [
    AppComponent,
    CadastrarProdutoComponent,
    RealizarVendaComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}