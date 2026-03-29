namespace Financeiro_teste.Forms
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            NovaVenda = new Button();
            Despesas = new Button();
            HistoricoVendas = new Button();
            Relatorios = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { vendasToolStripMenuItem, toolStripMenuItem1, financeiroToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(272, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // NovaVenda
            // 
            NovaVenda.Location = new Point(71, 88);
            NovaVenda.Name = "NovaVenda";
            NovaVenda.Size = new Size(151, 47);
            NovaVenda.TabIndex = 1;
            NovaVenda.Text = "Nova Venda";
            NovaVenda.UseVisualStyleBackColor = true;
            NovaVenda.Click += NovaVenda_Click;
            // 
            // Despesas
            // 
            Despesas.Location = new Point(71, 272);
            Despesas.Name = "Despesas";
            Despesas.Size = new Size(151, 44);
            Despesas.TabIndex = 2;
            Despesas.Text = "Despesas";
            Despesas.UseVisualStyleBackColor = true;
            Despesas.Click += Despesas_Click;
            // 
            // HistoricoVendas
            // 
            HistoricoVendas.Location = new Point(71, 178);
            HistoricoVendas.Name = "HistoricoVendas";
            HistoricoVendas.Size = new Size(151, 46);
            HistoricoVendas.TabIndex = 3;
            HistoricoVendas.Text = "Histórico";
            HistoricoVendas.UseVisualStyleBackColor = true;
            HistoricoVendas.Click += HistoricoVendas_Click;
            // 
            // Relatorios
            // 
            Relatorios.Location = new Point(71, 363);
            Relatorios.Name = "Relatorios";
            Relatorios.Size = new Size(151, 45);
            Relatorios.TabIndex = 4;
            Relatorios.Text = "Relatórios";
            Relatorios.UseVisualStyleBackColor = true;
            Relatorios.Click += Relatorios_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 450);
            Controls.Add(Relatorios);
            Controls.Add(HistoricoVendas);
            Controls.Add(Despesas);
            Controls.Add(NovaVenda);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private Button NovaVenda;
        private Button Despesas;
        private Button HistoricoVendas;
        private Button Relatorios;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}