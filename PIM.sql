create database PIM4

use PIM4

ALTER TABLE dadosCliente
ADD CONSTRAINT fk_dadosCliente FOREIGN KEY (idCliente) REFERENCES apolice (idApolice);

drop table dadosCliente
create table dadosCliente(
idCliente int primary key not null,
clientePj bit not null,
nomeCliente varchar(40) not null,
foneCliente varchar(40) not null,
cpfCliente varchar(20) not null,
rgCliente varchar(20) null,
emailCliente varchar(20) null,
dataNascCliente dateTime, 
sexoCliente varchar(20),
estCivCliente varchar(20),
altura float not null,
peso float not null,
fumante bit,
cirurgias bit,
doencas bit,
rua varchar(40), 
numero int,
bairro varchar(40),
cidade varchar(40),
uf varchar(10),
complemento varchar(40)
)

ALTER TABLE dadosCliente
ADD CONSTRAINT fk_apolice FOREIGN KEY (idCliente) REFERENCES apolice (idApolice);
 --ADD CONSTRAINT fk_endereco FOREIGN KEY (idCliente) REFERENCES endereco (idEndereco);

--ADD CONSTRAINT fk_info FOREIGN KEY (idCliente) REFERENCES infoComplementares (infoId);

--ADD CONSTRAINT fk_dadosDp FOREIGN KEY (idCliente) REFERENCES dependentes (dependentesId);


CREATE table CadFunc(
funcId int primary key not null, 
funcNome varchar(40) not null,
cargo varchar(40) not null, 
funcDataNasc dateTime not null,
funcFone varchar(40) not null,
funcSexo varchar(40) not null,
funcCpf varchar(14) not null, 
funcEstCiv varchar(20) not null,
funcRg varchar(20) not null,
funcCep varchar(10) not null,
funcEmail varchar(40) not null
)
 

 drop FOREIGN KEY fk_desempenho 


create table vendas(

vendasId int identity(1,1) primary key not null,
plano varchar(40) not null,
dataVenda date not null,
FOREIGN KEY (idCliente_vendas) REFERENCES dadosCliente(idCliente) ON DELETE CASCADE,
idCliente_vendas INT NOT NULL
FOREIGN KEY (funcId_vendas) REFERENCES CadFunc(funcId) ON DELETE CASCADE,
funcId_vendas INT NOT NULL
FOREIGN KEY (idSeguradora_vendas) REFERENCES seguradora(idSeguradora) ON DELETE CASCADE,
idSeguradora_vendas INT NOT NULL
)

create Procedure insertVendas(
@plano varchar(40),
@dataVenda date,
@idCliente_vendas int,
@funcId_vendas int,
@idSeguradora_vendas int
)
as
begin
insert into vendas( plano, dataVenda, idCliente_vendas,funcId_vendas, idSeguradora_vendas)
values(@plano, @dataVenda, @idCliente_vendas, @funcId_vendas,@idSeguradora_vendas);
end

select *  from vendas
Create table seguradora (
idSeguradora int primary key not null,
nomeSeguradora varchar(40) not null,
cnpjSeguradora varchar(25) not null,
foneSeguradora varchar(20) not null,
emailSeguradora varchar(40) not null,
tipoServico varchar(40)not null,
ruaSeguradora varchar(40)not null,
numSeguradora int not null,
bairroSeguradora varchar(40)not null,
cidadeSeguradora varchar(40)not null,
ufSeguradora varchar(10)not null,
complementoSeguradora varchar(40)not null
)

CREATE PROCEDURE cadastrarSeguradora(
@idSeguradora int,
@nomeSeguradora varchar(40),
@cnpjSeguradora varchar(25),
@foneSeguradora varchar(20),
@emailSeguradora varchar(40),
@tipoServico varchar(40),
@ruaSeguradora varchar(40),
@numSeguradora int,
@bairroSeguradora varchar(40),
@cidadeSeguradora varchar(40),
@ufSeguradora varchar(10),
@complementoSeguradora varchar(40)
)
as
begin
insert into seguradora (idSeguradora, nomeSeguradora, cnpjSeguradora, foneSeguradora, emailSeguradora, tipoServico,  ruaSeguradora, numSeguradora, bairroSeguradora, cidadeSeguradora, ufSeguradora, complementoSeguradora)
values(@idSeguradora, @nomeSeguradora, @cnpjSeguradora, @foneSeguradora, @emailSeguradora, @tipoServico, @ruaSeguradora, @numSeguradora,  @bairroSeguradora, @cidadeSeguradora, @ufSeguradora, @complementoSeguradora);
end

