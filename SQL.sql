create database if not exists reist_2021;
-- default character set latin1
-- collate latin1_general_cs;
use reist_2021;

create table estado(
	id_estado int primary key auto_increment,
    UF_estado varchar(2) not null unique
);

create table cidade(
	id_cidade int primary key auto_increment,
    nome_cidade varchar(100) not null,
    UF int not null,
    constraint fk_uf_cidade foreign key (UF) references estado(id_estado)
);

create table bairro(
	id_bairro int primary key auto_increment,
    nome_bairro varchar(100) not null,
    cidade int not null,
    constraint fk_cidade_bairro foreign key (cidade) references cidade(id_cidade)
);

create table endereco(
	cep int(8) zerofill primary key,
    logradouro varchar(100) not null,
    bairro int not null,
    constraint fk_bairro_endereco foreign key (bairro) references bairro(id_bairro)
);

create table cliente(
	cpf bigint(11) primary key,
	nome varchar(60) not null,
    email varchar(60) not null unique,
    senha varchar(128) not null,
    celular bigint(11) not null,
    sexo char not null,
    numero_endereco int not null,
    data_nascimento date not null,
    endereco int(8) zerofill,
    constraint fk_endereco_cliente foreign key (endereco) references endereco(cep)
);

create table funcionario(
	cpf bigint(11) primary key,
	nome varchar(60) not null,
    email varchar(60) not null unique,
    senha varchar(128) not null,
    celular bigint(11) not null,
    sexo char not null,
    numero_endereco int not null,
    data_nascimento date not null,
    endereco int(8) zerofill,
    acesso int not null,
    constraint fk_endereco_funcionario foreign key (endereco) references endereco(cep)
);


/* --- */


insert into estado values(default, "SP");
insert into cidade values(default, "São Paulo", 1);
insert into bairro values(default, "Vila Leopoldina", 1);
insert into endereco values(05089000, "Guaipá", 1);
insert into cliente values("12312312301", "Davi Silva Oliveira", "davi@gmail.com",
"FA3C1CDEE866E8B57B644E55AA85AD1F001EA14471DA9D41CDD3195E5613F4B8B6FFF905E7F1AFB3954A3E182E92C52497E41DECF5718B51A09BFADF52E77F20",
"11951982768", "M",
"678", str_to_date('4/7/2003', "%d/%m/%Y"), 05089000);

select * from endereco;
select * from cliente;

-- drop table funcionario;
-- truncate table cliente;
-- drop database reist_2021;