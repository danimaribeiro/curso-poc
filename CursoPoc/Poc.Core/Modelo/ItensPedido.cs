namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItensPedido
    {
        public long Id { get; set; }
        public int Indice { get; set; }
        public long ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorBrutoUnitario { get; set; }
        public decimal DescontoUnitario { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal DescontoFinal { get; set; }
        public decimal ValorFinal { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
        public Nullable<long> PedidoId { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
        public virtual Produtos Produtos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual Usuarios Usuarios1 { get; set; }
    }
}
