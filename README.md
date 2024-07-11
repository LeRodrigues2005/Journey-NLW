# Journey

Este é um projeto que gerencia viagens e atividades relacionadas através de uma API desenvolvida em C# com ASP.NET Core.

## Estrutura do Projeto

- **Journey.Api**: Contém os controladores da API e as configurações relacionadas.
- **Journey.Application**: Camada de aplicação que contém os casos de uso da aplicação.
- **Journey.Communication**: Definições de solicitações e respostas para comunicação via API.
- **Journey.Exception**: Lida com exceções personalizadas da aplicação.
- **Journey.Infrastructure**: Camada de infraestrutura, responsável pela implementação de persistência e integrações externas.

## Trips Controller

### Funcionalidades

O controlador `TripsController` gerencia operações relacionadas a viagens e atividades, sendo a parte fundamental do projeto. Aqui está um resumo das funcionalidades disponíveis:

### 1. Registrar uma Viagem

Endpoint para criar uma nova viagem.

### 2. Listar Todas as Viagens

Endpoint para listar todas as viagens cadastradas.

### 3. Obter Detalhes de uma Viagem

Endpoint para obter os detalhes de uma viagem específica.

### 4. Excluir uma Viagem

Endpoint para excluir uma viagem existente.

### 5. Registrar uma Atividade para uma Viagem

Endpoint para adicionar uma nova atividade a uma viagem específica.

### 6. Marcar uma Atividade como Completa

Endpoint para marcar uma atividade específica como completa.

### 7. Excluir uma Atividade

Endpoint para excluir uma atividade específica de uma viagem.

## Tecnologias Utilizadas

- ASP.NET Core MVC
- C#
- <a href="https://swagger.io">Swagger</a> para documentação da API

## Visão geral da API

<p align="center">
<img src="https://github.com/LeRodrigues2005/Journey-NLW/assets/97632543/9c6b0027-36ab-4ed1-97a0-fdde19283be8" alt="" width="900">
</p>

## Instalação e Uso

1. **Pré-requisitos:**
   - <a href="https://code.visualstudio.com">Visual Studio Code</a> ou <a href="https://visualstudio.microsoft.com/pt-br/">Visual Studio</a>
   - <a href="https://dotnet.microsoft.com/pt-br/download">.NET SDK</a>
   - <a href="https://sqlitebrowser.org/dl/">DB Browser for SQLite</a> (Pode-se utilizar outro banco de dados mas, para evitar conflitos na execução do código, recomendo este, que foi o que utilizei.)

2. **Clonar o Repositório:**

   ```
   git clone https://github.com/LeRodrigues2005/Journey-NLW.git
   cd Journey-NLW
   ```

3. **Configuração do Ambiente:**

   - Verifique e configure as conexões com bancos de dados ou serviços externos, conforme necessário.
     - Mude o caminho para o banco de dados no arquivo `Journey\src\Journey.Infrastructure\JourneyDbContext.cs` conforme estiver localizado em seu sistema. 

4. **Executar o Projeto:**

   - Abra o projeto no Visual Studio ou Visual Studio Code.
   - Compile e execute o projeto.

5. **Documentação da API:**

   - Após iniciar o projeto, acesse a documentação da API Swagger:
     - URL padrão: `https://localhost:{porta}/swagger`
   - No Visual Studio, pressionando `F5` no teclado, o Swagger irá iniciar no navegador na porta correspondente. 

### Informações Adicionais
Sinta-se à vontade para explorar e contribuir com este projeto. Seu feedback e sugestões são altamente apreciados.

### Follow me

<table>
  <tr>
    <td><img loading="lazy" src="https://github.com/LeRodrigues2005/Randomik/assets/97632543/2596913e-d7ec-4164-83b8-3d7bd357242d" width="40" height="40"/></td>
    <td style="vertical-align: middle;"> <a href="https://www.linkedin.com/in/letícia-rodrigues-a75134254/">Letícia Rodrigues on LinkedIn</a> </td>
  </tr>
</table>

<table>
  <tr>
    <td><img loading="lazy" src="https://github.com/LeRodrigues2005/Randomik/assets/97632543/3615a9d2-87a2-4e68-bf74-ad8c652c3f69" width="40" height="40"/></td>
    <td style="vertical-align: middle;"> <a href="https://www.instagram.com/leticia_rodrigues2005/">Letícia Rodrigues on Instagram</a> </td>
  </tr>
</table>

