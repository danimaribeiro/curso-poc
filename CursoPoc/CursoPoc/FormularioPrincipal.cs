using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoPoc
{
    public partial class FormularioPrincipal : Poc.Core.Base
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (new Login().ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Poc.Cliente.RelatorioClientes().ShowDialog();
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gridClientes = new Poc.Cliente.GridClientes();
            gridClientes.MdiParent = this;
            gridClientes.WindowState = FormWindowState.Maximized;
            gridClientes.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioDinamicamente("Poc.Cliente.CadastroCliente", // Namespace completo
                "Poc.Cliente", // Root Namespace
                "1.0.0.0",
                "neutral",
                "null",
                false);
        }


        private void AbrirFormularioDinamicamente(string classe, string namespace_pai,
                    string versaoAssembly, string cultura, string token, bool modal)
        {
            Type t = Type.GetType(classe + "," + namespace_pai + ", Version=" + versaoAssembly + ", Culture=" + cultura + ", PublicKeyToken=" + token);
            if (t != null)
            {
                var user = new Poc.Core.Clientes() { Nome = "Danimar", Cpf = "05565" };
                Poc.Core.BaseForm f = (Poc.Core.BaseForm)Activator.CreateInstance(t, user, "mensagem");
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                if (modal)
                    f.ShowDialog();
                else
                    f.Show();
            }
        }

        private void relatórioDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Poc.Pedidos.RelatorioPedidos().ShowDialog();
        }

        private void pesquisaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Poc.Cliente.PesquisaCliente();
            form.SelecionouObjeto += new Poc.Cliente.PesquisaCliente.Selecionado(form_SelecionouObjeto);
            form.Show();
        }

        void form_SelecionouObjeto(long id, Form formulario)
        {
            formulario.Close();
            MessageBox.Show(id.ToString());
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Poc.Cliente.NovoFormularioRelatorio().ShowDialog();
        }

    }
}
