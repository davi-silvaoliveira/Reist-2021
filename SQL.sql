create database if not exists reist_2021;
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


insert into usuario values(default, "Davi", "123", 0);
insert into cliente values("Davi Oliveira", "davi@gmail.com");
select * from usuario;
select * from cliente;

-- drop table usuario;