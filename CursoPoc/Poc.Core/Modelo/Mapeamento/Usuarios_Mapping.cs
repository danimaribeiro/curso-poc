namespace Poc.Core.Mapeamento
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Usuarios_Mapping : EntityTypeConfiguration<Usuarios>
    {
        public Usuarios_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Usuarios");
    		this.Property(t => t.Id).HasColumnName("Id");
    		this.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Usuario).HasColumnName("Usuario").IsRequired().HasMaxLength(50);
    		this.Property(t => t.Senha).HasColumnName("Senha").IsRequired().HasMaxLength(20);
    		this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
    		this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
    		this.Property(t => t.CriadoPor).HasColumnName("CriadoPor");
    		this.Property(t => t.ModificadorPor).HasColumnName("ModificadorPor");
    		this.HasOptional(t => t.Usuarios2).WithMany(t => t.Usuarios1).HasForeignKey(d => d.CriadoPor);
    		this.HasOptional(t => t.Usuarios3).WithMany(t => t.Usuarios11).HasForeignKey(d => d.ModificadorPor);
    	}
    }
}

