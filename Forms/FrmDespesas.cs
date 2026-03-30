using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financeiro_teste.DataBase;

namespace Financeiro_teste.Forms
{
    public partial class FrmDespesas : Form
    {
        private DatabaseHelper db;
        public FrmDespesas (DatabaseHelper database)
        {
            db = database;
            InitializeComponent();
            CarregarDespesas();
        }

        private void initializaComponent()
        {
            this.Text = "Registrar Despesas - KamiKami";
        }
    }
}
