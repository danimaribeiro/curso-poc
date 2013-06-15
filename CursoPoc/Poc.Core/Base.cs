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
    public partial class Base : Form
    {
        protected Contexto.DatabaseContexto ContextoBancoDados { get; set; }


        private Core.Usuarios _usuario;

        protected Core.Usuarios Usuario
        {
            get { return _usuario; }            
        }
                
        public Base()
        {
            InitializeComponent();
            ContextoBancoDados = new Contexto.DatabaseContexto();
        }

        protected void UsuarioLogado(Core.Usuarios usuario)
        {
            _usuario = usuario;
        }
    }
}
