using ÁrvoreDinamica.Valorecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaDinamica.Valorecoes.tipos
{
    class VidaMinima : TipoValor
    {
        public VidaMinima()
        {
            this.id = base.id = 4;
            this.nome = base.nome = "Vida Minima";
            this.descricao = base.descricao = "Seu personagem deve ter no minimo isso de valor de vida";

        }

        public override bool ComparaValor(Valoracao necessario, Valoracao existente)
        {
            if (!(necessario.tipoValor is VidaMinima) || !(existente.tipoValor is VidaMinima))
                return false;

            if (Convert.ToDouble(existente.valor) >= Convert.ToDouble(necessario.valor))
                return true;


            return false;
        }
    }
}
