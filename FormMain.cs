using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGLP_SQLITE
{
    public partial class FormMain : Form
    {
        string caminhoBD = Path.Combine(Application.LocalUserAppDataPath, "sglp.db");


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CriarBancoDeDados(caminhoBD);
        }

        private void CriarBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();

                //Cria tabela de Tipo de Fornecedor
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Tipo_Fornecedor (");
                sb.Append("cod_Tipo_Fornecedor INTEGER PRIMARY KEY, ");
                sb.Append("dsc_Tipo_Fornecedor VARCHAR(50) NOT NULL UNIQUE, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                //Cria tabela de Fornecedor
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Fornecedor (");
                sb.Append("cod_Fornecedor INTEGER PRIMARY KEY, ");
                sb.Append("nme_Fornecedor VARCHAR(100) NOT NULL UNIQUE, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();


            }
        }


        private void tipoDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoFornecedor formTipoFornecedor = new FormTipoFornecedor();
            formTipoFornecedor.MdiParent = this;
            formTipoFornecedor.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja encerrar o sistema ?", "SGLP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
            
        }
    }
}
