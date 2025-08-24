# Instruções para Execução do Projeto

## Pré-requisitos
- .NET 6.0 SDK instalado
- Git para clonar o repositório

## Passos para Execução

### 1. Clonar o Repositório
```bash
git clone https://github.com/digitalinnovationone/trilha-net-api-desafio.git
cd trilha-net-api-desafio
```

### 2. Restaurar Dependências
```bash
dotnet restore
```

### 3. Instalar Entity Framework Tools (se necessário)
```bash
dotnet tool install --global dotnet-ef --version 6.0.5
```

### 4. Aplicar Migrations
```bash
dotnet ef database update
```

### 5. Executar a Aplicação
```bash
dotnet run
```

A aplicação estará disponível em:
- **HTTP**: http://localhost:5000
- **HTTPS**: https://localhost:5001
- **Swagger**: http://localhost:5000/swagger

## Testando a API

### Via Swagger UI
1. Acesse http://localhost:5000/swagger
2. Teste os endpoints diretamente pela interface

### Via cURL
```bash
# Criar uma tarefa
curl -X POST "http://localhost:5000/Tarefa" \
  -H "Content-Type: application/json" \
  -d '{
    "titulo": "Minha Tarefa",
    "descricao": "Descrição da tarefa",
    "data": "2025-08-23T15:00:00.000Z",
    "status": "Pendente"
  }'

# Listar todas as tarefas
curl -X GET "http://localhost:5000/Tarefa/ObterTodos"

# Obter tarefa por ID
curl -X GET "http://localhost:5000/Tarefa/1"
```

## Estrutura do Banco de Dados
O projeto usa SQLite por padrão. O arquivo do banco será criado como `TarefasDB.db` na raiz do projeto.

### Schema da Tabela Tarefas
- **Id**: INTEGER (Primary Key, Auto Increment)
- **Titulo**: TEXT
- **Descricao**: TEXT  
- **Data**: TEXT (DateTime)
- **Status**: INTEGER (Enum: 0=Pendente, 1=Finalizado)

## Configurações
As configurações estão nos arquivos:
- `appsettings.json`: Configurações gerais
- `appsettings.Development.json`: Configurações de desenvolvimento

Para usar SQL Server em produção, altere a string de conexão e o provider no `Program.cs`.

