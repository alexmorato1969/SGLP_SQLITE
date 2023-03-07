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
    public partial class FormTipoFornecedor : Form
    {
        string caminhoBD = Path.Combine(Application.LocalUserAppDataPath, "sglp.db");

        public FormTipoFornecedor()
        {
            InitializeComponent();
        }

        private void btn_insert_TipoFornecedor_Click(object sender, EventArgs e)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminhoBD}"))
            {
                int insertCount = 0;
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into tb_Tipo_Fornecedor VALUES (NULL, ");
                sb.Append("@DescFornecedor, @flgAtivo)");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@DescFornecedor", txtTipoFornecedor.Text);
                sql.Parameters.AddWithValue("@flgAtivo", chkAtivoTipoFornecedor.Checked);

                insertCount = sql.ExecuteNonQuery();


                if (insertCount > 0)
                {
                    MessageBox.Show("O registro foi inserido com sucesso", "Tipo de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
