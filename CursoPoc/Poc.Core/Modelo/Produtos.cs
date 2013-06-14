namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produtos
    {
        public Produtos()
        {
            this.ItensPedido = new HashSet<ItensPedido>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public long GrupoId { get; set; }
        public decimal ValorVenda { get; set; }
        public Nullable<decimal> QuantidadeEstoque { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
    
        public virtual Grupos Grupos { get; set; }
        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual Usuarios Usuarios1 { get; set; }
    }
}
