# Análise do Projeto - Sistema Gerenciador de Tarefas

## Contexto
O projeto é um sistema gerenciador de tarefas desenvolvido em .NET com Web API e Entity Framework. O objetivo é implementar um CRUD completo para gerenciar tarefas.

## Estrutura do Projeto
- **Context/OrganizadorContext.cs**: Contexto do Entity Framework
- **Controllers/TarefaController.cs**: Controller da API com endpoints
- **Models/EnumStatusTarefa.cs**: Enum para status das tarefas
- **Models/Tarefa.cs**: Modelo da entidade Tarefa
- **Program.cs**: Configuração da aplicação
- **TrilhaApiDesafio.csproj**: Arquivo de projeto

## Endpoints Esperados
| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

## Schema da Tarefa
```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```

## Próximos Passos
1. Analisar código existente
2. Identificar TODOs
3. Implementar métodos faltantes
4. Configurar banco de dados
5. Testar endpoints

