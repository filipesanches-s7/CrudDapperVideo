# CRUD Dapper API

API REST desenvolvida com **ASP.NET Core**, **Dapper** e **PostgreSQL**, utilizando **Docker** para disponibilizar o banco de dados.

## Tecnologias

- ASP.NET Core
- Dapper
- PostgreSQL
- Docker
- Swagger
- AutoMapper

---

# Pré-requisitos

Antes de executar o projeto, certifique-se de possuir:

- .NET SDK
- Docker Desktop

> **Importante**
>
> O PostgreSQL não precisa ser instalado localmente.
> O banco de dados é criado automaticamente pelo Docker através do arquivo `docker-compose.yml`.

---

# Como executar o projeto

## 1. Clone o repositório

```bash
git clone https://github.com/filipesanches-s7/CrudDapperVideo.git
```

## 2. Acesse a pasta do projeto

```bash
cd CrudDapperVideo
```

## 3. Inicie o banco de dados

```bash
docker compose up -d
```

Na primeira execução o Docker irá:

- Baixar a imagem do PostgreSQL;
- Criar o banco de dados `CrudDpp`;
- Executar automaticamente o script `init.sql`;
- Disponibilizar o banco na porta `5432`.

## 4. Execute a API

Entre na pasta da API:

```bash
cd CrudDapperVideo
```

Execute:

```bash
dotnet run
```

Ou abra a solução no **Visual Studio** e pressione **F5**.

## 5. Acesse o Swagger

Após iniciar a aplicação, acesse o endereço informado no terminal.

Exemplo:

```text
https://localhost:7049/swagger
```

ou

```text
http://localhost:5219/swagger
```

---

# Endpoints

| Método | Endpoint | Descrição |
|---------|----------|-----------|
| GET | `/api/Usuario` | Lista todos os usuários |
| GET | `/api/Usuario/{id}` | Busca um usuário por ID |
| POST | `/api/Usuario` | Cadastra um novo usuário |
| PUT | `/api/Usuario` | Atualiza um usuário |
| DELETE | `/api/Usuario/{id}` | Remove um usuário |

---

# Banco de dados

O banco de dados é criado automaticamente pelo Docker utilizando o script `init.sql`.

Não é necessário executar scripts SQL manualmente.

---

# Autor

Filipe Henrique Sanches
