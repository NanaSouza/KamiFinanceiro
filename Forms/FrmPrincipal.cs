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
            CarregarSaldoAtual();
        }
        private void InitializaComponent()
        {
            this.Text = "Sistema Financeiro - KamiKami";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Menu Principal   
            MenuStrip menuStrip = new MenuStrip();

            //Menu Vendas
            ToolStripMenuItem menuVendas = new ToolStripMenuItem("Vendas");

            ToolStripMenuItem novaVenda = new ToolStripMenuItem("Nova Venda");

            ToolStripMenuItem historicoVendas = new ToolStripMenuItem("Histórico de Vendas");

            novaVenda.Click += NovaVenda_Click;

            historicoVendas.Click += HistoricoVendas_Click;

            menuVendas.DropDownItems.AddRange(new ToolStripMenuItem[] { novaVenda, historicoVendas });

            //Menu Financeiro

            ToolStripMenuItem menuFinanceiro = new ToolStripMenuItem("Financeiro");

            ToolStripMenuItem despesas = new ToolStripMenuItem("Registrar Despesas");

            ToolStripMenuItem relatorios = new ToolStripMenuItem("Relatórios");

            despesas.Click += Despesas_Click;

            relatorios.Click += Relatorios_Click;

            menuFinanceiro.DropDownItems.AddRange(new ToolStripMenuItem[] { despesas, relatorios });
        }
    }
}
