namespace Financeiro_teste.Forms
{
    partial class FrmDespesas
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            dgvDespesas = new DataGridView();
            cbFormaPagamento = new ComboBox();
            dtpData = new DateTimePicker();
            txtDescricao = new TextBox();
            cbCategoria = new ComboBox();
            nudValor = new NumericUpDown();
            bgCadastro = new GroupBox();
            lblCategoria = new Label();
            lblData = new Label();
            lblValor = new Label();
            lblDescricao = new Label();
            lblFormaPagamento = new Label();
            gbListagem = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDespesas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            bgCadastro.SuspendLayout();
            gbListagem.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(6, 247);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 52);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(138, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 52);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvDespesas
            // 
            dgvDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDespesas.Location = new Point(6, 22);
            dgvDespesas.Name = "dgvDespesas";
            dgvDespesas.Size = new Size(287, 287);
            dgvDespesas.TabIndex = 2;
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Location = new Point(6, 174);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(135, 23);
            cbFormaPagamento.TabIndex = 3;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(6, 43);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(193, 23);
            dtpData.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(6, 218);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(135, 23);
            txtDescricao.TabIndex = 5;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(6, 86);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(135, 23);
            cbCategoria.TabIndex = 6;
            // 
            // nudValor
            // 
            nudValor.Location = new Point(6, 130);
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(87, 23);
            nudValor.TabIndex = 7;
            // 
            // bgCadastro
            // 
            bgCadastro.Controls.Add(lblFormaPagamento);
            bgCadastro.Controls.Add(lblDescricao);
            bgCadastro.Controls.Add(lblValor);
            bgCadastro.Controls.Add(lblCategoria);
            bgCadastro.Controls.Add(lblData);
            bgCadastro.Controls.Add(nudValor);
            bgCadastro.Controls.Add(dtpData);
            bgCadastro.Controls.Add(cbFormaPagamento);
            bgCadastro.Controls.Add(cbCategoria);
            bgCadastro.Controls.Add(btnCancelar);
            bgCadastro.Controls.Add(txtDescricao);
            bgCadastro.Controls.Add(btnSalvar);
            bgCadastro.Location = new Point(12, 5);
            bgCadastro.Name = "bgCadastro";
            bgCadastro.Size = new Size(217, 309);
            bgCadastro.TabIndex = 8;
            bgCadastro.TabStop = false;
            bgCadastro.Text = "Nova Despesa";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(6, 68);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Catagoria";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(6, 25);
            lblData.Name = "lblData";
            lblData.Size = new Size(37, 15);
            lblData.TabIndex = 8;
            lblData.Text = "Data: ";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(6, 112);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 10;
            lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(6, 200);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 11;
            lblDescricao.Text = "Descrição";
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Location = new Point(6, 156);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(105, 15);
            lblFormaPagamento.TabIndex = 12;
            lblFormaPagamento.Text = "Forma Pagamento";
            // 
            // gbListagem
            // 
            gbListagem.Controls.Add(dgvDespesas);
            gbListagem.Location = new Point(235, 5);
            gbListagem.Name = "gbListagem";
            gbListagem.Size = new Size(299, 461);
            gbListagem.TabIndex = 9;
            gbListagem.TabStop = false;
            gbListagem.Text = "Despesas Registradas";
            // 
            // FrmDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 478);
            Controls.Add(gbListagem);
            Controls.Add(bgCadastro);
            Name = "FrmDespesas";
            Text = "FrmDespesas";
            ((System.ComponentModel.ISupportInitialize)dgvDespesas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            bgCadastro.ResumeLayout(false);
            bgCadastro.PerformLayout();
            gbListagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private DataGridView dgvDespesas;
        private ComboBox cbFormaPagamento;
        private DateTimePicker dtpData;
        private TextBox txtDescricao;
        private ComboBox cbCategoria;
        private NumericUpDown nudValor;
        private GroupBox bgCadastro;
        private Label lblCategoria;
        private Label lblData;
        private Label lblFormaPagamento;
        private Label lblDescricao;
        private Label lblValor;
        private GroupBox gbListagem;
    }
}