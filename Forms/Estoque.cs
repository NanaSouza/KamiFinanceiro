using Financeiro_teste.Models;
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
    public partial class Estoque : Form
    {
        BindingList<Produtos> listaProdutos = new BindingList<Produtos>();

        public Estoque()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        //TABELINHA DE TESTE PARA VER SE O PRODUTO ESTÁ SENDO ADICIONADO A LISTA
        private void ConfigurarDataGridView()
        {
            dgvEstoque.AutoGenerateColumns = true;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.MultiSelect = false;
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;

            dgvEstoque.DataSource = listaProdutos;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            /*CarregarProdutosIniciais(); ver o que isso faz depois*/
        }

        private void ConfigurarGrid()
        {
            dgvEstoque.Columns["Id"].HeaderText = "ID";
            dgvEstoque.Columns["Nome"].HeaderText = "Nome";
            dgvEstoque.Columns["Preco"].HeaderText = "Preço";
            dgvEstoque.Columns["Categoria"].HeaderText = "Categoria";
            dgvEstoque.Columns["Estoque"].HeaderText = "Estoque";
        }

        //CONFIGURAÇÕES DO BOTÃO DE ADICIONAR, CHECA SE OS ITENS ESTÃO OK E ADICIONA O PRODUTO NA LISTA. APÓS ADD, LIMPA OS CAMPOS // ID É GERADO AUTOMATICAMENTE.
        private void btnAdcProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text) ||
                string.IsNullOrWhiteSpace(txtQtdProduto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecoProd.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            if (!int.TryParse(txtQtdProduto.Text, out int quantidade))
            {
                MessageBox.Show("Digite uma quantidade válida.");
                txtQtdProduto.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrecoProd.Text, out decimal preco))
            {
                MessageBox.Show("Digite um preço válido.");
                txtPrecoProd.Focus();
                return;
            }
            Produtos p = new Produtos
            {
                Id = listaProdutos.Count + 1,
                Nome = txtProduto.Text,
                Preco = preco,
                /*Categoria = cmbCategoria.SelectedIndex, //Ajuste conforme necessário*/
                Estoque = quantidade
            };

            listaProdutos.Add(p);

            LimparCampos();
            txtCodProduto.Text = GerarCodigoAutomatico();
            dgvEstoque.ClearSelection();
            dgvEstoque.CurrentCell = null;
        }
        private string GerarCodigoAutomatico() // Habilita a função de gerar o código automatico do produto
        {
            int proximoId = listaProdutos.Count + 1;
            return proximoId.ToString("D3");
        }
        private void LimparCampos() //Habilita a função de limpar os campos após adicionar um produto
        {
            txtProduto.Clear();
            txtQtdProduto.Clear();
            txtPrecoProd.Clear();
            txtProduto.Focus();
        }
        //CONFIGURAÇÕES DO BOTÃO REMOVER, PEDE CONFIRMAÇÃO ANTES DA EXCLUSÃO TBM!
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para remover.");
                return;
            }
            Produtos produtoSelecionado =
                dgvEstoque.CurrentRow.DataBoundItem as Produtos;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione uma linha válida.");
                return;
            }
            DialogResult resultado = MessageBox.Show(
                $"Deseja remover este item: {produtoSelecionado.Nome}?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (resultado == DialogResult.Yes)
            {
                listaProdutos.Remove(produtoSelecionado);
                LimparCampos();
                dgvEstoque.ClearSelection();
                dgvEstoque.CurrentCell = null;
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Produtos produtoSelecionado =
                    dgvEstoque.Rows[e.RowIndex].DataBoundItem as Produtos;
                if (produtoSelecionado != null)
                {
                    txtProduto.Text = produtoSelecionado.Nome;
                    txtCodProduto.Text = produtoSelecionado.Id.ToString();
                    txtQtdProduto.Text = produtoSelecionado.Estoque.ToString();
                    txtPrecoProd.Text = produtoSelecionado.Preco.ToString();
                }
            }
        }
        //CONFIGURAÇÕES DO BOÃO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }
            Produtos produtoSelecionado =
                dgvEstoque.CurrentRow.DataBoundItem as Produtos;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione uma linha válida.");
                return;
            }
            if (!int.TryParse(txtQtdProduto.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }
            if (!decimal.TryParse(txtPrecoProd.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            produtoSelecionado.Nome = txtProduto.Text;
            /*produtoSelecionado.Id = txtCodProduto.Text;//AJUSTAR SE ESTA O ID OU O CODIGO*/
            produtoSelecionado.Estoque = quantidade;
            produtoSelecionado.Preco = preco;

            dgvEstoque.Refresh();
            LimparCampos();
            dgvEstoque.ClearSelection();
            dgvEstoque.CurrentCell = null;
            MessageBox.Show("Produto atualizado com sucesso.");
        }

        //CONFIGURAÇÕES DO BOTÃO PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtBuscarProd.Text.ToLower();
            foreach (DataGridView row in dgvEstoque.Rows)
            {
                Produtos produto =
                    row.DataBoundItem as Produtos;
                if (produto != null)
                {
                    if (produto.Nome.ToLower().Contains(termo)) ||
                        produto.Id.ToLower().Contains(termo))
                    {
                        row.Selected = true;
                        dgvEstoque.CurrentCell = row.CellStateChanged[0];
                        txtBuscarProd.Clear();
                        return;
                    }
                }
            }
            MessageBox.Show("Produto não encontrado.");
            
        }
        //FUNÇÃO PARA DAR BAIXA NO ESTOQUE APÓS A VENDA DE UM PRODUTO.
        public void DarBaixaNoEstoque(string codigoProduto, int quantidadeVendida)
        {
            Produtos produto = listaProdutos.FirstOrDefault(p => p.Codigo == codigoProduto);
            if (produto != null)
            {
                produto.Quantidade -= quantidadeVendida;
                if (produto.Quantidade < 0)
                    produto.Quantidade = 0;
                dgvEstoque.Refresh();
            }
        }
    }
}
