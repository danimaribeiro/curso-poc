namespace Poc.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public Clientes()
        {
            this.Pedidos = new HashSet<Pedidos>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Nullable<System.DateTime> DataNascimento { get; set; }
        public System.DateTime DataCriacao { get; set; }
        public Nullable<System.DateTime> UltimaAtualizacao { get; set; }
        public long CriadoPor { get; set; }
        public Nullable<long> AtualizadoPor { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Usuarios Usuarios1 { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
