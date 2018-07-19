using ÁrvoreDinamica.Valorecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaDinamica.Valorecoes.tipos
{
    class Veiculo: TipoValor
    {
        public Veiculo()
        {
            this.id = base.id = 1;
            this.nome = base.nome = "Hospedagem";
            this.descricao = base.descricao = "É o tipo da hospedagem que ficaremos";

        }
        public override bool ComparaValor(Valoracao necessario, Valoracao existente)
        {
            if (!(necessario.tipoValor is Veiculo) || !(existente.tipoValor is Veiculo))
                return false;

            if (Convert.ToInt32(necessario.valor) == Convert.ToInt32(existente.valor))
                return true;

            if (Convert.ToInt32(existente.valor) == 0)
                return true;

            return false;
        }
    }
}
