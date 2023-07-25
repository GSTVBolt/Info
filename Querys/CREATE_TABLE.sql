use db_info
go

--CREATE TABLE tbl_Categorias (
--	id_Categoria INT PRIMARY KEY IDENTITY,
--	ds_Categoria VARCHAR(50) NOT NULL
--)

--CREATE TABLE tbl_Produtos (
--	id_Produto INT PRIMARY KEY IDENTITY,
--	ds_Produto VARCHAR(80),
--	vl_Valor DECIMAL(15,2),
--	id_Categoria INT
--	FOREIGN KEY (id_Categoria) REFERENCES tbl_Categorias (id_Categoria)
--)

--CREATE TABLE tbl_Usuario (
--	id_Pessoa INT NOT NULL, PRIMARY KEY (id_pessoa),
--	Usuario VARCHAR(50) NOT NULL UNIQUE, 
--	Senha VARCHAR(50) NOT NULL
--);

--CREATE TABLE tbl_Pessoa_Juridica (
--	id_pessoa INT NOT NULL, PRIMARY KEY (id_pessoa),
--	CNPJ VARCHAR(30) NOT NULL UNIQUE, 
--	Inscricao VARCHAR(30) NOT NULL UNIQUE, 
--	razao_Social VARCHAR(200) NOT NULL
--);

--CREATE TABLE tbl_Pessoa_Fisica (
--	id_Pessoa INT NOT NULL, PRIMARY KEY (id_pessoa),
--	CPF VARCHAR(20) NOT NULL UNIQUE, 
--	RG VARCHAR(20) NOT NULL UNIQUE, 
--	dt_Nascimento DATE, 
--	nm_Pai VARCHAR(200), 
--	nm_Mae VARCHAR(200)
--);

--CREATE TABLE tbl_Pessoa (
--	id_Pessoa INT PRIMARY KEY IDENTITY(1, 1) NOT NULL, 
--	ds_Email varchar(200),
--	nm_Nome VARCHAR(200) NOT NULL, 
--	no_Telefone VARCHAR(30)
--);

--CREATE TABLE tbl_ItensVenda (
--	qt_Quantidade INT NOT NULL,
--	id_Produto INT NOT NULL,
--	id_Venda INT NOT NULL,
--	vl_Valor DECIMAL(15,2) NOT NULL,
--	id_Item INT PRIMARY KEY IDENTITY(1, 1) NOT NULL
--)

--CREATE TABLE tbl_Venda (
--	id_Venda INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
--	vl_Valor DECIMAL(12, 2),
--	dc_Desconto DECIMAL(15, 2),
--	vl_ValorPago DECIMAL(15, 2),
--	id_Pessoa INT
--)

--CREATE TABLE tbl_StatusPagamento (
--	id_Status INT PRIMARY KEY IDENTITY NOT NULL, 
--	ds_Status VARCHAR(50) NOT NULL
--)

--CREATE TABLE tbl_ContasReceber (
--	id_Conta INT PRIMARY KEY IDENTITY(1, 1) NOT NULL, 
--	dt_Compra DATE NOT NULL, 
--	dt_Vencimento DATE NOT NULL, 
--	dt_Pagamento DATE, 
--	id_Venda INT NOT NULL, 
--	id_Status INT NOT NULL  
--);
