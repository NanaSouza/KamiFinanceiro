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
        public FrmDespesas(DatabaseHelper database)
        {
            db = database;
            InitializeComponent();
            CarregarDespesas();
        }

        private void initializeComponent()
        {
            this.Text = "Registrar Despesas - KamiKami";
            gbCadastro.Controls.AddRange(new Control[] { lblData, dtpData, lblCategoria, cbCategoria, lblDescricao, txtDescricao, lblValor, nudValor, lblFormaPagamento, cbFormaPagamento, btnSalvar, btnCancelar });
            gbListagem.Controls.Add(dgvDespesas);
            this.Controls.AddRange(new Control[] { gbCadastro, gbListagem });

        }

        private void FrmDespesas_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.AddRange(new string[] { "Alimentos", "Energia Elétrica", "Contas de Serviços", "Água", "Aluguel", "Salários", "Manutenção", "Outros" });
            cbCategoria.SelectedIndex = 0;
            cbFormaPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão Débito", "Cartão Crédito", "Pix" });
            cbFormaPagamento.SelectedIndex = 0;
        }
        private void CarregarDespesas()
        {
            string sql = "SELECT Id, Descricao, Valor, Categoria, FormaPagamento, Data FROM Despesas ORDER BY Data DESC";
            DataTable dt = new DataTable();

            using (var conn = new MySqlConnection("Data Source=restaurante.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            dgvDespesas.DataSource = dt;
            dgvDespesas.Columns["Id"].Visible = false;
            dgvDespesas.Columns["Data"].HeaderText = "Data";
            dgvDespesas.Columns["Categoria"].HeaderText = "Categoria";
            dgvDespesas.Columns["Descricao"].HeaderText = "Descrição";
            dgvDespesas.Columns["Valor"].HeaderText = "Valor";
            dgvDespesas.Columns["FormaPagamento"].HeaderText = "Pagamento";
            dgvDespesas.Columns["Valor"].DefaultCellStyle.Format = "C2";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudValor.Value <= 0)
            {
                MessageBox.Show("O valor da despesa deve ser maior que zero.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = @"INSERT INTO Despesas (Data, Categoria, Descricao, Valor, FormaPagamento)
                           VALUES (@Data, @Categoria, @Descricao, @Valor, @Pagamento)";    

            using (var conn = new MySqlConnection("Data Source=restaurante.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Data", dtpData.Value);
                    cmd.Parameters.AddWithValue("@Categoria", cbCategoria.Text);
                    cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@Valor", nudValor.Value);
                    cmd.Parameters.AddWithValue("@Pagamento", cbFormaPagamento.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Despesa registrada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Limpar Formulario
            txtDescricao.Clear();
            nudValor.Value = 0;
            cbCategoria.SelectedIndex = -1;
            cbFormaPagamento.SelectedIndex = -1;

            CarregarDespesas();
        }
    }
}
