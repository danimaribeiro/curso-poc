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
    public partial class NovoFormularioRelatorio : Form
    {
        public NovoFormularioRelatorio()
        {
            InitializeComponent();
        }

        private void NovoFormularioRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pocDataSet.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.pocDataSet.Clientes);

        

            this.reportViewer1.RefreshReport();
        }
    }
}
