Para criar o banco e a tabela utilize o código abaixo:

    create database eldenringdb;
    use eldenringdb;
    create table bosses (
    	id VARCHAR(100) PRIMARY KEY,
        name VARCHAR(100),
    	image TEXT,
        description TEXT,
        location VARCHAR(200),
        drops TEXT,
        healthPoints VARCHAR(50)
    );

OBS: Banco MySQL. Atualizar no código com as credenciais do seu banco.
