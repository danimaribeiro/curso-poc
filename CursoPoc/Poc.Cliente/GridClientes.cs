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
    public partial class GridClientes : Core.Base
    {
        public GridClientes()
        {
            InitializeComponent();
        }

        private void GridClientes_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                var clientes = from p in this.ContextoBancoDados.Clientes
                               select new { Id = p.Id, Nome = p.Nome, DataNascimento = p.DataNascimento, Endereco = p.Endereco };

                if (!string.IsNullOrWhiteSpace(txtNome.Text))
                    clientes = clientes.Where(x => x.Nome.StartsWith(txtNome.Text));

                clientes = clientes.OrderBy(x => x.Nome).Take(2).Skip(0);

                var listaclientes = clientes.ToList();
                dataGridView1.BeginInvoke(new Action(() =>
                {
                    dataGridView1.DataSource = listaclientes;
                }));
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dynamic cliente = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var clienteCompleto = this.ContextoBancoDados.Clientes.Find(cliente.Id);
                var cadastro = new CadastroCliente(clienteCompleto);
                cadastro.MdiParent = this.MdiParent;
                cadastro.Show();
            }
        }

    }
}
