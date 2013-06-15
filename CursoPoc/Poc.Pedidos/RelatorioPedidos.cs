using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poc.Pedidos
{
    public partial class RelatorioPedidos : Core.Base
    {
        public RelatorioPedidos()
        {
            InitializeComponent();
        }

        private void RelatorioPedidos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pocDataSet.Pedidos' table. You can move, or remove it, as needed.
            this.PedidosTableAdapter.Fill(this.pocDataSet.Pedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
