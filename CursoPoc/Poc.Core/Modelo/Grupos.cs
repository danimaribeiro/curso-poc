namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupos
    {
        public Grupos()
        {
            this.Produtos = new HashSet<Produtos>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Usuarios Usuarios1 { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }
    }
}
