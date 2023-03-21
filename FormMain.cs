using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
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
                sb.Append("cod_Tipo_Fornecedor INTEGER NOT NULL, ");
                sb.Append("nme_Fornecedor VARCHAR(100) NOT NULL UNIQUE, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                //Cria tabela de Categorias de Produtos
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Categoria (");
                sb.Append("cod_Fornecedor INTEGER NOT NULL, ");
                sb.Append("cod_Categoria INTEGER PRIMARY KEY, ");
                sb.Append("dsc_Categoria VARCHAR(150) NOT NULL UNIQUE, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                //Cria tabela de Produtos
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Produto (");
                sb.Append("cod_Produto INTEGER PRIMARY KEY, ");
                sb.Append("cod_Categoria INTEGER NOT NULL, ");
                sb.Append("sku_Produto VARCHAR(10) NOT NULL UNIQUE, ");
                sb.Append("dsc_Produto VARCHAR(150) NOT NULL UNIQUE, ");
                sb.Append("apr_Produto VARCHAR(20) NOT NULL, ");
                sb.Append("qtd_apr_Produto INTEGER NOT NULL, ");
                sb.Append("vlr_unt_Produto DOUBLE NOT NULL, ");
                sb.Append("pso_unt_Produto INTEGER NULL, ");
                sb.Append("vlr_tot_apr_Produto DOUBLE NOT NULL, ");
                sb.Append("nro_dia_Validade_Produto INTEGER NULL, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                //Cria lista de preços - Head
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Lista_Preco_Head (");
                sb.Append("cod_lista_preco_head INTEGER PRIMARY KEY, ");
                sb.Append("dsc_Vigencia VARCHAR(20) NOT NULL UNIQUE, ");
                sb.Append("cod_Fornecedor INTEGER NOT NULL, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                //Cria lista de preços - Detail
                sb.Append("CREATE TABLE IF NOT EXISTS tb_Lista_Preco_Detail (");
                sb.Append("cod_lista_preco_head INTEGER NOT NULL, ");
                sb.Append("cod_Produto INTEGER NOT NULL, ");
                sb.Append("qtd_apr_Produto INTEGER NOT NULL, ");
                sb.Append("vlr_unt_Produto DOUBLE NOT NULL, ");
                sb.Append("vlr_tot_apr_Produto DOUBLE NOT NULL, ");
                sb.Append("flg_Ativo BOOLEAN DEFAULT true);");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();
                sb.Clear();

                // Inicia as configurações de FK's
                 
                sb.Append("ALTER TABLE tb_Fornecedor ADD CONSTRAINT fk_Tipo_Fornecedor_parent ");
                sb.Append("FOREIGN KEY(cod_Tipo_Fornecedor)");
                sb.Append("REFERENCES tb_Tipo_Fornecedor(cod_Tipo_Fornecedor);");
                sql.ExecuteNonQuery();
                sb.Clear();




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
