# API de Tarefas 📝

Esta é uma API simples de tarefas desenvolvida em ASP.NET Core. Ela permite:

- ✅ Criar uma nova tarefa
- 📋 Listar todas as tarefas
- 🔍 Buscar tarefa por ID
- ✏️ Atualizar tarefa
- 🗑️ Deletar tarefa

## Endpoints

| Método | Endpoint       | Descrição             |
|--------|----------------|-----------------------|
| GET    | /tarefas       | Lista todas as tarefas |
| GET    | /tarefas/{id}  | Busca tarefa por ID    |
| POST   | /tarefas       | Cria nova tarefa       |
| PUT    | /tarefas/{id}  | Atualiza uma tarefa    |
| DELETE | /tarefas/{id}  | Remove uma tarefa      |

## Como executar

1. Clone este repositório
2. Execute o projeto no Visual Studio ou com `dotnet run`
3. Acesse o Swagger em `https://localhost:7117/swagger`

---

> Projeto criado para estudos de API REST com .NET 8 e C# 🚀