CREATE PROCEDURE atualizaDadosSeguradora
@idSeguradora int,
@nomeSeguradora varchar(40),
@cnpjSeguradora varchar(25),
@foneSeguradora varchar(20),
@emailSeguradora varchar(40),
@tipoServico varchar(40),
@ruaSeguradora varchar(40),
@numSeguradora int,
@bairroSeguradora varchar(40),
@cidadeSeguradora varchar(40),
@ufSeguradora varchar(10),
@complementoSeguradora varchar(40)

AS
UPDATE seguradora
SET
seguradora.idSeguradora = @idSeguradora,
seguradora.nomeSeguradora = @nomeSeguradora,
seguradora.cnpjSeguradora = @cnpjSeguradora,
seguradora.foneSeguradora = @foneSeguradora,
seguradora.emailSeguradora= @emailSeguradora,
seguradora.tipoServico = @tipoServico,
seguradora.ruaSeguradora = @ruaSeguradora,
seguradora.numSeguradora = @numSeguradora,
seguradora.bairroSeguradora = @bairroSeguradora,
seguradora.cidadeSeguradora = @cidadeSeguradora,
seguradora.ufSeguradora = @ufSeguradora,
seguradora.complementoSeguradora = @complementoSeguradora

WHERE seguradora.idSeguradora = @idSeguradora

create procedure deletaSeguradora
@idSeguradora int,
@nomeSeguradora varchar(40),
@cnpjSeguradora varchar(25),
@foneSeguradora varchar(20),
@emailSeguradora varchar(40),
@tipoServico varchar(40),
@ruaSeguradora varchar(40),
@numSeguradora int,
@bairroSeguradora varchar(40),
@cidadeSeguradora varchar(40),
@ufSeguradora varchar(10),
@complementoSeguradora varchar(40)

AS
DELETE seguradora
WHERE seguradora.idSeguradora = @idSeguradora


create table loginTsb(
loginId int primary key not null,
funcEmail varchar(40), 
funcCpf varchar(14),

emailAdm varchar(40),
senhaAdm varchar(10)
)
create table  administrador(
emailAdm varchar(40),
senhaAdm varchar(40)
)

drop table dependentes


select * from administrador

select 

insert into administrador values
('adm.unip@tsb.com.br', '123456');

create PROCEDURE getDadosAdm
@emailAdm varchar(40),
@senhaAdm varchar(40)
as
select adm.* from administrador adm WHERE adm.emailAdm = @emailAdm and adm.senhaAdm = @senhaAdm

exec getDadosAdm  
@emailAdm = 'adm.unip@tsb.com.br',
@senhaAdm  = '123456'


CREATE PROCEDURE getFuncionario
as
select * from CadFunc 

exec getClientes

CREATE PROCEDURE getClientes
as
select * from dadosCliente

CREATE PROCEDURE getSeguradora
as
select * from seguradora 

Create Procedure insertVendas
@funcId int, 
@funcNome varchar(40),
@cargo varchar(40), 
@funcDataNasc dateTime,
@funcFone varchar(40),


Create PROCEDURE InsertDadosFuncionario
@funcId int, 
@funcNome varchar(40),
@cargo varchar(40), 
@funcDataNasc dateTime,
@funcFone varchar(40),
@funcSexo varchar(40),
@funcCpf varchar(14), 
@funcEstCiv varchar(20),
@funcRg varchar(20),
@funcCep varchar(10),
@funcEmail varchar(40)
as
begin
insert into CadFunc (funcId, funcNome, cargo, funcDataNasc, funcFone, funcSexo, funcCpf, funcEstCiv, funcRg, funcCep, funcEmail)
values(@funcId, @funcNome, @cargo, @funcDataNasc, @funcFone, @funcSexo, @funcCpf, @funcEstCiv, @funcRg, @funcCep, @funcEmail);
end

Create procedure atualizaDadosFuncionario
@funcId int, 
@funcNome varchar(40),
@cargo varchar(40), 
@funcDataNasc dateTime,
@funcFone varchar(40),
@funcSexo varchar(40),
@funcCpf varchar(14), 
@funcEstCiv varchar(20),
@funcRg varchar(20),
@funcCep varchar(10),
@funcEmail varchar(40)

