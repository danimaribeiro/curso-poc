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
    
    internal partial class Clientes_Mapping : EntityTypeConfiguration<Clientes>
    {
        public Clientes_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Clientes");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Cpf).HasColumnName("Cpf").IsRequired().HasMaxLength(20);
    		this.Property(t => t.Endereco).HasColumnName("Endereco").HasMaxLength(50);
    		this.Property(t => t.DataNascimento).HasColumnName("DataNascimento");
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.AtualizadoPor).HasColumnName("AtualizadoPor");
    		this.HasRequired(t => t.Usuarios).WithMany(t => t.Clientes).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios1).WithMany(t => t.Clientes1).HasForeignKey(d => d.AtualizadoPor);
    	}
    }
}
