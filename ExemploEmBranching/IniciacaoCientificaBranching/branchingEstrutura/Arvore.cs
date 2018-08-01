using IniciacaoCientificaBranching.branchingEstrutura.nos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingEstrutura
{
    public class Arvore
    {
        // A árvore do full-branching é um pouco diferente, você apenas precisa saber a raiz
        // as ligações e controles de caminhos são feitas pelos próprios nós.
        // Sendo assim, a árvore apenas armazena de onde começar e seu controlador apenas para limitar/checar números de nós e ramificações
        public No noRaiz;
        
        // A árvore do full-branching otimizado também carrega um valor do nó atual, apenas para evitar buscas até o ponto atual da narrativa
        public No noAtual;
       
    }
}
