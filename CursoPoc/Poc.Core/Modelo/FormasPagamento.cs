namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormasPagamento
    {
        public FormasPagamento()
        {
            this.Pedidos = new HashSet<Pedidos>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Parcelas { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
    
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
