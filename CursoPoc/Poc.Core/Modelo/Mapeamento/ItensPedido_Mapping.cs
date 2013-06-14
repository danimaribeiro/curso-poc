namespace Poc.Core.Mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class ItensPedido_Mapping : EntityTypeConfiguration<ItensPedido>
    {
        public ItensPedido_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("ItensPedido");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Indice).HasColumnName("Indice");
    		this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
    		this.Property(t => t.Quantidade).HasColumnName("Quantidade");
    		this.Property(t => t.ValorBrutoUnitario).HasColumnName("ValorBrutoUnitario");
    		this.Property(t => t.DescontoUnitario).HasColumnName("DescontoUnitario");
    		this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");
    		this.Property(t => t.DescontoFinal).HasColumnName("DescontoFinal");
    		this.Property(t => t.ValorFinal).HasColumnName("ValorFinal");
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.AtualizadoPor).HasColumnName("AtualizadoPor");
    		this.Property(t => t.PedidoId).HasColumnName("PedidoId");
    		this.HasOptional(t => t.Pedidos).WithMany(t => t.ItensPedido).HasForeignKey(d => d.PedidoId);
    		this.HasRequired(t => t.Produtos).WithMany(t => t.ItensPedido).HasForeignKey(d => d.ProdutoId);
    		this.HasRequired(t => t.Usuarios).WithMany(t => t.ItensPedido).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios1).WithMany(t => t.ItensPedido1).HasForeignKey(d => d.AtualizadoPor);
    	}
    }
}
