using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingEstrutura
{
    public class Escolha
    {
        public string EscolhaTexto { get; private set; }
        public bool Random { get; private set; }
        public Escolha(string escolhaTexto, bool random = false)
        {
            this.EscolhaTexto = escolhaTexto;
            this.Random = random;
        }
    }
}
