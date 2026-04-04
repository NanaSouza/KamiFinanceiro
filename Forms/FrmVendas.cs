using Financeiro_teste.Models;
using MySql.Data.MySqlClient;
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
    public partial class FrmVendas : Form
    {
        private DatabaseHelper db;
        private List<ItemVenda> itensVenda;

        public FrmVendas (DatabaseHelper database)
        {          
            db = database;
            itensVenda = new List<ItemVenda>();
            InitializeComponent();
            ConfigurarLayoutManual();
        }

        private void ConfigurarLayoutManual()
        {
            btnAdicionar.Click += btnAdicionar_Click;
            btnFinalizar.Click += btnFinalizar_Click;
            btnCancelar.Click += (s, e) => this.Close();

            gbProdutos.Controls.AddRange(new Control[] { dgvProdutos, lblQuantidade, nudQuantidade, btnAdicionar });
            gbCarrinho.Controls.AddRange(new Control[] { dgvCarrinho, lblFormaPagamento, cbFormaPagamento, lblTotal, btnFinalizar, btnCancelar });
            this.Controls.AddRange(new Control[] { gbProdutos, gbCarrinho });
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            cbFormaPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão Débito", "Cartão Crédito", "Pix" });
            cbFormaPagamento.SelectedIndex = 0;

            //Carregar produtos ao abrir o formulário
            CarregarProdutos();
        }
        public void CarregarProdutos()
        {
            string sql = "SELECT Id, Nome, Preco, Categoria FROM Produtos WHERE Estoque >= 0";
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection("Server=localhost;Database=kamikami;Uid=root;Pwd=;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            dgvProdutos.DataSource = dt;
            dgvProdutos.Columns["Id"].Visible = false;
            dgvProdutos.Columns["Nome"].HeaderText = "Produto";
            dgvProdutos.Columns["Preco"].HeaderText = "Preço";
            dgvProdutos.Columns["Categoria"].HeaderText = "Categoria";
            dgvProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null) return;

            int produtoId = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value);
            string nome = dgvProdutos.CurrentRow.Cells["Nome"].Value.ToString();
            decimal preco = Convert.ToDecimal(dgvProdutos.CurrentRow.Cells["Preco"].Value);
            int quantidade = (int)nudQuantidade.Value;
            var itemExistente = itensVenda.FirstOrDefault(i => i.ProdutoId == produtoId);

            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
                itemExistente.Total = itemExistente.Quantidade * itemExistente.PrecoUnitario;
            }
            else
            {
                itensVenda.Add(new ItemVenda
                {
                    ProdutoId = produtoId,
                    Nome = nome,
                    PrecoUnitario = preco,
                    Quantidade = quantidade,
                    Total = preco * quantidade
                });
            }
            AtualizarCarrinho();
        }

        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = itensVenda.Select(i => new
            {
                Produto = i.Nome,
                i.Quantidade,
                i.PrecoUnitario,
                i.Total
            }).ToList();

            dgvCarrinho.Columns["Produto"].HeaderText = "Produto";
            dgvCarrinho.Columns["PrecoUnitario"].HeaderText = "Preço Unitário";
            dgvCarrinho.Columns["Subtotal"].HeaderText = "Subtotal";
            dgvCarrinho.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2";
            dgvCarrinho.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            decimal total = itensVenda.Sum(i => i.Total);
            lblTotal.Text = $"Total: {total:C2}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (itensVenda.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto ao carrinho.", "Carrinho Vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cbFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.", "Forma de Pagamento", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = itensVenda.Sum(i => i.Total);

            DialogResult result = MessageBox.Show($"Confirmar venda no valor de {total:C2}?", "Confirmar Venda", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SalvarVenda();
            }
        }

        private void SalvarVenda()
        {
            using (var conn = new MySqlConnection("Data Source=restaurante.db;Version=3;"))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                { 
                    try 
                    {
                        decimal total = itensVenda.Sum(i => i.Total);
                        //Inserir Venda
                        string sqlVenda = @"INSERT INTO Vendas (DataHora, Total, FormaPagamento, Status) 
                                            VALUES (@DataHora, @Total, @FormaPagamento, @Status);
                                            SELECT LAST_INSERT_ID();";  
                        int vendaId;
                        using (var cmdVenda = new MySqlCommand(sqlVenda, conn, transaction))
                        {
                            cmdVenda.Parameters.AddWithValue("@DataHora", DateTime.Now);
                            cmdVenda.Parameters.AddWithValue("@Total", total);
                            cmdVenda.Parameters.AddWithValue("@FormaPagamento", cbFormaPagamento.Text);
                            cmdVenda.Parameters.AddWithValue("@Status", "Concluída");
                            vendaId = Convert.ToInt32(cmdVenda.ExecuteScalar());
                        }

                        //Inserir Itens da Venda
                        foreach (var item in itensVenda) 
                        {
                            string sqlItem = @"INSERT INTO ItensVenda (VendaId, ProdutoId, Quantidade, PrecoUnitario)
                                             VALUES (@vendaId, @produtoId, @quantidade, @preco)";
                            using (var cmdItem = new MySqlCommand(sqlItem, conn, transaction))
                            {
                                cmdItem.Parameters.AddWithValue("@VendaId", vendaId);
                                cmdItem.Parameters.AddWithValue("@ProdutoId", item.ProdutoId);
                                cmdItem.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                cmdItem.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                                cmdItem.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Venda realizada com sucesso!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itensVenda.Clear();
                        AtualizarCarrinho();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Erro ao salvar venda: {ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
