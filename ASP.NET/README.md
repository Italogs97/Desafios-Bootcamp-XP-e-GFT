# Minimal API - ASP.NET

Este projeto apresenta uma API RESTful construída com ASP.NET usando Minimal APIs, focando em simplicidade, performance e fácil manutenção.

## Sobre o Projeto

A API permite operações CRUD (Create, Read, Update, Delete) sobre uma entidade de exemplo. Os endpoints são definidos de forma direta, aproveitando os recursos modernos do .NET.

## Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Navegue até a pasta do projeto:
   ```sh
   cd ASP.NETMinimalsAPIs/Api
   ```
3. Execute a aplicação:
   ```sh
   dotnet run
   ```
4. Acesse a API em `http://localhost:5000` (ou porta configurada).

## Endpoints Disponíveis

| Método  | Rota           | Descrição                  |
|---------|----------------|----------------------------|
| GET     | `/items`       | Lista todos os itens       |
| GET     | `/items/{id}`  | Busca item pelo ID         |
| POST    | `/items`       | Cria um novo item          |
| PUT     | `/items/{id}`  | Atualiza um item existente |
| DELETE  | `/items/{id}`  | Remove um item             |

### Exemplos de Uso

- Listar itens:
  ```sh
  curl http://localhost:5000/items
  ```
- Criar item:
  ```sh
  curl -X POST http://localhost:5000/items -H "Content-Type: application/json" -d '{"nome":"Item Exemplo"}'
  ```

## Testes

Você pode testar os endpoints usando [Postman](https://www.postman.com/), [Insomnia](https://insomnia.rest/) ou `curl`.

## Licença

Este projeto está sob a licença