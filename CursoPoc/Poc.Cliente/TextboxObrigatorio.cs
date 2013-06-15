using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poc.Cliente
{
    public partial class TextboxObrigatorio : UserControl
    {
        public TextboxObrigatorio()
        {
            InitializeComponent();
        }

        public int Indice { get; set; }

        public string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public bool Requerido { get; set; }

        public string MensagemErro { get; set; }

        public bool ComErro { get; set; }

        public Func<string, bool> Validacao { get; set; }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Validacao != null)
            {
                var erro = Validacao(textBox1.Text);
                if (erro)
                {
                    errorProvider1.SetError(textBox1, this.MensagemErro);
                    this.ComErro = true;
                }
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, this.MensagemErro);
                this.ComErro = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
       {
            if (this.ComErro)
                e.Handled = true;
        }

    }
}
