using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGLP_SQLITE.Classes
{
    internal class Categoria
    {
        public int cod_Fornecedor { get; set; }
        public int cod_Categoria { get; set; }
        public string? dsc_Categoria { get; set; }
        public bool flg_Ativo { get; set; }
    }
}
