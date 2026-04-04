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
            ConfigurarLayoutManual();
            CarregarSaldoAtual();
        }
        private void ConfigurarLayoutManual()
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

            //Menu Sair
            ToolStripMenuItem menuSair = new ToolStripMenuItem("Sair");
            menuSair.Click += (s, e) => Application.Exit();

            menuSair.DropDownItems.AddRange(new ToolStripMenuItem[] { menuVendas, menuFinanceiro});

            //Painel de Resumo 

            Panel panelResumo = new Panel();
            {
                Dock = DockStyle.Top;
                Height = 150;
                BackColor = System.Drawing.Color.LightSteelBlue;
            }

            Label lblSaldo = new Label();
            {
                Text = "SALDO ATUAL";
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
                Location = new System.Drawing.Point(20, 20);
                AutoSize = true;
            }

            Label lblValorSaldo = new Label();
            {
                Text = saldoAtual.ToString("C");
                Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold);
                Location = new System.Drawing.Point(20, 60);
                AutoSize = true;
                ForeColor = saldoAtual >= 0 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }

            panelResumo.Controls.AddRange(new Control[] { lblSaldo, lblValorSaldo });
            this.Controls.Add(panelResumo);
        }

        private void CarregarSaldoAtual()
        {
            //Calcular saldo: Total de vendas - Total de despesas
            //Implementar a lógica de Cálculo
            saldoAtual = 0;
        }

        private void NovaVenda_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas(db);
            frmVendas.ShowDialog();
            CarregarSaldoAtual();
        }

        private void HistoricoVendas_Click(object sender, EventArgs e)
        {
            // Implementar Historico de Vendas
            MessageBox.Show("Histórico de Vendas - Em desenvolvimento");
        }

        private void Despesas_Click(object sender, EventArgs e)
        {
            FrmDespesas frmDespesas = new FrmDespesas(db);
            frmDespesas.ShowDialog();
            CarregarSaldoAtual();
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            FrmRelatorios frmRelatorios = new FrmRelatorios(db);
            frmRelatorios.ShowDialog();
        }
    }
}
