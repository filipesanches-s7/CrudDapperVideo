CREATE TABLE IF NOT EXISTS usuarios (
    id SERIAL PRIMARY KEY,
    nomecompleto VARCHAR(200) NOT NULL,
    email VARCHAR(200) NOT NULL,
    cargo VARCHAR(100),
    unidade VARCHAR(100),
    situacao BOOLEAN NOT NULL,
    senha VARCHAR(200) NOT NULL
);