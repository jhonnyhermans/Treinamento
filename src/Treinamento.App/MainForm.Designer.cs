namespace Treinamento.App
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaçãoAvançadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desligarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiProdutos,
            this.tsiClientes});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsiProdutos
            // 
            this.tsiProdutos.Name = "tsiProdutos";
            this.tsiProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsiProdutos.Text = "Produtos";
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLogOff,
            this.trocaDeUsuárioToolStripMenuItem,
            this.visualizaçãoAvançadaToolStripMenuItem});
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ferramentaToolStripMenuItem.Text = "Ferramenta";
            // 
            // tsiLogOff
            // 
            this.tsiLogOff.Name = "tsiLogOff";
            this.tsiLogOff.Size = new System.Drawing.Size(191, 22);
            this.tsiLogOff.Text = "Log-off";
            // 
            // trocaDeUsuárioToolStripMenuItem
            // 
            this.trocaDeUsuárioToolStripMenuItem.Name = "trocaDeUsuárioToolStripMenuItem";
            this.trocaDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.trocaDeUsuárioToolStripMenuItem.Text = "Troca de usuário";
            // 
            // visualizaçãoAvançadaToolStripMenuItem
            // 
            this.visualizaçãoAvançadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligarToolStripMenuItem,
            this.desligarToolStripMenuItem});
            this.visualizaçãoAvançadaToolStripMenuItem.Name = "visualizaçãoAvançadaToolStripMenuItem";
            this.visualizaçãoAvançadaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.visualizaçãoAvançadaToolStripMenuItem.Text = "Visualização avançada";
            // 
            // ligarToolStripMenuItem
            // 
            this.ligarToolStripMenuItem.Name = "ligarToolStripMenuItem";
            this.ligarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ligarToolStripMenuItem.Text = "Ligar";
            // 
            // desligarToolStripMenuItem
            // 
            this.desligarToolStripMenuItem.Name = "desligarToolStripMenuItem";
            this.desligarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.desligarToolStripMenuItem.Text = "Desligar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsiClientes
            // 
            this.tsiClientes.Name = "tsiClientes";
            this.tsiClientes.Size = new System.Drawing.Size(180, 22);
            this.tsiClientes.Text = "Clientes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiProdutos;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiLogOff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem trocaDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaçãoAvançadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desligarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiClientes;
    }
}

