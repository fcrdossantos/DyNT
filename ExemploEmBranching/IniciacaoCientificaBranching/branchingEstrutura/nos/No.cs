using IniciacaoCientificaBranching.branchingEstrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingEstrutura.nos
{
    public class No
    {
        public Escolha Escolha { get; private set; } // A escolha atual desse nó (o valor que ele contém).
        public List<No> Ligacoes { get; set; } // Nos aos quais esse atual pode se ligar

        // Exemplo:
        // Podemos ir para esquerda ou direita
        // Escolha = Direita (escolhemos ir para a direita)
        // Ligações = Dar meia volta  ou Continuar em frente

        public No(Escolha escolha)
        {
            this.Escolha = escolha;
            Ligacoes = new List<No>();
        }
     
        /// <summary>
        /// Construtor fácil, apenas envia a string do texto da escolha
        /// </summary>
        /// <param name="escolhaTexto">Texto para ser passado para o texto da escolha</param>
        public No(string escolhaTexto, bool random = false)
        {
            this.Escolha = new Escolha(escolhaTexto, random);
            Ligacoes = new List<No>();
        }
    }
}
