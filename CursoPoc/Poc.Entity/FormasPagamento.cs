//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poc.Entity
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