# Teste Clarify CSharp - Live Coding Test
## Objetivo
O objetivo deste teste é implementar uma funcionalidade de API para gerenciar pedidos de clientes, utilizando **C# .NET Core** com **PostgreSQL** e seguindo a arquitetura **Clean Architecture**. Você deverá implementar a criação de pedidos, validação dos dados, e persistência no banco de dados, utilizando as seguintes tecnologias e padrões:

- **Entity Framework Core**
- **FluentValidation**
- **MediatR**
- **AutoMapper**
- **Clean Architecture**

## Requisitos
### Funcionalidade Principal
Você deve implementar a funcionalidade de **cadastro de pedidos** de clientes na API. Para isso, o candidato deverá:

1. **Criar Pedido**:
   - Implementar um endpoint que permita criar um novo pedido para um cliente existente.
   - O pedido deve conter ao menos:
     - `Id do cliente`
     - `Itens do pedido`
     - `Data do pedido`
     - `Total do pedido`

2. **Validação**:
   - Implementar as regras de validação usando **FluentValidation**, garantindo que os campos obrigatórios estejam presentes e tenham valores válidos.

3. **Persistência**:
   - Usar **Entity Framework Core** para persistir os dados no banco de dados PostgreSQL.

4. **Mapeamento**:
   - Usar **AutoMapper** para mapear os DTOs para as entidades de domínio e vice-versa.

5. **Arquitetura**:
   - Estruturar o código seguindo os princípios de **Clean Architecture**, com camadas bem definidas (Apresentação, Aplicação, Domínio, Infraestrutura).
   - Usar o padrão **Mediator** com **MediatR** para lidar com o fluxo entre as camadas.

## Setup
Para ajudar no seu desenvolvimento, já fornecemos um pré-setup com a estrutura do projeto. Siga as instruções abaixo para configurar o ambiente.

### Pré-requisitos
- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)

### Instruções de Configuração
1. **Clone o Repositório**

   Clone o repositório desse projeto:

2. **Suba o container PostgreSQL**

   O projeto já está configurado para utilizar um banco de dados PostgreSQL em um container Docker. Execute o seguinte comando para subir o banco de dados:

```bash
docker run --name pgtestecfy -e POSTGRES_USER=admin -e POSTGRES_PASSWORD=admin -e POSTGRES_DB=teste_cfy -p 5432:5432 -d postgres:latest
```
Isso iniciará o container PostgreSQL com o banco de dados necessário já configurado.

3. **Configuração do Banco de Dados**

   O banco de dados já está configurado e os dados de conexão estão no arquivo `appsettings.Development.json` da API.

   - **Usuário do banco**: `admin`
   - **Senha do banco**: `admin`
   - **Nome do banco**: `teste_cfy`

4. **Executar o Projeto**

Após subir o banco de dados, execute a aplicação através do Visual Studio (preferencialmente o VS 2022):

A API estará disponível no endereço: `http://localhost:5000`.

### Estrutura do Projeto
- **API**: A camada de apresentação com os controladores.
- **Aplicacao**: A camada de aplicação contendo os comandos, handlers e validações.
- **Dominio**: Contém as entidades e interfaces de repositórios.
- **Infraestrutura**: Contém a implementação dos repositórios, o DbContext e as configurações do banco de dados.

### O que já foi configurado:
1. **Camadas e Estrutura do Projeto**: A estrutura base do projeto já está criada e as camadas estão organizadas.
2. **PostgreSQL (Docker)**: Um container PostgreSQL foi configurado e está pronto para uso com o banco de dados `teste_cfy` já criado.
3. **AutoMapper**: A configuração base do AutoMapper foi iniciada (mas precisa ser completada).
4. **MediatR**: O MediatR está configurado e pronto para ser utilizado.
5. **Entity Framework Core**: O DbContext (`PostgresDbContext`) está configurado.

### Tarefas que Você Deve Completar
1. **Implemente o Cadastro de Pedidos**:
   - Criar a estrutura de dados sql e complementar o arquivo **SQL/init.sql**.
   - Mapear as tabelas criadas para entidades e finalizar a configuração de Type Configuration na cama de infraestrutura.
   - Adicione a lógica para criar um pedido na API.
   - Valide os dados utilizando FluentValidation.
   - Mapeie o DTO para a entidade de domínio utilizando AutoMapper.
   - Persista os dados no banco de dados utilizando Entity Framework Core.

2. **Estruture o Código**:
   - Utilize o MediatR para gerenciar o fluxo de criação de pedidos.
   - Siga os princípios da Clean Architecture, garantindo que a lógica esteja nas camadas corretas.

3. **Opcional**: Se tiver tempo, implemente um endpoint para listar os pedidos de um cliente.

### Informações Adicionais

- **Banco de Dados**: Um banco de dados PostgreSQL está rodando em um container Docker. Você deve criar suas tabelas no script **SQL/init.sql** e criar as tabelas no banco de dados através de sua IDE preferida.
- **Padrões**: Use o Mediator para os fluxos entre camadas e organize o código de acordo com Clean Architecture.

### Dicas
- **Use MediatR**: Todos os fluxos entre camadas devem ser gerenciados pelo padrão Mediator.
- **Pergunte**: Se tiver alguma dúvida sobre o que fazer, sinta-se à vontade para perguntar durante o teste.

Boa sorte!
