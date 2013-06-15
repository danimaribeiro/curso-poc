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
    public partial class PesquisaCliente : Core.BaseSearch
    {

        public PesquisaCliente()
        {
            InitializeComponent();
        }

        public delegate void Selecionado(long id, Form formulario);      

        public event Selecionado SelecionouObjeto;

        public override void Confirmar(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dynamic cliente = dataGridView1.SelectedRows[0].DataBoundItem;
                SelecionouObjeto((long)cliente.Id, this);                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        #region "Methods"


        private void CarregarDados()
        {
            var clientes = from p in this.ContextoBancoDados.Clientes
                           select new { Id = p.Id, Nome = p.Nome, Cpf = p.Cpf };

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                clientes = clientes.Where(x => x.Nome.StartsWith(textBox1.Text));

            dataGridView1.DataSource = clientes.ToList();
        }

        #endregion
    }
}
