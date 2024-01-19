import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarProdutoComponent } from './cadastrar-produto/cadastrar-produto.component';
import { RealizarVendaComponent } from './realizar-venda/realizar-venda.component';

const routes: Routes = [
  { path: 'cadastrar-produto', component: CadastrarProdutoComponent },
  { path: 'realizar-venda', component: RealizarVendaComponent },
  // Adicionar outras rotas conforme necessário
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}