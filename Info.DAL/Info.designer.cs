﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Info.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_info")]
	public partial class InfoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    #endregion
		
		public InfoDataContext() : 
				base(global::Info.DAL.Properties.Settings.Default.db_infoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InfoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categorias
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produtos
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Categorias")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private EntitySet<Produto> _Produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public Categoria()
		{
			this._Produtos = new EntitySet<Produto>(new Action<Produto>(this.attach_Produtos), new Action<Produto>(this.detach_Produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_Categoria", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="ds_Categoria", Storage="_Descricao", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Categoria_tbl_Produto", Storage="_Produtos", ThisKey="Codigo", OtherKey="CodigoCategoria")]
		public EntitySet<Produto> Produtos
		{
			get
			{
				return this._Produtos;
			}
			set
			{
				this._Produtos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Produtos(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Produtos")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private System.Nullable<decimal> _Valor;
		
		private System.Nullable<int> _CodigoCategoria;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnValorChanging(System.Nullable<decimal> value);
    partial void OnValorChanged();
    partial void OnCodigoCategoriaChanging(System.Nullable<int> value);
    partial void OnCodigoCategoriaChanged();
    #endregion
		
		public Produto()
		{
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_Produto", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="ds_Produto", Storage="_Descricao", DbType="VarChar(80)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="vl_Valor", Storage="_Valor", DbType="Decimal(15,2)")]
		public System.Nullable<decimal> Valor
		{
			get
			{
				return this._Valor;
			}
			set
			{
				if ((this._Valor != value))
				{
					this.OnValorChanging(value);
					this.SendPropertyChanging();
					this._Valor = value;
					this.SendPropertyChanged("Valor");
					this.OnValorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_Categoria", Storage="_CodigoCategoria", DbType="Int")]
		public System.Nullable<int> CodigoCategoria
		{
			get
			{
				return this._CodigoCategoria;
			}
			set
			{
				if ((this._CodigoCategoria != value))
				{
					this.OnCodigoCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodigoCategoria = value;
					this.SendPropertyChanged("CodigoCategoria");
					this.OnCodigoCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_Categoria_tbl_Produto", Storage="_Categoria", ThisKey="CodigoCategoria", OtherKey="Codigo", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Produtos.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Produtos.Add(this);
						this._CodigoCategoria = value.Codigo;
					}
					else
					{
						this._CodigoCategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
