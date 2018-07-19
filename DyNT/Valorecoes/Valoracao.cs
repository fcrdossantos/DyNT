using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Valorecoes
{
    class Valoracao
    {
        public TipoValor tipoValor { get; set; }
        public object valor { get; set; }

        public Valoracao(TipoValor tipoValor, object valor)
        {
            this.tipoValor = tipoValor;
            this.valor = valor;
        }
    }
}
