using IniciacaoCientificaBranching.branchingEstrutura;
using IniciacaoCientificaBranching.branchingNarrativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniciacaoCientificaBranching.branchingEstrutura.nos;

namespace IniciacaoCientificaBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            long memoriaInicial = GC.GetTotalMemory(false);

            DateTime tempoInicial = DateTime.Now;
            Arvore arvore = Narrativa.GetNarrativa();
            DateTime tempoFinal = DateTime.Now;
            double tempoUsado = (tempoFinal - tempoInicial).TotalMilliseconds;

            while (arvore.noAtual.Ligacoes.Count > 0)
            {
                Console.WriteLine(arvore.noAtual.Escolha.EscolhaTexto);
                arvore.noAtual = arvore.noAtual.EscolherLigacao();
            }
            Console.WriteLine(arvore.noAtual.Escolha.EscolhaTexto);
            Console.WriteLine("Fim de jogo");


            long memoriaFinal = GC.GetTotalMemory(false);
            long memoriaUsada = memoriaFinal - memoriaInicial;
            Console.ReadKey();

            // Benchmarks:

            // Tempo:
            // Diferença em milisegundos através dos DateTimes "tempoInicial" e "tempoFinal"
            // A diferença é calculada em: double tempoUsado = (tempoFinal - tempoInicial).TotalMilliseconds;


            // Memória:
            // Pegamos a quantidade da memória através do código "GC.GetTotalMemory(false);" no inicio e fim da vida do código.
            // Por fim, é feito o calculo da diferença em: long memoriaUsada = memoriaFinal - memoriaInicial;


            // Numero de linhas para narrativa:
            // Contagem de linhas na função "Narrativa.GetNarrativa()" removendo comentários e linhas vazias através do programa Notepad++

            // Contagem de dados e repetições:
            // Os dados foram contados e revisados manualmente durante a construção da árvore utilizando o site www.mindmeister.com
            // A coleta de numero dados pode ser vista abaixo:
            //// As repetições foram calculadas da seguinte maneira: Caso só tenha 1 do elemento, ele é unico, se tiver mais do que um
            //// é porque há repetições nele onde: Repetições = QuantidadeTotal - 1 
            //// Ex: Tem 2 nós com o mesmo final, logo, 1 final só existe e 1 dado é repetição dele. Repetições = 2 - 1 = 1

            //// Até Hotel
            //Final = 18
            //Sim = 9
            //Não = 9
            //Volta = 9
            //VoltaCarro = 9
            //HotelRuim = 3
            //HotelMedio = 3
            //HotelBom = 3
            //CarroBom = 1
            //Carromedio = 1
            //CarroRuim = 1
            //Aleatoriedade = 1
            //Hotel = 1
            //Hospedagem = 1
            //Carro = 1
            //Veiculo = 1
            //Gramado = 1
            //Raiz = 1
            //SubTotal = 73
            //SubTotal Repetidos = 55

            //// Até Carro
            //Final = 36
            //Sim = 18
            //Não = 18
            //Volta = 18
            //VoltaCarro = 18
            //HotelRuim = 6
            //HotelMedio = 6
            //HotelBom = 6
            //CarroBom = 2
            //Carromedio = 2
            //CarroRuim = 2
            //Aleatoriedade = 2
            //Hotel = 1
            //Casa = 1
            //Hospedagem = 1
            //Carro = 1
            //Veiculo = 1
            //Gramado = 1
            //Raiz = 1
            //SubTotal = 141
            //SubTotal Repetidos = 122


            //// Até Gramado
            //Final = 54
            //Sim = 18
            //Não = 18
            //Volta = 36
            //VoltaCarro = 18
            //VoltaAvião = 18
            //HotelRuim = 12
            //HotelMedio = 12
            //HotelBom = 12
            //CarroBom = 4
            //Carromedio = 4
            //CarroRuim = 4
            //Aleatoriedade = 4
            //Hotel = 2
            //Casa = 2
            //Hospedagem = 2
            //Carro = 1
            //Avião = 1
            //Veiculo = 1
            //Gramado = 1
            //Raiz = 1
            //SubTotal = 225
            //SubTotal Repetidos = 204

            //// Até Raiz
            //Final = 108
            //Sim = 36
            //Não = 36
            //Volta = 72
            //VoltaCarro = 36
            //VoltaAvião = 36
            //HotelRuim = 24
            //HotelMedio = 24
            //HotelBom = 24
            //CarroBom = 8
            //Carromedio = 8
            //CarroRuim = 8
            //Aleatoriedade = 8
            //Hotel = 4
            //Casa = 4
            //Hospedagem = 4
            //Carro = 2
            //Avião = 2
            //Veiculo = 2
            //Gramado = 1
            //Natal = 1
            //Raiz = 1
            //SubTotal = 449
            //SubTotal Repetidos = 427

            // Total Branching:	449 dados
            // Total Repetições: 427 dados


        }
    }
}
