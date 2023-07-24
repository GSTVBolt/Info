use db_info
go

--ALTER TABLE tbl_pessoa_fisica ADD CONSTRAINT FKtb_pessoa_493253 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);
 
--ALTER TABLE tbl_pessoa_juridica ADD CONSTRAINT FKtb_pessoa_266428 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);
 
--ALTER TABLE tbl_usuario ADD CONSTRAINT FKtb_usuario41635 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);

--ALTER TABLE tbl_Venda ADD CONSTRAINT FKtbl_Venda366981 FOREIGN KEY (id_Pessoa) REFERENCES tbl_Pessoa (id_Pessoa)

--ALTER TABLE tbl_ItensVenda  ADD CONSTRAINT FKtbl_Itens_v307950 FOREIGN KEY (id_Produto) REFERENCES tbl_Produtos (id_Produto)

--ALTER TABLE tbl_ItensVenda ADD CONSTRAINT FKtbl_Itens_v919744 FOREIGN KEY (id_Venda) REFERENCES tbl_Venda (id_Venda)