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
            InitializaComponent();
        }

        private void InitializaComponent()
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
            string sqlVendas = @"SELECT strftime('%Y-%m-%d', DataHora) as DATA,
            COUNT(*) AS TotalVendas,
            SUM(Total) AS ValorTotal
            FROM Vendas WHERE DataHora 
            BETWEEN @Inicio AND @Fim STATUS = 'Concluida'
            GROUP BY strftime('%Y-%m-%d', DataHora)
            ORDER BY Data DESC";

            DataTable dtVendas = new DataTable();
            using (var conn = new MySqlConnection("Data Source=restaurante.db;Version=3;"))
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
            string sqlDespesas = @"SELECT strftime('%Y-%m-%d', Data) as Data,
            Categoria,
            SUM(Valor) as TotalDespesa
            FROM Despesas
            WHERE Data BETWEEN @inicio AND @fim
            GROUP BY strftime('%Y-%m-%d', Data),
            Categoria
            ORDER BY Data DESC";

            DataTable dtDespesas = new DataTable();
            using (var conn = new MySqlConnection("Data Source=restaurante.db;Version=3;"))
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
        }
    }
}