namespace Poc.Core.Mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Produtos_Mapping : EntityTypeConfiguration<Produtos>
    {
        public Produtos_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Produtos");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
    		this.Property(t => t.GrupoId).HasColumnName("GrupoId");
    		this.Property(t => t.ValorVenda).HasColumnName("ValorVenda");
    		this.Property(t => t.QuantidadeEstoque).HasColumnName("QuantidadeEstoque");
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.AtualizadoPor).HasColumnName("AtualizadoPor");
    		this.HasRequired(t => t.Grupos).WithMany(t => t.Produtos).HasForeignKey(d => d.GrupoId);
    		this.HasRequired(t => t.Usuarios).WithMany(t => t.Produtos).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios1).WithMany(t => t.Produtos1).HasForeignKey(d => d.AtualizadoPor);
    	}
    }
}
