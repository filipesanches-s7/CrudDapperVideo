# Como executar o projeto

## 1. Clone o repositório

```powershell
git clone https://github.com/filipesanches-s7/CrudDapperVideo.git
```

## 2. Acesse a pasta do projeto

```powershell
cd CrudDapperVideo
```

## 3. Inicie o banco de dados

O projeto utiliza **Docker** para executar o PostgreSQL. Execute o comando abaixo:

```powershell
docker compose up -d
```

Na primeira execução, o Docker irá:

- Baixar a imagem do PostgreSQL;
- Criar o banco de dados **CrudDpp**;
- Executar automaticamente o script `init.sql`;
- Disponibilizar o banco na porta **5432**.

## 4. Execute a API

Pelo terminal:

```powershell
dotnet run
```

Ou abra a solução no **Visual Studio** e execute normalmente.

## 5. Acesse o Swagger

Com a aplicação em execução, abra:

```text
https://localhost:7049/swagger
```

No Swagger é possível testar todos os endpoints da API.

---

# Endpoints disponíveis

| Método | Endpoint | Descrição |
|---------|----------|-----------|
| GET | `/api/Usuario` | Lista todos os usuários |
| GET | `/api/Usuario/{id}` | Busca um usuário por ID |
| POST | `/api/Usuario` | Cadastra um novo usuário |
| PUT | `/api/Usuario` | Atualiza um usuário |
| DELETE | `/api/Usuario/{id}` | Remove um usuário |
