# Sistema de Controle de Estoque e Vendas

Este é um sistema simples de controle de estoque e vendas com dois níveis de acesso: Administrador e Cliente.

## Requisitos

- Visual Studio (para o backend em .NET Framework)
- Node.js e npm (para o frontend em Angular)
- Banco de dados (por exemplo, SQL Server, SQLite) configurado conforme necessário

## Configuração do Backend (.NET Framework)

1. Abra o projeto no Visual Studio.
2. Configure a conexão com o banco de dados no arquivo `Web.config`.
3. Execute o projeto.

O backend estará disponível em `http://localhost:5000`.

## Configuração do Frontend (Angular)

1. Abra o terminal na pasta do projeto Angular.
2. Execute `npm install` para instalar as dependências.
3. Execute `ng serve` para iniciar o servidor de desenvolvimento.

O frontend estará disponível em `http://localhost:4200`.

## Uso

### Cadastro de Produtos

1. Acesse `http://localhost:4200/cadastrar-produto`.
2. Preencha o formulário e clique em "Cadastrar".

### Realizar Venda

1. Acesse `http://localhost:4200/realizar-venda`.
2. Selecione os produtos e finalize a venda.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença

Este projeto está sob a licença [MIT](LICENSE).