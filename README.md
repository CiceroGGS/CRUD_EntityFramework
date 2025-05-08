# Web API CRUD de Funcionários

## 📌 Visão Geral
API RESTful para gestão de funcionários com operações CRUD completas desenvolvida em ASP.NET Core.

## 🛠️ Tecnologias
- ASP.NET Core 6
- Entity Framework Core 6
- SQL Server 2019+
- Swagger/OpenAPI

## ⚙️ Pré-requisitos
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou VS Code

## 🚀 Instalação

### 1. Configuração do Banco de Dados
Edite o arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=FuncionariosDB;User ID=sa;Password=your_password;TrustServerCertificate=True"
  }
}
```

### 2. Aplicar Migrações
Execute no terminal:

```bash
dotnet ef database update
```

### 3. Iniciar a Aplicação
```bash
dotnet run
```

## 🔗 Endpoints

### 👥 Funcionários

#### Listar Todos (GET)
`GET /api/funcionarios`

**Exemplo de Resposta:**
```json
{
  "success": true,
  "data": [
    {
      "id": 1,
      "nome": "João",
      "sobrenome": "Silva",
      "departamento": "TI",
      "ativo": true,
      "dataCriacao": "2023-01-01T00:00:00"
    }
  ]
}
```

#### Criar (POST)
`POST /api/funcionarios`

**Exemplo de Request:**
```json
{
  "nome": "Maria",
  "sobrenome": "Oliveira",
  "departamento": "RH",
  "turno": "Manhã"
}
```

#### Atualizar (PUT)
`PUT /api/funcionarios/{id}`

**Exemplo de Request:**
```json
{
  "nome": "João Atualizado",
  "departamento": "Marketing"
}
```

#### Deletar (DELETE)
`DELETE /api/funcionarios/{id}`

## 🧪 Testes
Importe no Postman:

```bash
curl -o FuncionariosAPI.postman_collection.json https://exemplo.com/collection.json
```

## 🤝 Como Contribuir
1. Faça um fork do projeto
2. Crie sua branch: `git checkout -b feature/nova-feature`
3. Commit suas mudanças: `git commit -m 'Adiciona recurso X'`
4. Push para o repositório: `git push origin feature/nova-feature`
5. Abra um Pull Request


> 📧 **Contato**: cicerog.silvestre@gmail.com
