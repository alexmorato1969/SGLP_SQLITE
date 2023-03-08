namespace SGLP_SQLITE
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new System.Windows.Forms.MenuStrip();
            cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tipoDeFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            categoriaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listaDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            atualizarNuvemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusBar = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            StatusData = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { cadastrosToolStripMenuItem, listaDePreçosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(1064, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tipoDeFornecedorToolStripMenuItem, fornecedorToolStripMenuItem, categoriaDeProdutosToolStripMenuItem, produtosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tipoDeFornecedorToolStripMenuItem
            // 
            tipoDeFornecedorToolStripMenuItem.Name = "tipoDeFornecedorToolStripMenuItem";
            tipoDeFornecedorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            tipoDeFornecedorToolStripMenuItem.Text = "Tipo de Fornecedor";
            tipoDeFornecedorToolStripMenuItem.Click += tipoDeFornecedorToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // categoriaDeProdutosToolStripMenuItem
            // 
            categoriaDeProdutosToolStripMenuItem.Name = "categoriaDeProdutosToolStripMenuItem";
            categoriaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            categoriaDeProdutosToolStripMenuItem.Text = "Categoria de Produtos";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // listaDePreçosToolStripMenuItem
            // 
            listaDePreçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { manutençãoToolStripMenuItem, toolStripMenuItem1, atualizarNuvemToolStripMenuItem });
            listaDePreçosToolStripMenuItem.Name = "listaDePreçosToolStripMenuItem";
            listaDePreçosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            listaDePreçosToolStripMenuItem.Text = "Lista de Preços";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // atualizarNuvemToolStripMenuItem
            // 
            atualizarNuvemToolStripMenuItem.Name = "atualizarNuvemToolStripMenuItem";
            atualizarNuvemToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            atualizarNuvemToolStripMenuItem.Text = "Atualizar Nuvem";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, StatusData, toolStripStatusLabel2, toolStripStatusLabelData });
            statusBar.Location = new System.Drawing.Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new System.Drawing.Size(1064, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusData
            // 
            StatusData.Name = "StatusData";
            StatusData.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
            toolStripStatusLabel2.Text = "Data:";
            // 
            // toolStripStatusLabelData
            // 
            toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            toolStripStatusLabelData.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabelData.Text = "toolStripStatusLabel3";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 561);
            Controls.Add(statusBar);
            Controls.Add(menuStrip);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SGLP - Sistema de Gerenciamento de Lista de Preços";
            Load += FormMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePreçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarNuvemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
    }
}
