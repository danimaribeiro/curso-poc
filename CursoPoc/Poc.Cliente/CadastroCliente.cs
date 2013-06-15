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
        private List<TextboxObrigatorio> _controlesObrigatorios;
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
            _controlesObrigatorios = new List<TextboxObrigatorio>();
            _controlesObrigatorios.Add(this.txtNome);
            this.txtCpf.Validacao = (x) =>
            {
                return x.Length != 11;
            };
            _controlesObrigatorios.Add(this.txtCpf);

            if (this.Cliente != null)
            {
                txtNome.Text = this.Cliente.Nome;
                txtCpf.Text = this.Cliente.Cpf;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string erros = "Os seguintes campos possuem erros:";

            var listaNova = _controlesObrigatorios.FindAll(x => x.ComErro).ToList();
            _controlesObrigatorios.Exists(x => x == this.txtCpf);

            Dictionary<string, TextboxObrigatorio> dicionario = new Dictionary<string, TextboxObrigatorio>();
            dicionario["nome"] = txtNome;
            dicionario["cpf"] = txtCpf;

            var processo = System.Diagnostics.Process.Start("calc.exe");
            processo.WaitForExit();
            if (processo.ExitCode == 0)
                MessageBox.Show("Fechou o programa");

            var outraLista = (from p in _controlesObrigatorios
                              where p.ComErro == true
                              select p).ToList();

            foreach (var item in listaNova)
            {
                erros += item.MensagemErro + '\n';
            }
            MessageBox.Show(erros);
            this.ObjetoCriado = new Core.Usuarios() { Id = 1 };
            this.Close();
        }


    }
}
