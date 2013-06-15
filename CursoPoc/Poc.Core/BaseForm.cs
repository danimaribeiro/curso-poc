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
    public partial class BaseForm : Base
    {
        public object ObjetoCriado { get; set; }

        public BaseForm()
        {
            InitializeComponent();
        }


    }
}
