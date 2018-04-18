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

insert into CadastroComercio 
values
('123456789', 'nomeComercio', 'bairro', 'rua', 134, 'cep', 'complemento', 'nome', 'email', 'senha', 'cpf', 'telefone', 'estiloDoLanche', '22:00', '23:00', 'DescricaoComercio')

select * from CadastroComercio

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
	idCadComercio	integer references CadastroComercio,
	nome			varchar(200),
	ingrediente		varchar(200),
	preco			decimal(7, 2)
)

insert into CadastroDeCardapio
values
(1, 'nome', 'ingrediente', 24.00)

select * from CadastroDeCardapio

create table Avaliacoes
(
	idAvaliacoes	integer primary key identity(1,1),
	idCadComercio	integer references		CadastroComercio,
	idCadConsumidor	integer references      CadastroConsumidor,
	avaliacao		integer,
	comentario		varchar(max)
)