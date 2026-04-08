namespace Financeiro_teste.Forms
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            menuStrip1 = new MenuStrip();
            lOJAToolStripMenuItem = new ToolStripMenuItem();
            criarPedidoToolStripMenuItem = new ToolStripMenuItem();
            pedidoEmAndamentoToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            uSUÁRIOToolStripMenuItem = new ToolStripMenuItem();
            gerenciamentoDeFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            resetDeSenhaToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEditar = new Button();
            txtPrecoProd = new TextBox();
            txtQtdProduto = new TextBox();
            txtCodProduto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProduto = new TextBox();
            btnAdcProduto = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            txtBuscarProd = new TextBox();
            btnPesquisar = new Button();
            tlpTabela = new TableLayoutPanel();
            btnRemover = new Button();
            dgvEstoque = new DataGridView();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tlpTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lOJAToolStripMenuItem, uSUÁRIOToolStripMenuItem, sAIRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lOJAToolStripMenuItem
            // 
            lOJAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarPedidoToolStripMenuItem, pedidoEmAndamentoToolStripMenuItem, estoqueToolStripMenuItem, financeiroToolStripMenuItem });
            lOJAToolStripMenuItem.Name = "lOJAToolStripMenuItem";
            lOJAToolStripMenuItem.Size = new Size(46, 20);
            lOJAToolStripMenuItem.Text = "LOJA";
            // 
            // criarPedidoToolStripMenuItem
            // 
            criarPedidoToolStripMenuItem.Name = "criarPedidoToolStripMenuItem";
            criarPedidoToolStripMenuItem.Size = new Size(197, 22);
            criarPedidoToolStripMenuItem.Text = "Criar Pedido";
            // 
            // pedidoEmAndamentoToolStripMenuItem
            // 
            pedidoEmAndamentoToolStripMenuItem.Name = "pedidoEmAndamentoToolStripMenuItem";
            pedidoEmAndamentoToolStripMenuItem.Size = new Size(197, 22);
            pedidoEmAndamentoToolStripMenuItem.Text = "Pedido em Andamento";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(197, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(197, 22);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            uSUÁRIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciamentoDeFuncionáriosToolStripMenuItem, resetDeSenhaToolStripMenuItem });
            uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            uSUÁRIOToolStripMenuItem.Size = new Size(68, 20);
            uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // gerenciamentoDeFuncionáriosToolStripMenuItem
            // 
            gerenciamentoDeFuncionáriosToolStripMenuItem.Name = "gerenciamentoDeFuncionáriosToolStripMenuItem";
            gerenciamentoDeFuncionáriosToolStripMenuItem.Size = new Size(242, 22);
            gerenciamentoDeFuncionáriosToolStripMenuItem.Text = "Gerenciamento de Funcionários";
            // 
            // resetDeSenhaToolStripMenuItem
            // 
            resetDeSenhaToolStripMenuItem.Name = "resetDeSenhaToolStripMenuItem";
            resetDeSenhaToolStripMenuItem.Size = new Size(242, 22);
            resetDeSenhaToolStripMenuItem.Text = "Reset de Senha";
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(43, 20);
            sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 1);
            tableLayoutPanel1.Controls.Add(tlpTabela, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(1184, 737);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnEditar, 0, 9);
            tableLayoutPanel2.Controls.Add(txtPrecoProd, 0, 7);
            tableLayoutPanel2.Controls.Add(txtQtdProduto, 0, 5);
            tableLayoutPanel2.Controls.Add(txtCodProduto, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(txtProduto, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAdcProduto, 0, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 115);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.Size = new Size(576, 609);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(3, 269);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Dock = DockStyle.Fill;
            txtPrecoProd.Location = new Point(3, 193);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(570, 23);
            txtPrecoProd.TabIndex = 7;
            // 
            // txtQtdProduto
            // 
            txtQtdProduto.Dock = DockStyle.Fill;
            txtQtdProduto.Location = new Point(3, 137);
            txtQtdProduto.Name = "txtQtdProduto";
            txtQtdProduto.Size = new Size(570, 23);
            txtQtdProduto.TabIndex = 6;
            // 
            // txtCodProduto
            // 
            txtCodProduto.Dock = DockStyle.Fill;
            txtCodProduto.Location = new Point(3, 81);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(570, 23);
            txtCodProduto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Código do produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 112);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 168);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // txtProduto
            // 
            txtProduto.Dock = DockStyle.Fill;
            txtProduto.Location = new Point(3, 25);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(570, 23);
            txtProduto.TabIndex = 4;
            // 
            // btnAdcProduto
            // 
            btnAdcProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdcProduto.Location = new Point(3, 227);
            btnAdcProduto.Name = "btnAdcProduto";
            btnAdcProduto.Size = new Size(93, 30);
            btnAdcProduto.TabIndex = 8;
            btnAdcProduto.Text = "ADICIONAR";
            btnAdcProduto.UseVisualStyleBackColor = true;
            btnAdcProduto.Click += btnAdcProduto_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(txtBuscarProd, 1, 1);
            tableLayoutPanel3.Controls.Add(btnPesquisar, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(595, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel3.Size = new Size(576, 69);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 1;
            label5.Text = "Pesquisar:";
            // 
            // txtBuscarProd
            // 
            txtBuscarProd.Dock = DockStyle.Fill;
            txtBuscarProd.Location = new Point(93, 31);
            txtBuscarProd.Name = "txtBuscarProd";
            txtBuscarProd.Size = new Size(370, 23);
            txtBuscarProd.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(469, 31);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(93, 30);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tlpTabela
            // 
            tlpTabela.ColumnCount = 1;
            tlpTabela.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabela.Controls.Add(btnRemover, 0, 1);
            tlpTabela.Controls.Add(dgvEstoque, 0, 0);
            tlpTabela.Dock = DockStyle.Fill;
            tlpTabela.Location = new Point(595, 115);
            tlpTabela.Name = "tlpTabela";
            tlpTabela.RowCount = 2;
            tlpTabela.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabela.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpTabela.Size = new Size(576, 609);
            tlpTabela.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(480, 562);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(93, 30);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Dock = DockStyle.Fill;
            dgvEstoque.Location = new Point(3, 3);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(570, 553);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellClick += dgvEstoque_CellClick;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tlpTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lOJAToolStripMenuItem;
        private ToolStripMenuItem criarPedidoToolStripMenuItem;
        private ToolStripMenuItem pedidoEmAndamentoToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoDeFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem resetDeSenhaToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tlpTabela;
        private DataGridView dgvEstoque;
        private TextBox txtPrecoProd;
        private TextBox txtQtdProduto;
        private TextBox txtCodProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProduto;
        private Label label5;
        private Button btnEditar;
        private Button btnAdcProduto;
        private TextBox txtBuscarProd;
        private Button btnPesquisar;
        private Button btnRemover;
    }
}