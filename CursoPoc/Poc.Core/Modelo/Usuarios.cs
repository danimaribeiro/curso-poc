namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.Clientes = new HashSet<Clientes>();
            this.Clientes1 = new HashSet<Clientes>();
            this.Grupos = new HashSet<Grupos>();
            this.Grupos1 = new HashSet<Grupos>();
            this.ItensPedido = new HashSet<ItensPedido>();
            this.ItensPedido1 = new HashSet<ItensPedido>();
            this.Pedidos = new HashSet<Pedidos>();
            this.Pedidos1 = new HashSet<Pedidos>();
            this.Produtos = new HashSet<Produtos>();
            this.Produtos1 = new HashSet<Produtos>();
            this.Usuarios1 = new HashSet<Usuarios>();
            this.Usuarios11 = new HashSet<Usuarios>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public Nullable<long> CriadoPor { get; set; }
        public Nullable<long> ModificadorPor { get; set; }
    
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Clientes> Clientes1 { get; set; }
        public virtual ICollection<Grupos> Grupos { get; set; }
        public virtual ICollection<Grupos> Grupos1 { get; set; }
        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public virtual ICollection<ItensPedido> ItensPedido1 { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Pedidos> Pedidos1 { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }
        public virtual ICollection<Produtos> Produtos1 { get; set; }
        public virtual ICollection<Usuarios> Usuarios1 { get; set; }
        public virtual Usuarios Usuarios2 { get; set; }
        public virtual ICollection<Usuarios> Usuarios11 { get; set; }
        public virtual Usuarios Usuarios3 { get; set; }
    }
}
