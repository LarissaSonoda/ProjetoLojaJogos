create database dbLojaGames;
use dbLojaGames;

create table tbJogo(
	CodJogo int primary key auto_increment,
    Nome varchar(150) not null,
    versao varchar(10),
    desenvolvedor varchar(100) not null,
    genero varchar(100) not null,
    faixaetaria int not null,
    plataforma varchar(100) not null,
    dtlanc int not null,
    descricao varchar(150)
);

create table tbCliente(
	CliNome varchar(150) not null,
    CliCPF varchar(15) primary key,
    CliDtNasc date not null,
    CliEmail  varchar(150) not null,
    CliCel varchar(9) not null,
    CliEndereco varchar(150) not null
);

create table tbFunc(
	CodFunc int primary key auto_increment,
    FuncNome varchar(150) not null,
    FuncCPF varchar(15) not null,
    FuncRG varchar(15) not null,
    FuncDtNasc date not null,
    FuncEndereco varchar(100) not null,
    FuncCel varchar(9) not null,
    FuncEmail varchar(100) not null,
    FuncCargo varchar(100) not null
);

CREATE USER 'games'@'localhost' IDENTIFIED WITH mysql_native_password BY '123456';
 GRANT ALL PRIVILEGES ON dbLojaGames.* TO 'games'@'localhost' WITH GRANT OPTION;