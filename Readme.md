# Sistema de Controle de Estoque e Vendas

Este � um sistema simples de controle de estoque e vendas com dois n�veis de acesso: Administrador e Cliente.

## Requisitos

- Visual Studio (para o backend em .NET Framework)
- Node.js e npm (para o frontend em Angular)
- Banco de dados (por exemplo, SQL Server, SQLite) configurado conforme necess�rio

## Configura��o do Backend (.NET Framework)

1. Abra o projeto no Visual Studio.
2. Configure a conex�o com o banco de dados no arquivo `Web.config`.
3. Execute o projeto.

O backend estar� dispon�vel em `http://localhost:5000`.

## Configura��o do Frontend (Angular)

1. Abra o terminal na pasta do projeto Angular.
2. Execute `npm install` para instalar as depend�ncias.
3. Execute `ng serve` para iniciar o servidor de desenvolvimento.

O frontend estar� dispon�vel em `http://localhost:4200`.

## Uso

### Cadastro de Produtos

1. Acesse `http://localhost:4200/cadastrar-produto`.
2. Preencha o formul�rio e clique em "Cadastrar".

### Realizar Venda

1. Acesse `http://localhost:4200/realizar-venda`.
2. Selecione os produtos e finalize a venda.

## Contribui��es

Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues e pull requests.

## Licen�a

Este projeto est� sob a licen�a [MIT](LICENSE).