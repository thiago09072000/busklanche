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

-- select * from CadastroComercio

--update CadastroComercio set nomeComercio = CONCAT(nomeComercio, idCadComercio), cep = '54866-666' where idCadComercio in (1, 2,3);

--insert into CadastroComercio (cnpj,
--nomeComercio,
--bairro,
--rua,
--numero,
--cep,
--complemento,
--nomeRepresentante,
--emailRepresentante,
--senhaRepresentante,
--cpfRepresentante,
--telefoneRepresentante,
--estiloDoLanche,
--horarioAbertura,
--horarioEnceramento,
--DescricaoComercio)
--select cnpj,
--nomeComercio,
--bairro,
--rua,
--numero,
--cep,
--complemento,
--nomeRepresentante,
--emailRepresentante,
--senhaRepresentante,
--cpfRepresentante,
--telefoneRepresentante,
--estiloDoLanche,
--horarioAbertura,
--horarioEnceramento,
--DescricaoComercio from CadastroComercio where idCadComercio = 2;



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

--select * from CadastroDeCardapio

create table Avaliacoes
(
	idAvaliacoes	integer primary key identity(1,1),
	idCadComercio	integer references		CadastroComercio,
	idCadConsumidor	integer references      CadastroConsumidor,
	avaliacao		integer,
	comentario		varchar(max),
	dataHora		datetime not null default getdate()
)

--select * from CadastroDeCardapio

select * from Avaliacoes

insert into Avaliacoes (idCadComercio, idCadConsumidor, avaliacao, comentario, dataHora)
select idCadComercio, idCadConsumidor, avaliacao, comentario, getdate() from Avaliacoes where idCadComercio = 5;

update Avaliacoes set avaliacao = case when idAvaliacoes % 2 = 0 then 3 else 5 end;


select cast(avg(cast(avaliacao as decimal(15,2))) as decimal(15,2)) as media_nota from Avaliacoes where idCadComercio = 2;
select avg(avaliacao) from Avaliacoes where idCadComercio = 5;


SELECT 
                                    *,
                                    coalesce((select cast(avg(cast(avaliacao as decimal(15,2))) as decimal(15,2)) as media_nota from Avaliacoes where idCadComercio = CadastroComercio.idCadComercio), 0) as media_nota
                                FROM CadastroComercio 
								WHERE cep = @cep;