using ÁrvoreDinamica.Arvores;
using ÁrvoreDinamica.Nos;
using ÁrvoreDinamica.Valorecoes;
using ÁrvoreDinamica.Valorecoes.tipos;
using IniciacaoCientificaDinamica.Valorecoes.tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            long memoriaInicial = GC.GetTotalMemory(false);

            DateTime tempoInicial = DateTime.Now;
         
            // Inicio da narrativa
            Valoracao profundidade1 = new Valoracao(new Profundidade(), 1);
            Valoracao profundidade1_2 = new Valoracao(new Profundidade(), 12);
            Valoracao profundidade2 = new Valoracao(new Profundidade(), 2);
            Valoracao profundidade2_3 = new Valoracao(new Profundidade(), 23);
            Valoracao profundidade3 = new Valoracao(new Profundidade(), 3);
            Valoracao profundidade3_4 = new Valoracao(new Profundidade(), 34);
            Valoracao profundidade4_r1 = new Valoracao(new Profundidade(), 41); // Nivel Quatro primeiro Random
            Valoracao profundidade4_r2 = new Valoracao(new Profundidade(), 42);
            Valoracao profundidade4_5 = new Valoracao(new Profundidade(), 45);
            Valoracao profundidade5 = new Valoracao(new Profundidade(), 5);
            Valoracao profundidade6 = new Valoracao(new Profundidade(), 6);
            Valoracao profundidade7 = new Valoracao(new Profundidade(), 7);

            Valoracao veiculoCarro = new Valoracao(new Veiculo(), 1);
            Valoracao veiculoAviao = new Valoracao(new Veiculo(), 2);
            Valoracao veiculoTodos = new Valoracao(new Veiculo(), 0);

            Valoracao hospedagemHotel = new Valoracao(new Hospedagem(), 1);
            Valoracao hospedagemCasa = new Valoracao(new Hospedagem(), 2);
            Valoracao hospedagemTodos = new Valoracao(new Hospedagem(), 0);


            // Início
            No raiz = new No("Está na hora da viagem em familia, qual será nosso destino desta vez?", valoresNecessarios: new List<Valoracao> { profundidade1 });

            // Destino da viagem
            No gramado = new No("Vamos para Gramado", valoresExistentes: new List<Valoracao> { profundidade1 }, valoresNecessarios: new List<Valoracao> { profundidade1_2 });
            No natal = new No("Vamos para Natal", valoresExistentes: new List<Valoracao> { profundidade1 }, valoresNecessarios: new List<Valoracao> { profundidade1_2 });

            // Veiculo
            No veiculo = new No("Agora precisamos decidir com qual veículos vamos: ", valoresExistentes: new List<Valoracao> { profundidade1_2 }, valoresNecessarios: new List<Valoracao> { profundidade2 });
            No carro = new No("Vamos com nosso carro", valoresExistentes: new List<Valoracao> { profundidade2 }, valoresNecessarios: new List<Valoracao> { profundidade2_3 }, valoresGlobais:new List<Valoracao> { veiculoCarro});
            No aviao = new No("Ir de Avião seria legal", valoresExistentes: new List<Valoracao> { profundidade2 }, valoresNecessarios: new List<Valoracao> { profundidade2_3 }, valoresGlobais: new List<Valoracao> { veiculoAviao });

            // Hospedagem
            No hospedagem = new No("Ótimo! Agora só falta definir a hospedagem", valoresExistentes: new List<Valoracao> { profundidade2_3 }, valoresNecessarios: new List<Valoracao> { profundidade3 });
            No hotel = new No("Vamos ficar em um hotel", valoresExistentes: new List<Valoracao> { profundidade3 }, valoresNecessarios: new List<Valoracao> { profundidade3_4 }, valoresGlobais: new List<Valoracao> { hospedagemHotel });
            No casa = new No("Vamos para a casa de um amigo", valoresExistentes: new List<Valoracao> { profundidade3 }, valoresNecessarios: new List<Valoracao> { profundidade3_4 }, valoresGlobais: new List<Valoracao> { hospedagemCasa });

            // Aleatoriedades da viagem (r_ = random
              // Bom
            No aleatoriedades = new No("Chegamos no nosso destino\n", random: true, valoresExistentes: new List<Valoracao> { profundidade3_4}, valoresNecessarios: new List<Valoracao> { profundidade4_r1 });
            No r_carro_bom = new No("Deu tudo certo no passeio, paramos em um posto na estrada e tinha muitos doces!", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoCarro, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_aviao_bom = new No("Uau! Ganhamos uma passagem primeira classe no voo", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoAviao, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_hotel_bom = new No("Esse hotel é fantástico! Adorei a piscina", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemHotel, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);
            No r_casa_bom = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemCasa, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);
              // Neutro
            No r_carro_neutro = new No("O passeio de carro foi normal", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoCarro, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_aviao_neutro = new No("A viagem de avião foi normal", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoAviao, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_hotel_neutro = new No("O hotel aqui até que é legal", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemHotel, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);
            No r_casa_neutro = new No("A casa dos nossos amigos até que está legal", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemCasa, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);
              // Ruim
            No r_carro_ruim = new No("A viagem de carro foi péssima! A estrada estava esburacada e o pneu furou", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoCarro, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_aviao_ruim = new No("O voo foi horrível e ainda por cima atrasou", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r1, veiculoAviao, hospedagemTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_r2 }, usarGlobal: true);
            No r_hotel_ruim = new No("Não gostamos nada do hotel, não tinha nem agua quente", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemHotel, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);
            No r_casa_ruim = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", random: true, valoresExistentes: new List<Valoracao> { profundidade4_r2, hospedagemCasa, veiculoTodos }, valoresNecessarios: new List<Valoracao> { profundidade4_5 }, usarGlobal: true);

            // Volta para casa
            No volta = new No("\nUma semana depois...", valoresExistentes: new List<Valoracao> { profundidade4_5 }, valoresNecessarios: new List<Valoracao> { profundidade5 });
            No voltaCarro = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?", valoresExistentes: new List<Valoracao> { profundidade5, hospedagemTodos, veiculoCarro }, valoresNecessarios: new List<Valoracao> { profundidade6 }, usarGlobal: true);
            No voltaAviao = new No("Está na hora de voltar para casa", valoresExistentes: new List<Valoracao> { profundidade5, hospedagemTodos, veiculoAviao }, valoresNecessarios: new List<Valoracao> { profundidade7 }, usarGlobal: true);
            // Dia extra carro
            No diaExtraSim = new No("Eba! Vamos ficar mais um dia", valoresExistentes: new List<Valoracao> { profundidade6 }, valoresNecessarios: new List<Valoracao> { profundidade7 });
            No diaExtraNao = new No("Acho melhor irmos, temos muito o que resolver em casa", valoresExistentes: new List<Valoracao> { profundidade6 }, valoresNecessarios: new List<Valoracao> { profundidade7 });

            // Fim da viagem
            No final = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças", true, valoresExistentes: new List<Valoracao> { profundidade7 });


            // Todos os nós que podem existir
            List<No> todosNosPossiveis = new List<No> { raiz, gramado, natal, veiculo, carro, aviao, hospedagem, hotel, casa, aleatoriedades,
            r_carro_bom, r_carro_neutro, r_carro_ruim, r_aviao_bom, r_aviao_neutro, r_aviao_ruim, r_hotel_bom, r_hotel_neutro, r_hotel_ruim,
            r_casa_bom, r_casa_neutro, r_casa_ruim, volta, voltaAviao, voltaCarro, diaExtraNao, diaExtraSim, final};


            ArvoreDinamica ad = new ArvoreDinamica(null, todosNosPossiveis);
            ad.noAtual = raiz;
            // Final da narrativa
            DateTime tempoFinal = DateTime.Now;
            double tempoUsado = (tempoFinal - tempoInicial).TotalMilliseconds;

            while (!ad.noAtual.final)
            {
                Console.WriteLine(ad.noAtual.nome);
                ad.AdicionarGlobais(ad.noAtual);
                ad.FazerLigacao(ad.noAtual);
                ad.noAtual = ad.EscolherLigacao(ad.noAtual);
                if (ad.noAtual == null)
                    break;
            }
            Console.WriteLine(GC.GetTotalMemory(false));

            if (ad.noAtual != null)
                Console.WriteLine(ad.noAtual.nome);

            Console.WriteLine("Fim de jogo!");

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
            // Contagem de linhas entre o inicio e fim da narrativa (estão demarcados no código) removendo comentários e linhas vazias através do programa Notepad++
            // Para achar o inicio e fim da narrativa procurar por: "// Inicio da narrativa" e "// Final da narrativa".

            // Contagem de dados e repetições:
            // Os dados foram contados manualmente durante a construção da árvore neste código (contagem de objetos)
            // A repetição foi calculada por número de dados que contenham o mesmo valor (nome) do que outros 

        }

        private void OldExemplo()
        {
            Valoracao profundidade0 = new Valoracao(new Profundidade(), 0);
            Valoracao profundidade1 = new Valoracao(new Profundidade(), 1);
            Valoracao profundidade2 = new Valoracao(new Profundidade(), 2);
            Valoracao profundidade3 = new Valoracao(new Profundidade(), 3);

            No raiz = new No("Durante uma viagem seu GPS apresenta duas direções para seguir, qual você escolhe?", valoresNecessarios: new List<Valoracao> { profundidade0 });

            No esquerda = new No("Ir pelo caminho da esquerda", valoresNecessarios: new List<Valoracao> { profundidade1, profundidade2 }, valoresExistentes: new List<Valoracao> { profundidade0 });
            No direita = new No("Ir pelo caminho da direita", valoresNecessarios: new List<Valoracao> { profundidade1 }, valoresExistentes: new List<Valoracao> { profundidade0 });

            No continuar = new No("Foi uma ótima escolha, continuarei por este caminho", random: false, valoresNecessarios: new List<Valoracao> { profundidade2 }, valoresExistentes: new List<Valoracao> { profundidade1});
            No voltar = new No("Avistei um retorno, acho que vou voltar e ir pelo outro caminho", random: false, valoresNecessarios: new List<Valoracao> { profundidade2 }, valoresExistentes: new List<Valoracao> { profundidade1 });

            No gps = new No("Cheguei ao destino. Gostei do caminho, vou salvá-lo no meu gps!", true, valoresExistentes: new List<Valoracao> { profundidade2 });
            No outro = new No("Cheguei ao destino. Não gostei desse caminho, na próxima vou pelo outro!", true, valoresExistentes: new List<Valoracao> { profundidade2});

            List<No> todosNosPossiveis = new List<No> { raiz, esquerda, direita, continuar, voltar, gps, outro };


            ArvoreDinamica ad = new ArvoreDinamica(null, todosNosPossiveis);
            ad.noAtual = raiz;

            while (!ad.noAtual.final)
            {
                Console.WriteLine(ad.noAtual.nome);
                ad.AdicionarGlobais(ad.noAtual);
                ad.FazerLigacao(ad.noAtual);
                ad.noAtual = ad.EscolherLigacao(ad.noAtual);
                if (ad.noAtual == null)
                    break;
            }

            if (ad.noAtual != null)
                Console.WriteLine(ad.noAtual.nome);
            Console.WriteLine("Fim de jogo!");
        }
    }
}
