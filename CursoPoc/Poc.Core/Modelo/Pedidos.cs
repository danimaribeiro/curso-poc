namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedidos
    {
        public Pedidos()
        {
            this.ItensPedido = new HashSet<ItensPedido>();
        }
    
        public long Id { get; set; }
        public System.DateTime DataPedido { get; set; }
        public long FormaPagamentoId { get; set; }
        public long ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public long Numero { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual FormasPagamento FormasPagamento { get; set; }
        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual Usuarios Usuarios1 { get; set; }
    }
}
