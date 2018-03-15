CREATE DATABASE BuskLanche
GO

USE BuskLanche
GO

create table CadastroComercio
(
	idCadComercio			integer primary key identity(1,1),
	cnpj					varchar(20),
	nomeComercio			varchar(100),
	bairro					varchar(300),
	rua						varchar(300),
	numero					integer,
	cep						varchar(10),
	complemento				varchar(max),
	nomeRepresentante		varchar(100),
	emailRepresentante		varchar(200),
	senhaRepresentante		varchar(8),
	cpfRepresentante		varchar(15),
	telefoneRepresentante	varchar(15),
	estiloDoLanche			varchar(200),
	horarioAbertura			varchar(5),
	horarioEnceramento		varchar(5),
	DescricaoComercio		varchar(max)
)

create table CadastroConsumidor
(
	idCadConsumidor		integer primary key identity(1,1),
	nomeConsumidor		varchar(200),
	emailConsumidor		varchar(200),
	senhaConsumidor		varchar(8),
	cpfConsumidor		varchar(15)
)

create table CadastroDeCardapio
(
	idCadCardapio	integer primary key identity(1,1),
	nome			varchar(200),
	ingrediente		varchar(200),
	preco			varchar(100)
)

create table Avaliacoes
(
	idAvaliacoes	integer primary key identity(1,1),
	avaliacao		integer,
	comentario		varchar(max)
)