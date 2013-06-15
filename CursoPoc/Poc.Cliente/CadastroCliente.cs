using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poc.Cliente
{
    public partial class CadastroCliente : Core.BaseForm
    {
        protected Core.Clientes Cliente { get; set; }

        public CadastroCliente()
        {
            InitializeComponent();
        }
         
        public CadastroCliente(Core.Clientes cliente)
        {
            InitializeComponent();
            this.Cliente = cliente;
        }

        public CadastroCliente(Core.Clientes cliente, string mensagem)
        {
            InitializeComponent();
            this.Cliente = cliente;
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            if (this.Cliente != null)
            {
                txtNome.Text = this.Cliente.Nome;
                txtCpf.Text = this.Cliente.Cpf;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ObjetoCriado = new Core.Usuarios() { Id  = 1 };
            this.Close();
        }
    }
}
