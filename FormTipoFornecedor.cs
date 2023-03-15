using Microsoft.Data.Sqlite;
using SGLP_SQLITE.Classes;
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
        int idTipoFornecedordgv;

        public FormTipoFornecedor()
        {
            InitializeComponent();
        }

        private void FormTipoFornecedor_Load(object sender, EventArgs e)
        {

            List<TipoFornecedor> tiposf = LerTipoFornecedores(caminhoBD);
            dgv_TipoFornecedor.DataSource = tiposf;
            dgvFormat();
        }

        private void btn_insert_TipoFornecedor_Click(object sender, EventArgs e)
        {
            InsereRegistro(caminhoBD);
             AtualizaControles();
        }

        private void btn_update_TipoFornecedor_Click(object sender, EventArgs e)
        {
            AlteraRegistro(caminhoBD, idTipoFornecedordgv);
            AtualizaControles();
        }

        private void btn_delete_TipoFornecedor_Click(object sender, EventArgs e)
        {
            ExcluiRegistro(caminhoBD, idTipoFornecedordgv);
            AtualizaControles();
        }

        private List<TipoFornecedor> LerTipoFornecedores(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminhoBD}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM tb_Tipo_Fornecedor order by cod_Tipo_Fornecedor");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                SqliteDataReader leitor = sql.ExecuteReader();
                List<TipoFornecedor> tipofornecedores = new List<TipoFornecedor>();

                while (leitor.Read())
                {
                    TipoFornecedor tipofornec = new TipoFornecedor
                    {
                        cod_Tipo_Fornecedor = Convert.ToInt32(leitor["cod_Tipo_Fornecedor"]),
                        dsc_Tipo_Fornecedor = leitor["dsc_Tipo_Fornecedor"].ToString(),
                        flg_Ativo = Convert.ToBoolean(leitor["flg_ativo"])
                    };
                    tipofornecedores.Add(tipofornec);
                }
                return tipofornecedores;
            }
        }

        private void dgvFormat()
        {
            dgv_TipoFornecedor.Columns[0].HeaderText = "Cód";
            dgv_TipoFornecedor.Columns[0].Width = 75;
            dgv_TipoFornecedor.Columns[1].HeaderText = "Tipo de Fornecedor";
            dgv_TipoFornecedor.Columns[1].Width = 250;
            dgv_TipoFornecedor.Columns[2].HeaderText = "Ativo";
            dgv_TipoFornecedor.Columns[2].Width = 75;
            dgv_TipoFornecedor.Update();
        }

        private void dgv_TipoFornecedor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTipoFornecedordgv = Convert.ToInt32(dgv_TipoFornecedor.CurrentRow.Cells[0].Value);
            txtTipoFornecedor.Text = dgv_TipoFornecedor.CurrentRow.Cells[1].Value.ToString();
            chkAtivoTipoFornecedor.Checked = (bool)dgv_TipoFornecedor.CurrentRow.Cells[2].Value;
        }

        private void InsereRegistro(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminhoBD}"))
            {

                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into tb_Tipo_Fornecedor VALUES (NULL, ");
                sb.Append("@DescFornecedor, @flgAtivo)");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@DescFornecedor", txtTipoFornecedor.Text);
                sql.Parameters.AddWithValue("@flgAtivo", chkAtivoTipoFornecedor.Checked);

                if (sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("O registro foi inserido com sucesso", "Tipo de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AlteraRegistro(string caminho, int idTipoFornecedor)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminhoBD}"))
            {

                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE tb_Tipo_Fornecedor SET ");
                sb.Append("dsc_Tipo_Fornecedor = @DescTipoFornecedor, flg_Ativo = @flgAtivo ");
                sb.Append("WHERE cod_Tipo_Fornecedor = @cod_Tipo_Fornecedor");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@DescTipoFornecedor", txtTipoFornecedor.Text);
                sql.Parameters.AddWithValue("@flgAtivo", chkAtivoTipoFornecedor.Checked);
                sql.Parameters.AddWithValue("@cod_Tipo_Fornecedor", idTipoFornecedor);

                if (sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("O registro foi alterado com sucesso", "Tipo de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExcluiRegistro(string caminho, int idTipoFornecedor)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminhoBD}"))
            {

                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE from tb_Tipo_Fornecedor ");
                sb.Append("WHERE cod_Tipo_Fornecedor = @cod_Tipo_Fornecedor");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@cod_Tipo_Fornecedor", idTipoFornecedor);

                if (sql.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("O registro foi excluído com sucesso", "Tipo de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AtualizaControles()
        {
            List<TipoFornecedor> tiposf = LerTipoFornecedores(caminhoBD);
            dgv_TipoFornecedor.DataSource = tiposf;
            txtTipoFornecedor.Text = string.Empty;
            chkAtivoTipoFornecedor.Checked = true;
        }


    }
}
