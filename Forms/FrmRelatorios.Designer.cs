namespace Financeiro_teste.Forms
{
    partial class FrmRelatorios
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
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            btnGerar = new Button();
            dgvRelatorio = new DataGridView();
            lblTotalVendas = new Label();
            lblTotalDespesas = new Label();
            lblLucro = new Label();
            lblInicio = new Label();
            lblFim = new Label();
            panelFiltros = new Panel();
            panelResumo = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panelFiltros.SuspendLayout();
            panelResumo.SuspendLayout();
            SuspendLayout();
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(49, 10);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(172, 23);
            dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            dtpFim.Location = new Point(315, 10);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(166, 23);
            dtpFim.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(343, 354);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(138, 46);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar relatorio";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Location = new Point(3, 39);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.Size = new Size(489, 282);
            dgvRelatorio.TabIndex = 3;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Location = new Point(12, 79);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(73, 15);
            lblTotalVendas.TabIndex = 4;
            lblTotalVendas.Text = "Total Vendas";
            // 
            // lblTotalDespesas
            // 
            lblTotalDespesas.AutoSize = true;
            lblTotalDespesas.Location = new Point(12, 17);
            lblTotalDespesas.Name = "lblTotalDespesas";
            lblTotalDespesas.Size = new Size(84, 15);
            lblTotalDespesas.TabIndex = 5;
            lblTotalDespesas.Text = "Total Despesas";
            // 
            // lblLucro
            // 
            lblLucro.AutoSize = true;
            lblLucro.Location = new Point(12, 45);
            lblLucro.Name = "lblLucro";
            lblLucro.Size = new Size(37, 15);
            lblLucro.TabIndex = 6;
            lblLucro.Text = "Lucro";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(7, 16);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(36, 15);
            lblInicio.TabIndex = 7;
            lblInicio.Text = "Inicio";
            // 
            // lblFim
            // 
            lblFim.AutoSize = true;
            lblFim.Location = new Point(282, 16);
            lblFim.Name = "lblFim";
            lblFim.Size = new Size(27, 15);
            lblFim.TabIndex = 8;
            lblFim.Text = "Fim";
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(btnGerar);
            panelFiltros.Controls.Add(dgvRelatorio);
            panelFiltros.Controls.Add(dtpFim);
            panelFiltros.Controls.Add(lblFim);
            panelFiltros.Controls.Add(dtpInicio);
            panelFiltros.Controls.Add(lblInicio);
            panelFiltros.Location = new Point(7, 12);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(489, 416);
            panelFiltros.TabIndex = 9;
            // 
            // panelResumo
            // 
            panelResumo.Controls.Add(lblTotalDespesas);
            panelResumo.Controls.Add(lblTotalVendas);
            panelResumo.Controls.Add(lblLucro);
            panelResumo.Location = new Point(7, 434);
            panelResumo.Name = "panelResumo";
            panelResumo.Size = new Size(489, 120);
            panelResumo.TabIndex = 10;
            // 
            // FrmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 566);
            Controls.Add(panelResumo);
            Controls.Add(panelFiltros);
            Name = "FrmRelatorios";
            Text = "FrmRelatorios";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelResumo.ResumeLayout(false);
            panelResumo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Button btnGerar;
        private DataGridView dgvRelatorio;
        private Label lblTotalVendas;
        private Label lblTotalDespesas;
        private Label lblLucro;
        private Label lblInicio;
        private Label lblFim;
        private Panel panelFiltros;
        private Panel panelResumo;
    }
}