AS
update CadFunc
SET
CadFunc.funcId = @funcId,
CadFunc.funcNome = @funcNome,
CadFunc.cargo = @cargo,
CadFunc.funcDataNasc = @funcDataNasc,
CadFunc.funcFone = @funcFone,
CadFunc.funcSexo = @funcSexo,
CadFunc.funcCpf = @funcCpf,
CadFunc.funcEstCiv = @funcEstCiv,
CadFunc.funcRg = @funcRg,
CadFunc.funcCep = @funcCep,
CadFunc.funcEmail = @funcEmail

WHERE CadFunc.funcId = @funcId

Create procedure deletaDadosFuncionario
@funcId int, 
@funcNome varchar(40),
@cargo varchar(40), 
@funcDataNasc dateTime,
@funcFone varchar(40),
@funcSexo varchar(40),
@funcCpf varchar(14), 
@funcEstCiv varchar(20),
@funcRg varchar(20),
@funcCep varchar(10),
@funcEmail varchar(40)

AS
DELETE CadFunc
WHERE CadFunc.funcId = @funcId

create procedure InserirDadosCliente

@idCliente int,
@clientePj bit,
@nomeCliente varchar(40),
@foneCliente varchar(40),
@cpfCliente varchar(14),
@rgCliente varchar(20),
@emailCliente varchar(40),
@dataNascCliente dateTime,
@sexoCliente varchar(40),
@estCivCliente varchar(40),
@altura float,
@peso float,
@fumante bit,
@cirurgias bit,
@doencas bit,
@rua varchar(40),
@numero int,
@bairro varchar(40),
@cidade varchar(40),
@uf varchar(40),
@complemento varchar(40)
as
begin
insert into dadosCliente(idCliente, clientePj, nomeCliente, foneCliente, cpfCliente, rgCliente, emailCliente, dataNascCliente, sexoCliente, estCivCliente, altura, peso, fumante, cirurgias, doencas, rua, numero, bairro, cidade, uf, complemento)
values(@idCliente, @clientePj, @nomeCliente, @foneCliente, @cpfCliente, @rgCliente, @emailCliente, @dataNascCliente, @sexoCliente, @estCivCliente, @altura, @peso, @fumante, @cirurgias, @doencas, @rua, @numero, @bairro, @cidade, @uf, @complemento)
end

CREATE PROCEDURE atualizaCliente

@idCliente int,
@clientePj bit,
@nomeCliente varchar(40),
@foneCliente varchar(40),
@cpfCliente varchar(14),
@rgCliente varchar(20),
@emailCliente varchar(40),
@dataNascCliente dateTime,
@sexoCliente varchar(40),
@estCivCliente varchar(40),
@altura float,
@peso float,
@fumante bit,
@cirurgias bit,
@doencas bit,
@rua varchar(40),
@numero int,
@bairro varchar(40),
@cidade varchar(40),
@uf varchar(40),
@complemento varchar(40)

AS
UPDATE dadosCliente
SET dadosCliente.idCliente = @idCliente,
dadosCliente.clientePj = @clientePj,
dadosCliente.nomeCliente = @nomeCliente,
dadosCliente.foneCliente = @foneCliente,
dadosCliente.cpfCliente = @cpfCliente,
dadosCliente.rgCliente = @rgCliente,
dadosCliente.emailCliente = @emailCliente,
dadosCliente.dataNascCliente = @dataNascCliente,
dadosCliente.sexoCliente = @sexoCliente,
dadosCliente.estCivCliente = @estCivCliente,
dadosCliente.altura = @altura,
dadosCliente.peso = @peso,
dadosCliente.fumante = @fumante,
dadosCliente.cirurgias = @cirurgias,
dadosCliente.doencas = @doencas,
dadosCliente.rua = @rua,
dadosCliente.numero = @numero,
dadosCliente.bairro = @bairro,
dadosCliente.cidade = @cidade,
dadosCliente.uf = @uf,
dadosCliente.complemento = @complemento
WHERE dadosCliente.idCliente = @idCliente

CREATE PROCEDURE deletaCliente

@idCliente int,
@clientePj bit,
@nomeCliente varchar(40),
@foneCliente varchar(40),
@cpfCliente varchar(14),
@rgCliente varchar(20),
@emailCliente varchar(40),
@dataNascCliente dateTime,
@sexoCliente varchar(40),
@estCivCliente varchar(40),
@altura float,
@peso float,
@fumante bit,
@cirurgias bit,
@doencas bit,
@rua varchar(40),
@numero int,
@bairro varchar(40),
@cidade varchar(40),
@uf varchar(40),
@complemento varchar(40)

AS
DELETE dadosCliente
WHERE dadosCliente.idCliente = @idCliente

