# Fretamento API

Fretamento API é uma aplicação desenvolvida para gerenciar solicitações de fretamento. Este projeto utiliza ASP.NET Core, Entity Framework Core e SQL Server para a camada de persistência de dados.

## Estrutura do Projeto

O projeto é estruturado da seguinte forma:

- **Controllers**: Contêm os endpoints da API.
- **Models**: Definem as entidades do sistema.
- **Data**: Configuração do contexto do banco de dados.
- **Migrations**: Gerenciamento das migrações do banco de dados.

## Requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/)
- SQL Server (ou outro banco compatível com Entity Framework Core)

## Configuração do Banco de Dados

1. Configure a string de conexão no arquivo `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "..."
     }
   }
   ```

2. Execute os comandos abaixo para aplicar as migrações e atualizar o banco de dados:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Comandos Importantes

- Adicionar migração:
  ```bash
  dotnet ef migrations add NomeDaMigracao
  ```

- Atualizar o banco de dados:
  ```bash
  dotnet ef database update
  ```

- Remover uma migração:
  ```bash
  dotnet ef migrations remove
  ```

## Contato

Autor: Rafael Siqueira  
Email: rafaelsiqueira.98bm@gmail.com

---

### Licença
Este projeto é licenciado sob os termos da [MIT License](https://opensource.org/licenses/MIT).

