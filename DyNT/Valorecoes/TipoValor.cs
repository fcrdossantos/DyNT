using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Valorecoes
{
    abstract class TipoValor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public abstract bool ComparaValor(Valoracao necessario, Valoracao existente);
 
    }
}
