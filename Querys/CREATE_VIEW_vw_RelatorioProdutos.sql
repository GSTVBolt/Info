use db_info
go

CREATE VIEW vw_RelatorioProdutos
AS
SELECT 
	tbl_Produtos.id_Produto,
	tbl_Produtos.ds_Produto,
	tbl_Produtos.vl_Valor,
	tbl_Produtos.id_Categoria,
	tbl_Categorias.ds_Categoria
FROM tbl_Categorias, tbl_Produtos
