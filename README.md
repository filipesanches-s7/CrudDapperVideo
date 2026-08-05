Como executar o projeto

### 1. Clone o repositório

```bash
git clone https://github.com/filipesanches-s7/CrudDapperVideo.git
```

### 2. Acesse a pasta do projeto

```bash
cd CrudDapperVideo
```

### 3. Inicie o banco de dados

O projeto utiliza um container Docker para o PostgreSQL.

```bash
docker compose up -d
```

Na primeira execução o Docker irá:

- baixar a imagem do PostgreSQL;
- criar o banco de dados `CrudDpp`;
- executar automaticamente o script de criação da tabela;
- disponibilizar o banco na porta **5432**.

### 4. Execute a API

Pelo terminal:

```bash
dotnet run
```

Ou abra a solução no **Visual Studio** e execute normalmente.

### 5. Acesse o Swagger

Depois que a aplicação iniciar, acesse:

```
https://localhost:7049/swagger
```

Por meio do Swagger é possível testar todos os endpoints da API.

---

## Endpoints disponíveis

| Método | Endpoint | Descrição |
|---------|----------|-----------|
| GET | `/api/Usuario` | Lista todos os usuários |
| GET | `/api/Usuario/{id}` | Busca um usuário por ID |
| POST | `/api/Usuario` | Cadastra um novo usuário |
| PUT | `/api/Usuario` | Atualiza um usuário |
| DELETE | `/api/Usuario/{id}` | Remove um usuário |
