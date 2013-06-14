namespace Poc.Core.Mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Grupos_Mapping : EntityTypeConfiguration<Grupos>
    {
        public Grupos_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Grupos");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.AtualizadoPor).HasColumnName("AtualizadoPor");
    		this.HasRequired(t => t.Usuarios).WithMany(t => t.Grupos).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios1).WithMany(t => t.Grupos1).HasForeignKey(d => d.AtualizadoPor);
    	}
    }
}
