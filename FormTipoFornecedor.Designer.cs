namespace SGLP_SQLITE
{
    partial class FormTipoFornecedor
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
            panelTipoFornecedorCRUD = new System.Windows.Forms.Panel();
            btn_Filtrar_TipoFornecedor = new System.Windows.Forms.Button();
            btn_delete_TipoFornecedor = new System.Windows.Forms.Button();
            btn_update_TipoFornecedor = new System.Windows.Forms.Button();
            btn_insert_TipoFornecedor = new System.Windows.Forms.Button();
            chkAtivoTipoFornecedor = new System.Windows.Forms.CheckBox();
            txtTipoFornecedor = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            dgv_TipoFornecedor = new System.Windows.Forms.DataGridView();
            panelTipoFornecedorCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TipoFornecedor).BeginInit();
            SuspendLayout();
            // 
            // panelTipoFornecedorCRUD
            // 
            panelTipoFornecedorCRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panelTipoFornecedorCRUD.Controls.Add(btn_Filtrar_TipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(btn_delete_TipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(btn_update_TipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(btn_insert_TipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(chkAtivoTipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(txtTipoFornecedor);
            panelTipoFornecedorCRUD.Controls.Add(label1);
            panelTipoFornecedorCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            panelTipoFornecedorCRUD.Location = new System.Drawing.Point(0, 0);
            panelTipoFornecedorCRUD.Name = "panelTipoFornecedorCRUD";
            panelTipoFornecedorCRUD.Size = new System.Drawing.Size(784, 89);
            panelTipoFornecedorCRUD.TabIndex = 0;
            // 
            // btn_Filtrar_TipoFornecedor
            // 
            btn_Filtrar_TipoFornecedor.Location = new System.Drawing.Point(371, 56);
            btn_Filtrar_TipoFornecedor.Name = "btn_Filtrar_TipoFornecedor";
            btn_Filtrar_TipoFornecedor.Size = new System.Drawing.Size(75, 23);
            btn_Filtrar_TipoFornecedor.TabIndex = 6;
            btn_Filtrar_TipoFornecedor.Text = "Consultar";
            btn_Filtrar_TipoFornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_delete_TipoFornecedor
            // 
            btn_delete_TipoFornecedor.Location = new System.Drawing.Point(273, 56);
            btn_delete_TipoFornecedor.Name = "btn_delete_TipoFornecedor";
            btn_delete_TipoFornecedor.Size = new System.Drawing.Size(75, 23);
            btn_delete_TipoFornecedor.TabIndex = 5;
            btn_delete_TipoFornecedor.Text = "Excluir";
            btn_delete_TipoFornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_update_TipoFornecedor
            // 
            btn_update_TipoFornecedor.Location = new System.Drawing.Point(175, 56);
            btn_update_TipoFornecedor.Name = "btn_update_TipoFornecedor";
            btn_update_TipoFornecedor.Size = new System.Drawing.Size(75, 23);
            btn_update_TipoFornecedor.TabIndex = 4;
            btn_update_TipoFornecedor.Text = "Atualizar";
            btn_update_TipoFornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_insert_TipoFornecedor
            // 
            btn_insert_TipoFornecedor.Location = new System.Drawing.Point(77, 56);
            btn_insert_TipoFornecedor.Name = "btn_insert_TipoFornecedor";
            btn_insert_TipoFornecedor.Size = new System.Drawing.Size(75, 23);
            btn_insert_TipoFornecedor.TabIndex = 3;
            btn_insert_TipoFornecedor.Text = "Inserir";
            btn_insert_TipoFornecedor.UseVisualStyleBackColor = true;
            btn_insert_TipoFornecedor.Click += btn_insert_TipoFornecedor_Click;
            // 
            // chkAtivoTipoFornecedor
            // 
            chkAtivoTipoFornecedor.AutoSize = true;
            chkAtivoTipoFornecedor.Location = new System.Drawing.Point(453, 16);
            chkAtivoTipoFornecedor.Name = "chkAtivoTipoFornecedor";
            chkAtivoTipoFornecedor.Size = new System.Drawing.Size(60, 19);
            chkAtivoTipoFornecedor.TabIndex = 2;
            chkAtivoTipoFornecedor.Text = "Ativo :";
            chkAtivoTipoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkAtivoTipoFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtTipoFornecedor
            // 
            txtTipoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtTipoFornecedor.Location = new System.Drawing.Point(77, 12);
            txtTipoFornecedor.MaxLength = 50;
            txtTipoFornecedor.Name = "txtTipoFornecedor";
            txtTipoFornecedor.Size = new System.Drawing.Size(370, 23);
            txtTipoFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição: ";
            // 
            // dgv_TipoFornecedor
            // 
            dgv_TipoFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_TipoFornecedor.Location = new System.Drawing.Point(12, 159);
            dgv_TipoFornecedor.Name = "dgv_TipoFornecedor";
            dgv_TipoFornecedor.RowTemplate.Height = 25;
            dgv_TipoFornecedor.Size = new System.Drawing.Size(742, 150);
            dgv_TipoFornecedor.TabIndex = 1;
            // 
            // FormTipoFornecedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 361);
            Controls.Add(dgv_TipoFornecedor);
            Controls.Add(panelTipoFornecedorCRUD);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "FormTipoFornecedor";
            Text = "Manutenção de Tipo de Fornecedor";
            panelTipoFornecedorCRUD.ResumeLayout(false);
            panelTipoFornecedorCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_TipoFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTipoFornecedorCRUD;
        private System.Windows.Forms.CheckBox chkAtivoTipoFornecedor;
        private System.Windows.Forms.TextBox txtTipoFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Filtrar_TipoFornecedor;
        private System.Windows.Forms.Button btn_delete_TipoFornecedor;
        private System.Windows.Forms.Button btn_update_TipoFornecedor;
        private System.Windows.Forms.Button btn_insert_TipoFornecedor;
        private System.Windows.Forms.DataGridView dgv_TipoFornecedor;
    }
}