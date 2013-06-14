namespace Poc.Core.Mapeamento
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Pedidos_Mapping : EntityTypeConfiguration<Pedidos>
    {
        public Pedidos_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Pedidos");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.DataPedido).HasColumnName("DataPedido");
    		this.Property(t => t.FormaPagamentoId).HasColumnName("FormaPagamentoId");
    		this.Property(t => t.ClienteId).HasColumnName("ClienteId");
    		this.Property(t => t.ValorTotal).HasColumnName("ValorTotal");
    		this.Property(t => t.Numero).HasColumnName("Numero");
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.AtualizadoPor).HasColumnName("AtualizadoPor");
    		this.HasRequired(t => t.Clientes).WithMany(t => t.Pedidos).HasForeignKey(d => d.ClienteId);
    		this.HasRequired(t => t.FormasPagamento).WithMany(t => t.Pedidos).HasForeignKey(d => d.FormaPagamentoId);
    		this.HasRequired(t => t.Usuarios).WithMany(t => t.Pedidos).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios1).WithMany(t => t.Pedidos1).HasForeignKey(d => d.AtualizadoPor);
    	}
    }
}
