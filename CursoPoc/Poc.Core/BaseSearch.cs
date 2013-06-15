using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poc.Core
{
    public partial class BaseSearch : Base
    {
        public BaseSearch()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Confirmar(sender, e);
        }

        public virtual void Confirmar(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiu");
        }

    }
}
