create database if not exists reist_2021;
-- default character set latin1
-- collate latin1_general_cs;
use reist_2021;

create table usuario(
	id int primary key auto_increment,
	username varchar(30) not null,
    senha varchar(128) not null,
    nivel int not null
);

create table cliente(
	nome varchar(60) not null,
    email varchar(60) not null
);


/* --- */


insert into usuario values(default, "adm", "123", 1);
insert into cliente values("Davi Oliveira", "davi@gmail.com");
select * from usuario;
select * from cliente;
select * from usuario where username = 'dd';

-- drop table usuario;
-- drop database reist_2021;