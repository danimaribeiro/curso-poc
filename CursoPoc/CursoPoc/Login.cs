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
    public partial class Login : Poc.Core.Base
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          var usuario =   this.ContextoBancoDados.Usuarios.Where(x => x.Usuario == txtUsername.Text && x.Senha == txtSenha.Text).SingleOrDefault();
          if (usuario != null)
          {
              this.UsuarioLogado(usuario);
              this.DialogResult = System.Windows.Forms.DialogResult.OK;
          }
          else
              MessageBox.Show("Usuário e senha inválidos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        
    }
}
