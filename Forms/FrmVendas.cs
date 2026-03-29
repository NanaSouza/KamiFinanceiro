using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Financeiro_teste.DataBase;

namespace Financeiro_teste.Forms
{
    public partial class FrmVendas : Form
    {
        private DatabaseHelper db;
        private List<ItemVenda> itemsVenda;
        //private DataGridView dgvProdutos;
        //private DataGridView dgvCarrinho;
        //private NumericUpDown nudQuantidade;
        //private ComboBox cbFormaPagamento;
        //private Label lblTotal;
        //private Button btnAdicionar;
        //private Button btnFinalizar;
        //private Button btnCancelar;


        public FrmVendas(DataBaseHelper dataBase)
        {
            db = dataBase;
            itemsVenda = new List<ItemVenda>();
            InitializeComponent();
            CarregarProdutos();
        }

        private void InitializeComponent()
        {
            gbProdutos = new GroupBox();
            btnAdicionar = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            dgvProdutos = new DataGridView();
            dgvCarrinho = new DataGridView();
            nudQuantidade = new NumericUpDown();
            cbFormaPagamento = new ComboBox();
            lblTotal = new Label();
            ((ISupportInitialize)dgvProdutos).BeginInit();
            ((ISupportInitialize)dgvCarrinho).BeginInit();
            ((ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // gbProdutos
            // 
            gbProdutos.Location = new Point(0, 0);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(200, 100);
            gbProdutos.TabIndex = 0;
            gbProdutos.TabStop = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(115, 550);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(275, 550);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(430, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(7, 2);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(634, 150);
            dgvProdutos.TabIndex = 3;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(7, 158);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(634, 150);
            dgvCarrinho.TabIndex = 4;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(7, 435);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 5;
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Location = new Point(7, 406);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(121, 23);
            cbFormaPagamento.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // FrmVendas
            // 
            ClientSize = new Size(653, 585);
            Controls.Add(lblTotal);
            Controls.Add(cbFormaPagamento);
            Controls.Add(nudQuantidade);
            Controls.Add(dgvCarrinho);
            Controls.Add(dgvProdutos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAdicionar);
            Location = new Point(10, 20);
            Name = "FrmVendas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produtos Disponíveis";
            ((ISupportInitialize)dgvProdutos).EndInit();
            ((ISupportInitialize)dgvCarrinho).EndInit();
            ((ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();










        }
    }
}
