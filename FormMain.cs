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
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Tipo_Fornecedor (");
                sb.Append("cod_Tipo_Fornecedor INTEGER PRIMARY KEY, ");
                sb.Append("dsc_Tipo_Fornecedor VARCHAR(50) NOT NULL UNIQUE, ");
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
    }
}
