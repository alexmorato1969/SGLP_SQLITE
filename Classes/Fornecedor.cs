using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGLP_SQLITE.Classes
{
    internal class Fornecedor
    {
        public int cod_Fornecedor { get; set; }
        public int cod_Tipo_Fornecedor { get; set; }
        public string? nme_Fornecedor { get; set; }
        public bool flg_Ativo { get; set; }
    }
}
