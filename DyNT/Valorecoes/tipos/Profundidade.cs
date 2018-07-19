using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Valorecoes.tipos
{
    class Profundidade : TipoValor
    {
        public Profundidade()
        {
            this.id = base.id = 1;
            this.nome = base.nome = "Profundidade";
            this.descricao = base.descricao = "Profundidade na árvore";
            
        }
        public override bool ComparaValor(Valoracao necessario, Valoracao existente)
        {
            if (!(necessario.tipoValor is Profundidade) || !(existente.tipoValor is Profundidade))
                return false;

            if (Convert.ToInt32(necessario.valor) == Convert.ToInt32(existente.valor))
                return true;

            return false;
        }
    }
}
