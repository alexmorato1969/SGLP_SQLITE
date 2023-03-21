using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGLP_SQLITE.Classes
{
    internal class Produto
    {
        public int cod_Categoria { get; set; }//ID da Categoria x Fornecedor do Produto
        public int cod_Produto { get; set; }//ID do prduto
        public string? sku_Produto { get; set; }//Cód do fabricante para o produto
        public string? dsc_Produto { get; set; }// Descr do Produto
        public string? apr_Produto { get; set; }// Apresentação do produto
        public int qtd_apr_Produto { get; set; }//Qtd por apresentação do Produto - Ex.: Qtd que vem na cxa
        public double vlr_unt_Produto { get; set; }//Valor unitário do Produto
        public int pso_unt_Produto { get; set; }//Peso unit do Produto
        public int pso_tot_apr_Produto { get; set; }//Peso total da apresentação do produto - Ex.: Cxa com 1kg
        public double vlr_tot_apr_Produto { get; set; }//Valor total da apres do Produto - Cxa = R$100,00
        public int nro_dia_validade_Produto { get; set; }//Dias de validade do produto
        public bool flg_Ativo { get; set; }

    }
}
