using IniciacaoCientificaBranching.branchingEstrutura.nos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingEstrutura.nos
{
    public static class ControladorNos
    {
       public static No EscolherLigacao(this No no)
        {
            // Caso não haja ligações, retorna nulo
            if (no.Ligacoes.Count == 0)
                return null;

            // Caso só haja uma escolhe, já retorna ela
            if (no.Ligacoes.Count == 1)
                return no.Ligacoes[0];


            // Como nesse exemplo é escolher randomicamente ou pelo usuário, nunca os dois juntos, verificamos apenas o primeiro
            // se ele for random, então todos são randoms, do contrário, todos são pelo usuário.
            bool escolhaRandom = no.Ligacoes[0].Escolha.Random;

            if (escolhaRandom)
            {
                // Retorna algum nó randomicamente
                Random rand = new Random((int) DateTime.Now.Ticks);
                return no.Ligacoes[rand.Next(0, no.Ligacoes.Count)];
            }
            else
            {
                Console.WriteLine("Faça sua escolha: ");
                // Mostra aos usuários as possíveis escolhas
                foreach(No noAtual in no.Ligacoes)
                {
                    Console.WriteLine("  {0} - {1}", no.Ligacoes.IndexOf(noAtual)+1, noAtual.Escolha.EscolhaTexto);
                }

                // Lê a entrada do usuário até ser uma válida
                if (!Int32.TryParse(Console.ReadLine(), out int index))
                    index = 0;
                while (index < 1 || index > no.Ligacoes.Count)
                {
                    Console.WriteLine("Escolha inválida, tente de novo");
                    if (!Int32.TryParse(Console.ReadLine(), out index))
                        index = 0;
                }

                return no.Ligacoes[index - 1];
            }
        }
    }
}
