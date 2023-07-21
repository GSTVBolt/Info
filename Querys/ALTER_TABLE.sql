use db_info
go

ALTER TABLE tbl_pessoa_fisica ADD CONSTRAINT FKtb_pessoa_493253 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);
 
ALTER TABLE tbl_pessoa_juridica ADD CONSTRAINT FKtb_pessoa_266428 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);
 
ALTER TABLE tbl_usuario ADD CONSTRAINT FKtb_usuario41635 FOREIGN KEY (id_pessoa) REFERENCES tbl_pessoa (id_pessoa);