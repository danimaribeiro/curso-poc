using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Poc.Core.Mapeamento;

namespace Poc.Core.Contexto
{
    public class DatabaseContexto : DbContext
    {
        static DatabaseContexto()
        {
            Database.SetInitializer<DatabaseContexto>(null);
        }

        public DatabaseContexto()
            : base("name=pocEntities")
        {
        }

        public DatabaseContexto(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DatabaseContexto(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
        }

        public DatabaseContexto(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public DatabaseContexto(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Clientes_Mapping());
            modelBuilder.Configurations.Add(new FormasPagamento_Mapping());
            modelBuilder.Configurations.Add(new Grupos_Mapping());
            modelBuilder.Configurations.Add(new ItensPedido_Mapping());
            modelBuilder.Configurations.Add(new Pedidos_Mapping());
            modelBuilder.Configurations.Add(new Produtos_Mapping());
            modelBuilder.Configurations.Add(new Usuarios_Mapping());
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<FormasPagamento> FormasPagamento { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
