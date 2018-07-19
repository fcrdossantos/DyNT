using ÁrvoreDinamica.Nos;
using ÁrvoreDinamica.Valorecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÁrvoreDinamica.Arvores
{
    class ArvoreDinamica
    {
        public List<No> nosNaArvore { get; set; }
        public List<No> nosExistentes { get; set; }
        public List<Valoracao> valoresGlobaisEmUso { get; set; }
        public No noAtual { get; set; }
        public List<No> futurosCandidatos { get; set; }

        public ArvoreDinamica(List<No> nosNaArvore = null, List<No> nosExistentes = null, List<Valoracao> valoresGlobaisEmUso = null, No noAtual = null)
        {
            if (nosNaArvore != null)
                this.nosNaArvore = nosNaArvore;
            else
                this.nosNaArvore = new List<No>();

            if (nosExistentes != null)
                this.nosExistentes = nosExistentes;
            else
                this.nosExistentes = new List<No>();

            if (valoresGlobaisEmUso != null)
                this.valoresGlobaisEmUso = valoresGlobaisEmUso;
            else
                this.valoresGlobaisEmUso = new List<Valoracao>();

            if (noAtual != null)
                this.noAtual = noAtual;

            this.futurosCandidatos = new List<No>();
        }

        public void AdicionarNoExistente(No noExistente)
        {
            nosExistentes.Add(noExistente);
        }

        public void AdicionarNoExistente(List<No> nosExistentes)
        {
            this.nosExistentes.AddRange(nosExistentes);
        }

        public void FazerLigacao(No noAtual)
        {
            this.futurosCandidatos.Clear();

            if (noAtual.final)
                return;
    
            List<No> candidatos = new List<No>();
            int index = 0;

            // Checagem dos valores necessários dos nós
            if (noAtual.valoresNecessarios.Count > 0)
            {   
                //  Para cada valoração que precisamos
                foreach(Valoracao valoracaoAtual in noAtual.valoresNecessarios)
                {
                    // Se for a primeira vez, apenas vamos adicionar os nós que possuem tal valoração
                    if(index == 0)
                    {
                        // Para cada nó candidato possível
                        foreach (No candidatoAtual in nosExistentes)
                        {
                            // Pegamos todas as valorações deles
                            foreach (Valoracao valorCandidatoAtual in candidatoAtual.valoresExistentes)
                            {
                                // Comparamos se essa valoração satisfaz a desejada
                                if (valoracaoAtual.tipoValor.ComparaValor(valoracaoAtual, valorCandidatoAtual))
                                {
                                    // Caso satisfaça, adicionamos tal nó aos candidatos.
                                    candidatos.Add(candidatoAtual);
                                    break;
                                }
                                    
                            }
                        }
                    }
                    else
                    {                                          
                        if (candidatos.Count < 1)
                            return;
                        List<No> toRemove = new List<No>();
                        // Uma vez que adicionou todos os candidatos que cumprem o primeiro requisito, procuramos apenas nestes.
                        foreach (No candidatoAtual in candidatos)
                        {
                            bool remover = true;
                            // Se um deles não cumprir algum dos demais requisitos, ele será removido.
                            foreach (Valoracao valorCandidatoAtual in candidatoAtual.valoresExistentes)
                            {
                                if (valoracaoAtual.tipoValor.ComparaValor(valoracaoAtual, valorCandidatoAtual))
                                    remover = false;
                            }
                            if (remover)
                                toRemove.Add(candidatoAtual);
                        }
                        foreach (No noRemovivel in toRemove)
                            candidatos.Remove(noRemovivel);

                    }
                    index++;
                }
            }

            // Checa se satisfaz os globais
            foreach (Valoracao valoracaoAtual in valoresGlobaisEmUso)
            {

                if (candidatos.Count < 1)
                    return;

                List<No> toRemove = new List<No>();
                // Uma vez que adicionou todos os candidatos que cumprem o primeiro requisito, procuramos apenas nestes.
                foreach (No candidatoAtual in candidatos)
                {
                    if (!candidatoAtual.usarGlobal)
                        continue;

                    bool remover = true;
                    // Se um deles não cumprir algum dos demais requisitos, ele será removido.
                    foreach (Valoracao valorCandidatoAtual in candidatoAtual.valoresExistentes)
                    {
                        if (valoracaoAtual.tipoValor.ComparaValor(valoracaoAtual, valorCandidatoAtual))
                            remover = false;

                        
                    }

                    if (remover)
                        toRemove.Add(candidatoAtual);
                }
                foreach (No noRemovivel in toRemove)
                    candidatos.Remove(noRemovivel);

            }

            if (candidatos.Count > 0)
                futurosCandidatos.AddRange(candidatos);
        }


        public No EscolherLigacao(No no)
        {
            
            // Caso não haja ligações, retorna nulo
            if (futurosCandidatos.Count == 0)
                return null;

            // Caso só haja uma escolhe, já retorna ela
            if (futurosCandidatos.Count == 1)
                return futurosCandidatos[0];


            // Como nesse exemplo é escolher randomicamente ou pelo usuário, nunca os dois juntos, verificamos apenas o primeiro
            // se ele for random, então todos são randoms, do contrário, todos são pelo usuário.
            bool escolhaRandom = futurosCandidatos[0].random;

            if (escolhaRandom)
            {
                // Retorna algum nó randomicamente
                Random rand = new Random((int)DateTime.Now.Ticks);
                return futurosCandidatos[rand.Next(0, futurosCandidatos.Count)];
            }
            else
            {
                Console.WriteLine("Faça sua escolha: ");
                // Mostra aos usuários as possíveis escolhas
                foreach (No noAtual in futurosCandidatos)
                {
                    Console.WriteLine("  {0} - {1}", futurosCandidatos.IndexOf(noAtual) + 1, noAtual.nome);
                }
                
                // Lê a entrada do usuário até ser uma válida
                if (!Int32.TryParse(Console.ReadLine(), out int index))
                    index = 0;
                while (index < 1 || index > futurosCandidatos.Count)
                {
                    Console.WriteLine("Escolha inválida, tente de novo");
                    if (!Int32.TryParse(Console.ReadLine(), out index))
                        index = 0;
                }

                return futurosCandidatos[index - 1];
            }
        }

        public void CorrigirArvore()
        {

        }

        public void AdicionarGlobais(No noAtual)
        {
            if(noAtual.valoresGlobaisNecessarios.Count > 0)
            {
                this.valoresGlobaisEmUso.AddRange(noAtual.valoresGlobaisNecessarios);
            }
        }
    }
}
