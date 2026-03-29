namespace Financeiro_teste.Forms
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionar = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            dgvProdutos = new DataGridView();
            dgvCarrinho = new DataGridView();
            lblTotal = new Label();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            gbProdutos = new GroupBox();
            gbCarrinho = new GroupBox();
            cbFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            gbProdutos.SuspendLayout();
            gbCarrinho.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(182, 577);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 45);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(10, 577);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 45);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(319, 577);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(6, 22);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(410, 504);
            dgvProdutos.TabIndex = 3;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(6, 23);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.Size = new Size(414, 503);
            dgvCarrinho.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(10, 529);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(8, 550);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(83, 545);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 7;
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(dgvProdutos);
            gbProdutos.Controls.Add(nudQuantidade);
            gbProdutos.Controls.Add(lblQuantidade);
            gbProdutos.Controls.Add(btnAdicionar);
            gbProdutos.Location = new Point(4, 12);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(426, 628);
            gbProdutos.TabIndex = 8;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Produtos Disponíveis";
            // 
            // gbCarrinho
            // 
            gbCarrinho.Controls.Add(cbFormaPagamento);
            gbCarrinho.Controls.Add(lblTotal);
            gbCarrinho.Controls.Add(btnCancelar);
            gbCarrinho.Controls.Add(lblFormaPagamento);
            gbCarrinho.Controls.Add(dgvCarrinho);
            gbCarrinho.Controls.Add(btnFinalizar);
            gbCarrinho.Location = new Point(436, 12);
            gbCarrinho.Name = "gbCarrinho";
            gbCarrinho.Size = new Size(426, 628);
            gbCarrinho.TabIndex = 9;
            gbCarrinho.TabStop = false;
            gbCarrinho.Text = "Carrinho de Compras";
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Location = new Point(142, 550);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(121, 23);
            cbFormaPagamento.TabIndex = 6;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Location = new Point(139, 529);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(124, 15);
            lblFormaPagamento.TabIndex = 5;
            lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 646);
            Controls.Add(gbCarrinho);
            Controls.Add(gbProdutos);
            Name = "FrmVendas";
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            gbCarrinho.ResumeLayout(false);
            gbCarrinho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
        private Button btnFinalizar;
        private Button btnCancelar;
        private DataGridView dgvProdutos;
        private DataGridView dgvCarrinho;
        private Label lblTotal;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private GroupBox gbProdutos;
        private GroupBox gbCarrinho;
        private Label lblFormaPagamento;
        private ComboBox cbFormaPagamento;
    }
}