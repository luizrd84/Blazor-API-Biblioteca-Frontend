# Frontend Biblioteca

## Sobre o projeto

O **Frontend Biblioteca** é a interface web responsável por consumir os endpoints da **API Biblioteca**,
permitindo a visualização e interação com os dados da aplicação de gerenciamento de biblioteca.

O projeto foi desenvolvido utilizando **.NET e Blazor**, explorando o uso de **C# e Razor Components** para
construção de uma **SPA (Single Page Application)** integrada a um backend Node.js.

Durante o desenvolvimento foram explorados conceitos importantes do ecossistema **Blazor**, como:

- criação de **componentes Razor**
- utilização de **data binding**
- consumo de **APIs REST com HttpClient**
- gerenciamento de **estado de componentes**
- uso de **formulários com validação**
- renderização de dados em tabelas utilizando **QuickGrid**

O projeto tem como objetivo demonstrar a integração entre **frontend e backend**, utilizando **Blazor
como interface web** e uma **API REST como fonte de dados**, simulando um sistema simples de gerenciamento
de biblioteca.

---

# Tecnologias utilizadas

Este projeto foi desenvolvido utilizando as seguintes tecnologias:

- **.NET** – Plataforma de desenvolvimento
- **Blazor** – Framework para construção de interfaces web com C#
- **QuickGrid** – Componente para exibição de dados em tabelas
- **HttpClient** – Consumo de APIs REST

---

# Requisitos:

- .NET 8 SDK ou superior
- Node.js (para executar o backend)
- Docker (para o banco de dados PostgreSQL)

# Instalação do projeto

Siga os passos abaixo para executar o projeto localmente.

## Clonar o repositório

```bash
git clone https://github.com/luizrd84/Blazor-API-Biblioteca-Frontend.git

```

## Acessar a pasta do projeto

```bash
cd seu-repositorio
```

## Restaurar as dependências

O .NET utiliza o NuGet para gerenciamento de pacotes.
Para baixar as dependências do projeto, execute:

```bash
dotnet restore
```

## Configurando a API

O frontend depende da **API Biblioteca** para funcionar corretamente.

Certifique-se de que o **backend e o banco de dados estejam em execução** antes de iniciar o frontend.

Por padrão, o projeto espera que a API do Backend esteja disponível em:

```bash
http://localhost:3000
```

Caso seja necessário alterar a URL da API, ajuste a configuração do HttpClient no projeto.

## Executando o projeto

Para iniciar a aplicação, execute o comando:

```bash
dotnet run
```

Após iniciar, a aplicação estará disponível em:

```bash
http://localhost:7044
```
## Demonstração do Projeto

O projeto está disponível em: https://blazor-biblioteca-frontend.onrender.com/

O Frontend e o Backend foram publicados no Render.com, e o banco de dados está hospedado no Supabase.

- Observação sobre o backend:
  Por limitações da Render, o backend "dorme" quando não é acessado por algum tempo. Isso significa que, na primeira vez que você acessar a aplicação após algum período de inatividade (aproximadamente 15 minutos), o backend pode demorar alguns segundos para iniciar. Para facilitar, incluímos na página inicial um componente que verifica automaticamente quando o backend está ativo e pronto para uso.

## Funcionalidades da aplicação

A interface permite interagir com os dados da biblioteca através de operações como:

### Livros

- Listagem de livros cadastrados
- Cadastrar, alterar e excluir livros
- Buscas por título, autor, editora ou ano de publicação
- Exibição de informações relacionadas (**Autor, editora, categoria, empréstimos e avaliações**)

### Autores

- Listagem de autores
- Cadastrar, alterar e excluir autores
- Buscas por nome e país de nascimento
- Exibição de informações relacionadas (**Livros publicados**)

### Editoras

- Listagem de editoras
- Cadastrar, alterar e excluir editoras
- Buscas por nome e país de origem
- Exibição de informações relacionadas (**Autores parceiros e Livros publicados**)

### Categorias

- Listagem de categorias

### Usuários

- Listagem de usuários
- Cadastrar, alterar e excluir usuários
- - Exibição de informações relacionadas (**Empréstimos realizados e Avaliações feitas**)

### Interface

- Exibição de dados utilizando **QuickGrid**
- Utilização de **Dictionary** para otimizar o acesso a dados relacionados
- Formulários com **validação de dados**
- Interface baseada em **componentes Razor**

---

## Futuras melhorias

Algumas melhorias que podem ser implementadas no futuro:

- Sistema de autenticação
- Melhorias de layout e responsividade
- Melhoria no sistema de empréstimo de livros

---

## Autor

Desenvolvido por **Luiz Ricardo Dias**.
