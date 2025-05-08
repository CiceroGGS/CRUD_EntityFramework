# Web API CRUD de Funcionários

Este é um projeto de uma API RESTful desenvolvida com ASP.NET Core, utilizando Entity Framework para gerenciar os dados de funcionários em um banco de dados SQL Server. A API oferece funcionalidades CRUD (Criar, Ler, Atualizar, Deletar) para gerenciar informações de funcionários, como nome, sobrenome, departamento, turno e status (ativo/inativo).

## Funcionalidades

A API oferece as seguintes funcionalidades:

### Funcionários
- **Cadastrar Funcionário**: Criação de um novo registro de funcionário no banco de dados.
- **Listar Funcionários**: Visualização de todos os funcionários cadastrados.
- **Detalhar Funcionário**: Obter detalhes de um funcionário específico.
- **Atualizar Funcionário**: Atualizar as informações de um funcionário existente.
- **Inativar Funcionário**: Marcar um funcionário como inativo.
- **Excluir Funcionário**: Excluir um funcionário do banco de dados.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para criação da API.
- **Entity Framework Core**: ORM para interação com o banco de dados SQL Server.
- **SQL Server**: Banco de dados relacional para armazenar as informações dos funcionários.
- **Swagger**: Para documentação e testes da API.

## Pré-requisitos

Antes de rodar o projeto, certifique-se de ter o seguinte instalado:

- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- .NET SDK (versão 6 ou superior)

## Instalação

1. Clone este repositório para o seu computador:

   ```bash
   git clone https://github.com/CiceroGGS/CRUD_EntityFramework.git
Abra o projeto no Visual Studio ou Visual Studio Code.

Configure o banco de dados SQL Server. No arquivo appsettings.json, altere a string de conexão para o seu banco de dados local.

Exemplo de configuração no appsettings.json:

json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnections": "Server=localhost;Database=SeuBancoDeDados;User Id=sa;Password=suaSenha;"
}
Execute as migrações do Entity Framework para criar as tabelas necessárias no banco de dados:

bash
Copiar
Editar
dotnet ef database update
Execute o projeto.

bash
Copiar
Editar
dotnet run
O servidor estará rodando em http://localhost:5117 (ou https://localhost:7195 para HTTPS).

Endpoints da API
Funcionários
GET /api/funcionario: Listar todos os funcionários.

Resposta (JSON):

json
Copiar
Editar
[
  {
    "id": 1,
    "nome": "João",
    "sobrenome": "Silva",
    "departamento": "RH",
    "ativo": true,
    "turno": "Manhã",
    "dataDeCriacao": "2022-01-01T10:00:00",
    "dataDeAlteracao": "2022-02-01T15:00:00"
  }
]
GET /api/funcionario/{id}: Detalhar um funcionário específico.

Resposta (JSON):

json
Copiar
Editar
{
  "id": 1,
  "nome": "João",
  "sobrenome": "Silva",
  "departamento": "RH",
  "ativo": true,
  "turno": "Manhã",
  "dataDeCriacao": "2022-01-01T10:00:00",
  "dataDeAlteracao": "2022-02-01T15:00:00"
}
POST /api/funcionario: Cadastrar um novo funcionário.

Corpo da requisição (JSON):

json
Copiar
Editar
{
  "nome": "Maria",
  "sobrenome": "Costa",
  "departamento": "Financeiro",
  "turno": "Tarde",
  "ativo": true
}
PUT /api/funcionario: Atualizar as informações de um funcionário existente.

Corpo da requisição (JSON):

json
Copiar
Editar
{
  "id": 1,
  "nome": "João",
  "sobrenome": "Silva",
  "departamento": "RH",
  "turno": "Noite",
  "ativo": true
}
PUT /api/funcionario/InativaFuncionario/{id}: Inativar um funcionário.

Resposta (JSON):

json
Copiar
Editar
{
  "dados": [
    {
      "id": 1,
      "nome": "João",
      "sobrenome": "Silva",
      "departamento": "RH",
      "ativo": false,
      "turno": "Noite",
      "dataDeCriacao": "2022-01-01T10:00:00",
      "dataDeAlteracao": "2022-02-01T15:00:00"
    }
  ]
}
DELETE /api/funcionario/{id}: Excluir um funcionário.

Resposta (JSON):

json
Copiar
Editar
{
  "dados": [
    {
      "id": 2,
      "nome": "Maria",
      "sobrenome": "Costa",
      "departamento": "Financeiro",
      "ativo": true,
      "turno": "Tarde",
      "dataDeCriacao": "2022-01-01T10:00:00",
      "dataDeAlteracao": "2022-02-01T15:00:00"
    }
  ]
}
Como Contribuir
Faça um fork deste repositório.

Crie uma branch para a sua funcionalidade (ex: git checkout -b minha-nova-funcionalidade).

Faça as modificações necessárias.

Commit suas alterações (git commit -am 'Adiciona nova funcionalidade').

Faça o push para a branch (git push origin minha-nova-funcionalidade).

Abra um pull request.
