using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro_teste.Forms
{
    public partial class FrmPrincipal : Form
    {
        private DatabaseHelper db;
        private decimal saldoAtual = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }
    }
}
