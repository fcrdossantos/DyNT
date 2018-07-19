using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Valorecoes.tipos
{
    class Hospedagem : TipoValor
    {
        public Hospedagem()
        {
            this.id = base.id = 1;
            this.nome = base.nome = "Hospedagem";
            this.descricao = base.descricao = "É o tipo da hospedagem que ficaremos";

        }
        public override bool ComparaValor(Valoracao necessario, Valoracao existente)
        {
            if (!(necessario.tipoValor is Hospedagem) || !(existente.tipoValor is Hospedagem))
                return false;

            if (Convert.ToInt32(necessario.valor) == Convert.ToInt32(existente.valor))
                return true;

            if (Convert.ToInt32(existente.valor) == 0)
                return true;

            return false;
        }
    }
}
