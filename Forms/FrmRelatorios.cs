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

namespace Financeiro_teste.Forms
{
    public partial class FrmRelatorios : Form
    {
        private DatabaseHelper db;
        public FrmRelatorios(DatabaseHelper database)
        {
            db = database;
            InitializeComponent();
            ConfigurarLayoutManual();
        }

        private void ConfigurarLayoutManual()
        {
            this.Text = "Relatórios - KamiKami";
            btnGerar.Click += btnGerar_Click;
            panelFiltros.Controls.AddRange(new Control[] { lblInicio, dtpInicio, lblFim, dtpFim, btnGerar });
            panelResumo.Controls.AddRange(new Control[] { lblTotalVendas, lblTotalDespesas, lblLucro });
            this.Controls.AddRange(new Control[] { panelFiltros, panelResumo });
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fim = dtpFim.Value.Date.AddDays(1).AddSeconds(-1); // Incluir o dia inteiro

            //Gerar Relatório de Vendas
            string sqlVendas = @"SELECT DATE_FORMAT(DataHora, '%Y-%m-%d') as DATA, 
                    COUNT(*) AS TotalVendas, 
                    SUM(Total) AS ValorTotal 
                    FROM Vendas 
                    WHERE DataHora BETWEEN @inicio AND @fim 
                    AND STATUS = 'Concluída' 
                    GROUP BY DATA 
                    ORDER BY DATA DESC;";   

            DataTable dtVendas = new DataTable();
            using (var conn = new MySqlConnection("Server=localhost;Database=kamikami;Uid=root;Pwd=;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sqlVendas, conn))
                {
                    cmd.Parameters.AddWithValue("@Inicio", inicio);
                    cmd.Parameters.AddWithValue("@Fim", fim);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtVendas);
                    }
                }
            }
            //Gerar Relatório de Despesas
            string sqlDespesas = @"SELECT DATE_FORMAT('%Y-%m-%d', Data) as Data,
            Categoria,
            SUM(Valor) as TotalDespesa
            FROM Despesas
            WHERE Data BETWEEN @inicio AND @fim
            GROUP BY DATE_FORMAT('%Y-%m-%d', Data),
            Categoria
            ORDER BY Data DESC";

            DataTable dtDespesas = new DataTable();
            using (var conn = new MySqlConnection("Server=localhost;Database=kamikami;Uid=root;Pwd=;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sqlDespesas, conn))
                {
                    cmd.Parameters.AddWithValue("@Inicio", inicio);
                    cmd.Parameters.AddWithValue("@Fim", fim);
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtDespesas);
                    }
                }
            }
            // Totalizador 
            decimal totalVendas = 0;
            foreach (DataRow row in dtVendas.Rows)
            {
                totalVendas += Convert.ToDecimal(row["ValorTotal"]);
            }
            decimal totalDespesas = 0;
            foreach (DataRow row in dtDespesas.Rows)
            {
                totalDespesas += Convert.ToDecimal(row["TotalDespesa"]);
            }
            decimal lucro = totalVendas - totalDespesas;

            lblTotalVendas.Text = $"Total Vendas: {totalVendas:C}";
            lblTotalDespesas.Text = $"Total Despesas: {totalDespesas:C}";
            lblLucro.Text = $"Lucro: {lucro:C}";
            lblLucro.ForeColor = lucro >= 0 ? Color.Green : Color.Red;

            //Mostrar Relatorio Combinado
            DataTable dtRelatorio = new DataTable();
            dtRelatorio.Columns.Add("Data");
            dtRelatorio.Columns.Add("Tipo");
            dtRelatorio.Columns.Add("Descrição");
            dtRelatorio.Columns.Add("Valor", typeof(decimal));

            foreach (DataRow row in dtVendas.Rows)
            {
                dtRelatorio.Rows.Add(row["DATA"], "Venda", $"Total: {row["ValorTotal"]}", Convert.ToDecimal(row["ValorTotal"]));
            }
            foreach (DataRow row in dtDespesas.Rows)
            {
                dtRelatorio.Rows.Add(row["Data"], "Despesa", row["Categoria"], Convert.ToDecimal(row["TotalDespesa"]));
            }

            dgvRelatorio.DataSource = dtRelatorio;
            dgvRelatorio.Columns["Valor"].DefaultCellStyle.Format = "C";
            dgvRelatorio.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}