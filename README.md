# Sistema Aluguel de Carros

1. Cria pasta para o projeto
2. criar solução
3. cria projeto web
4. adicionar projeto web a solução
5. Instalar os pacotes
   1. MySql
   2. Entity Core
   3. Entity Tools
6. Criar Modelos
   1. Modelo
   2. Carro
   3. Marca
   4. Cliente
   5. Pedido
   6. Configuracao
7. Criar o contexto
8. Adiciona `ConnectionStrings` em `appsettings.json`
9. Refatoramos Program.cs
   1. Aqui é criado StartUp
   2. Aqui é referenciada a string de conexao
   3. adiciona configurações `(services.AddControllersWithViews();)`
10. Instalar o dotnet Entity Framework
11. Criar as Migrations
12. Executa as Migration com update database
13.  Instalar o pacote EF Design
14.  Instalar pacoteSql_Server
15.  Instalar o `dotnet tool install -g dotnet-aspnet-codegenerator`
16.  Executar o Scafold para cada modelo