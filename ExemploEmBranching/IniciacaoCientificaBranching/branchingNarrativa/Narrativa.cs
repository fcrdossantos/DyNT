using IniciacaoCientificaBranching.branchingEstrutura;
using IniciacaoCientificaBranching.branchingEstrutura.nos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingNarrativa
{
    public static class Narrativa
    {
        /// <summary>
        /// Recupera a árvore com a narrativa pronta
        /// </summary>
        public static Arvore GetNarrativa()
        {
            Arvore narrativa = new Arvore();
            No raiz = narrativa.noRaiz = new No(new Escolha("Está na hora da viagem em familia, qual será nosso destino desta vez?")); // Método inline de instanciar um nó e escolha

            // Gramado-Carro-Hotel-Bom-Bom-Sim
            No gramado = new No("Vamos para Gramado"); // Método facil de instanciar um nó com escolha
            raiz.Ligacoes.Add(gramado);
            No veiculo = new No("Agora precisamos decidir com qual veículos vamos: ");
            gramado.Ligacoes.Add(veiculo);
            No carro = new No("Vamos com nosso carro");
            veiculo.Ligacoes.Add(carro);
            No hospedagem = new No("Ótimo! Agora só falta definir a hospedagem");
            carro.Ligacoes.Add(hospedagem);
            No hotel = new No("Vamos ficar em um hotel");
            hospedagem.Ligacoes.Add(hotel);
            No aleatoriedade = new No("Chegamos no nosso destino\n");
            hotel.Ligacoes.Add(aleatoriedade);
            No carroBom = new No("Deu tudo certo no passeio, paramos em um posto na estrada e tinha muitos doces!", true);
            aleatoriedade.Ligacoes.Add(carroBom);
            No hotelBom = new No("Esse hotel é fantástico! Adorei a piscina", true);
            carroBom.Ligacoes.Add(hotelBom);
            No volta = new No("\nUma semana depois...");
            hotelBom.Ligacoes.Add(volta);
            No voltaCarro = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta.Ligacoes.Add(voltaCarro);
            No sim = new No("Eba! Vamos ficar mais um dia");
            voltaCarro.Ligacoes.Add(sim);
            No final = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim.Ligacoes.Add(final);

            // Gramado-Carro-Hotel-Bom-Bom-Não
            No nao = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro.Ligacoes.Add(nao);

            No final2 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao.Ligacoes.Add(final2);

            // Gramado-Carro-Hotel-Bom-Neutro-Sim
            No hotelNeutro = new No("O hotel aqui até que é legal", true);
            carroBom.Ligacoes.Add(hotelNeutro);
            No volta2 = new No("\nUma semana depois...");
            hotelNeutro.Ligacoes.Add(volta2);
            No voltaCarro2 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta2.Ligacoes.Add(voltaCarro2);
            No sim2 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro2.Ligacoes.Add(sim2);
            No final3 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim2.Ligacoes.Add(final3);

            // Gramado-Carro-Hotel-Bom-Neutro-Não
            No nao2 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro2.Ligacoes.Add(nao2);
            No final4 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao2.Ligacoes.Add(final4);

            // Gramado-Carro-Hotel-Bom-Ruim-Sim
            No hotelRuim = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            carroBom.Ligacoes.Add(hotelRuim);
            No volta3 = new No("\nUma semana depois...");
            hotelRuim.Ligacoes.Add(volta3);
            No voltaCarro3 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta3.Ligacoes.Add(voltaCarro3);
            No sim3 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro3.Ligacoes.Add(sim3);
            No final5 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim3.Ligacoes.Add(final5);

            // Gramado-Carro-Hotel-Bom-Ruim-Não
            No nao3 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro3.Ligacoes.Add(nao3);
            No final6 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao3.Ligacoes.Add(final6);


            // Gramado-Carro-Hotel-Neutro-Bom-Sim
            No carroNeutro = new No("O passeio de carro foi normal", true);
            aleatoriedade.Ligacoes.Add(carroNeutro);
            No hotelBom2 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            carroNeutro.Ligacoes.Add(hotelBom2);
            No volta4 = new No("\nUma semana depois...");
            hotelBom2.Ligacoes.Add(volta4);
            No voltaCarro4 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta4.Ligacoes.Add(voltaCarro4);
            No sim4 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro4.Ligacoes.Add(sim4);
            No final7 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim4.Ligacoes.Add(final7);

            // Gramado-Carro-Hotel-Neutro-Bom-Não
            No nao4 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro4.Ligacoes.Add(nao);
            No final8 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao4.Ligacoes.Add(final8);

            // Gramado-Carro-Hotel-Neutro-Neutro-Sim
            No hotelNeutro2 = new No("O hotel aqui até que é legal", true);
            carroNeutro.Ligacoes.Add(hotelNeutro2);
            No volta5 = new No("\nUma semana depois...");
            hotelNeutro2.Ligacoes.Add(volta5);
            No voltaCarro5 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta5.Ligacoes.Add(voltaCarro5);
            No sim5 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro5.Ligacoes.Add(sim5);
            No final9 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim5.Ligacoes.Add(final9);

            // Gramado-Carro-Hotel-Neutro-Neutro-Não
            No nao5 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro5.Ligacoes.Add(nao5);
            No final10 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao5.Ligacoes.Add(final10);

            // Gramado-Carro-Hotel-Neutro-Ruim-Sim
            No hotelRuim2 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            carroNeutro.Ligacoes.Add(hotelRuim2);
            No volta6 = new No("\nUma semana depois...");
            hotelRuim2.Ligacoes.Add(volta6);
            No voltaCarro6 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta6.Ligacoes.Add(voltaCarro6);
            No sim6 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro6.Ligacoes.Add(sim6);
            No final11 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim6.Ligacoes.Add(final11);

            // Gramado-Carro-Hotel-Neutro-Ruim-Não
            No nao6 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro6.Ligacoes.Add(nao6);
            No final12 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao6.Ligacoes.Add(final12);

            // Gramado-Carro-Hotel-Ruim-Bom-Sim
            No carroRuim = new No("A viagem de carro foi péssima! A estrada estava esburacada e o pneu furou", true);
            aleatoriedade.Ligacoes.Add(carroRuim);
            No hotelBom3 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            carroRuim.Ligacoes.Add(hotelBom3);
            No volta7 = new No("\nUma semana depois...");
            hotelBom3.Ligacoes.Add(volta7);
            No voltaCarro7 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta7.Ligacoes.Add(voltaCarro7);
            No sim7 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro7.Ligacoes.Add(sim7);
            No final13 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim7.Ligacoes.Add(final13);

            // Gramado-Carro-Hotel-Ruim-Bom-Não
            No nao7 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro7.Ligacoes.Add(nao);
            No final14 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao7.Ligacoes.Add(final14);

            // Gramado-Carro-Hotel-Ruim-Neutro-Sim
            No hotelNeutro3 = new No("O hotel aqui até que é legal", true);
            carroRuim.Ligacoes.Add(hotelNeutro3);
            No volta8 = new No("\nUma semana depois...");
            hotelNeutro3.Ligacoes.Add(volta8);
            No voltaCarro8 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta8.Ligacoes.Add(voltaCarro8);
            No sim8 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro8.Ligacoes.Add(sim8);
            No final15 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim8.Ligacoes.Add(final15);

            // Gramado-Carro-Hotel-Ruim-Neutro-Não
            No nao8 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro8.Ligacoes.Add(nao8);
            No final16 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao8.Ligacoes.Add(final16);

            // Gramado-Carro-Hotel-Ruim-Ruim-Sim
            No hotelRuim3 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            carroRuim.Ligacoes.Add(hotelRuim3);
            No volta9 = new No("\nUma semana depois...");
            hotelRuim3.Ligacoes.Add(volta9);
            No voltaCarro9 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta9.Ligacoes.Add(voltaCarro9);
            No sim9 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro9.Ligacoes.Add(sim9);
            No final17 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim9.Ligacoes.Add(final17);

            // Gramado-Carro-Hotel-Ruim-Ruim-Não
            No nao9 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro9.Ligacoes.Add(nao9);
            No final18 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao9.Ligacoes.Add(final18);

            // Gramado-Carro-Casa-Bom-Bom-Sim
            No casa = new No("Vamos para a casa de um amigo");
            hospedagem.Ligacoes.Add(casa);
            No aleatoriedade2 = new No("Chegamos no nosso destino\n");
            casa.Ligacoes.Add(aleatoriedade2);
            No carroBom2 = new No("Deu tudo certo no passeio, paramos em um posto na estrada e tinha muitos doces!", true);
            aleatoriedade2.Ligacoes.Add(carroBom2);
            No casaBom = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            carroBom2.Ligacoes.Add(casaBom);
            No volta10 = new No("\nUma semana depois...");
            casaBom.Ligacoes.Add(volta10);
            No voltaCarro10 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta10.Ligacoes.Add(voltaCarro10);
            No sim10 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro10.Ligacoes.Add(sim10);
            No final19 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim10.Ligacoes.Add(final19);

            // Gramado-Carro-Casa-Bom-Bom-Não
            No nao10 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro10.Ligacoes.Add(nao10);
            No final20 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao10.Ligacoes.Add(final20);

            // Gramado-Carro-Casa-Bom-Neutro-Sim
            No casaNeutro = new No("A casa dos nossos amigos até que está legal", true);
            carroBom2.Ligacoes.Add(casaNeutro);
            No volta11 = new No("\nUma semana depois...");
            casaNeutro.Ligacoes.Add(volta11);
            No voltaCarro11 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta11.Ligacoes.Add(voltaCarro11);
            No sim11 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro11.Ligacoes.Add(sim11);
            No final21 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim11.Ligacoes.Add(final21);

            // Gramado-Carro-Casa-Bom-Neutro-Não
            No nao11 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro11.Ligacoes.Add(nao11);
            No final22 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao11.Ligacoes.Add(final22);

            // Gramado-Carro-Casa-Bom-Ruim-Sim
            No casaRuim = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            carroBom2.Ligacoes.Add(casaRuim);
            No volta12 = new No("\nUma semana depois...");
            casaRuim.Ligacoes.Add(volta12);
            No voltaCarro12 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta12.Ligacoes.Add(voltaCarro12);
            No sim12 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro12.Ligacoes.Add(sim12);
            No final23 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim12.Ligacoes.Add(final23);

            // Gramado-Carro-Casa-Bom-Ruim-Não
            No nao12 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro12.Ligacoes.Add(nao12);
            No final24 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao12.Ligacoes.Add(final24);


            // Gramado-Carro-Casa-Neutro-Bom-Sim
            No carroNeutro2 = new No("O passeio de carro foi normal", true);
            aleatoriedade2.Ligacoes.Add(carroNeutro2);
            No casaBom2 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            carroNeutro2.Ligacoes.Add(casaBom2);
            No volta13 = new No("\nUma semana depois...");
            casaBom2.Ligacoes.Add(volta13);
            No voltaCarro13 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta13.Ligacoes.Add(voltaCarro13);
            No sim13 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro13.Ligacoes.Add(sim13);
            No final25 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim13.Ligacoes.Add(final25);

            // Gramado-Carro-Casa-Neutro-Bom-Não
            No nao13 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro13.Ligacoes.Add(nao13);
            No final26 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao13.Ligacoes.Add(final26);

            // Gramado-Carro-Casa-Neutro-Neutro-Sim
            No casaNeutro2 = new No("A casa dos nossos amigos até que está legal", true);
            carroNeutro2.Ligacoes.Add(casaNeutro2);
            No volta14 = new No("\nUma semana depois...");
            casaNeutro2.Ligacoes.Add(volta14);
            No voltaCarro14 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta14.Ligacoes.Add(voltaCarro14);
            No sim14 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro14.Ligacoes.Add(sim14);
            No final27 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim14.Ligacoes.Add(final27);

            // Gramado-Carro-Casa-Neutro-Neutro-Não
            No nao14 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro14.Ligacoes.Add(nao14);
            No final28 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao14.Ligacoes.Add(final28);

            // Gramado-Carro-Casa-Neutro-Ruim-Sim
            No casaRuim2 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            carroNeutro2.Ligacoes.Add(casaRuim2);
            No volta15 = new No("\nUma semana depois...");
            casaRuim2.Ligacoes.Add(volta15);
            No voltaCarro15 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta15.Ligacoes.Add(voltaCarro15);
            No sim15 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro15.Ligacoes.Add(sim15);
            No final29 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim15.Ligacoes.Add(final29);

            // Gramado-Carro-Casa-Neutro-Ruim-Não
            No nao15 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro15.Ligacoes.Add(nao15);
            No final30 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao15.Ligacoes.Add(final30);

            // Gramado-Carro-Casa-Ruim-Bom-Sim
            No CarroRuim2 = new No("A viagem de carro foi péssima! A estrada estava esburacada e o pneu furou", true);
            aleatoriedade2.Ligacoes.Add(CarroRuim2);
            No casaBom3 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            CarroRuim2.Ligacoes.Add(casaBom3);
            No volta16 = new No("\nUma semana depois...");
            casaBom3.Ligacoes.Add(volta16);
            No voltaCarro16 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta16.Ligacoes.Add(voltaCarro16);
            No sim16 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro16.Ligacoes.Add(sim16);
            No final31 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim16.Ligacoes.Add(final31);

            // Gramado-Carro-Casa-Ruim-Bom-Não
            No nao16 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro16.Ligacoes.Add(nao16);
            No final32 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao16.Ligacoes.Add(final32);

            // Gramado-Carro-Casa-Ruim-Neutro-Sim
            No casaNeutro3 = new No("A casa dos nossos amigos até que está legal", true);
            CarroRuim2.Ligacoes.Add(casaNeutro3);
            No volta17 = new No("\nUma semana depois...");
            casaNeutro3.Ligacoes.Add(volta17);
            No voltaCarro17 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta17.Ligacoes.Add(voltaCarro17);
            No sim17 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro17.Ligacoes.Add(sim17);
            No final33 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim17.Ligacoes.Add(final33);

            // Gramado-Carro-Casa-Ruim-Neutro-Não
            No nao17 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro17.Ligacoes.Add(nao17);
            No final34 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao17.Ligacoes.Add(final34);

            // Gramado-Carro-Casa-Ruim-Ruim-Sim
            No casaRuim3 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            CarroRuim2.Ligacoes.Add(casaRuim3);
            No volta18 = new No("\nUma semana depois...");
            casaRuim3.Ligacoes.Add(volta18);
            No voltaCarro18 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            volta18.Ligacoes.Add(voltaCarro18);
            No sim18 = new No("Eba! Vamos ficar mais um dia");
            voltaCarro18.Ligacoes.Add(sim18);
            No final35 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            sim18.Ligacoes.Add(final35);

            // Gramado-Carro-Casa-Ruim-Ruim-Não
            No nao18 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            voltaCarro18.Ligacoes.Add(nao18);
            No final36 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nao18.Ligacoes.Add(final36);

            // Gramado-Aviao-Hotel-Bom-Bom
            No aviao = new No("Ir de Avião seria legal");
            veiculo.Ligacoes.Add(aviao);
            No hospedagem2 = new No("Ótimo! Agora só falta definir a hospedagem");
            aviao.Ligacoes.Add(hospedagem2);
            No hotel2 = new No("Vamos ficar em um hotel");
            hospedagem2.Ligacoes.Add(hotel2);
            No aleatoriedade3 = new No("Chegamos no nosso destino\n");
            hotel2.Ligacoes.Add(aleatoriedade3);
            No aviaoBom = new No("Uau! Ganhamos uma passagem primeira classe no voo", true);
            aleatoriedade3.Ligacoes.Add(aviaoBom);
            No hotelBom4 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            aviaoBom.Ligacoes.Add(hotelBom4);
            No volta19 = new No("\nUma semana depois...");
            hotelBom4.Ligacoes.Add(volta19);
            No voltaaviao = new No("Está na hora de voltar para casa");
            volta19.Ligacoes.Add(voltaaviao);
            No final37 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao.Ligacoes.Add(final37);

            // Gramado-Aviao-Hotel-Bom-Neutro
            No hotelNeutro4 = new No("O hotel aqui até que é legal", true);
            aviaoBom.Ligacoes.Add(hotelNeutro4);
            No volta20 = new No("\nUma semana depois...");
            hotelNeutro4.Ligacoes.Add(volta20);
            No voltaaviao2 = new No("Está na hora de voltar para casa");
            volta20.Ligacoes.Add(voltaaviao2);
            No final38 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao2.Ligacoes.Add(final38);

            // Gramado-Aviao-Hotel-Bom-Ruim
            No hotelRuim4 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            aviaoBom.Ligacoes.Add(hotelRuim4);
            No volta21 = new No("\nUma semana depois...");
            hotelRuim4.Ligacoes.Add(volta21);
            No voltaaviao3 = new No("Está na hora de voltar para casa");
            volta21.Ligacoes.Add(voltaaviao3);
            No final39 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao3.Ligacoes.Add(final39);


            // Gramado-Aviao-Hotel-Neutro-Bom
            No aviaoNeutro = new No("A viagem de avião foi normal", true);
            aleatoriedade3.Ligacoes.Add(aviaoNeutro);
            No hotelBom5 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            aviaoNeutro.Ligacoes.Add(hotelBom5);
            No volta22 = new No("\nUma semana depois...");
            hotelBom5.Ligacoes.Add(volta22);
            No voltaaviao4 = new No("Está na hora de voltar para casa");
            volta22.Ligacoes.Add(voltaaviao4);
            No final40 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao4.Ligacoes.Add(final40);

            // Gramado-Aviao-Hotel-Neutro-Neutro
            No hotelNeutro5 = new No("O hotel aqui até que é legal", true);
            aviaoNeutro.Ligacoes.Add(hotelNeutro5);
            No volta23 = new No("\nUma semana depois...");
            hotelNeutro5.Ligacoes.Add(volta23);
            No voltaaviao5 = new No("Está na hora de voltar para casa");
            volta23.Ligacoes.Add(voltaaviao5);
            No final41 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao5.Ligacoes.Add(final41);

            // Gramado-Aviao-Hotel-Neutro-Ruim
            No hotelRuim5 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            aviaoNeutro.Ligacoes.Add(hotelRuim5);
            No volta24 = new No("\nUma semana depois...");
            hotelRuim5.Ligacoes.Add(volta24);
            No voltaaviao6 = new No("Está na hora de voltar para casa");
            volta24.Ligacoes.Add(voltaaviao6);
            No final42 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao6.Ligacoes.Add(final42);

            // Gramado-Aviao-Hotel-Ruim-Bom
            No aviaoRuim = new No("O voo foi horrível e ainda por cima atrasou", true);
            aleatoriedade3.Ligacoes.Add(aviaoRuim);
            No hotelBom6 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            aviaoRuim.Ligacoes.Add(hotelBom6);
            No volta25 = new No("\nUma semana depois...");
            hotelBom6.Ligacoes.Add(volta25);
            No voltaaviao7 = new No("Está na hora de voltar para casa");
            volta25.Ligacoes.Add(voltaaviao7);
            No final43 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao7.Ligacoes.Add(final43);

            // Gramado-Aviao-Hotel-Ruim-Neutro
            No hotelNeutro6 = new No("O hotel aqui até que é legal", true);
            aviaoRuim.Ligacoes.Add(hotelNeutro6);
            No volta26 = new No("\nUma semana depois...");
            hotelNeutro6.Ligacoes.Add(volta26);
            No voltaaviao8 = new No("Está na hora de voltar para casa");
            volta26.Ligacoes.Add(voltaaviao8);
            No final44 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao8.Ligacoes.Add(final44);

            // Gramado-Aviao-Hotel-Ruim-Ruim
            No hotelRuim6 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            aviaoRuim.Ligacoes.Add(hotelRuim6);
            No volta27 = new No("\nUma semana depois...");
            hotelRuim6.Ligacoes.Add(volta27);
            No voltaaviao9 = new No("Está na hora de voltar para casa");
            volta27.Ligacoes.Add(voltaaviao9);
            No final45 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao9.Ligacoes.Add(final45);

            // Gramado-Aviao-Casa-Bom-Bom
            No casa2 = new No("Vamos para a casa de um amigo");
            hospedagem2.Ligacoes.Add(casa2);
            No aleatoriedade4 = new No("Chegamos no nosso destino\n");
            casa2.Ligacoes.Add(aleatoriedade4);
            No aviaoBom2 = new No("Uau! Ganhamos uma passagem primeira classe no voo", true);
            aleatoriedade4.Ligacoes.Add(aviaoBom2);
            No casaBom4 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            aviaoBom2.Ligacoes.Add(casaBom4);
            No volta28 = new No("\nUma semana depois...");
            casaBom4.Ligacoes.Add(volta28);
            No voltaaviao10 = new No("Está na hora de voltar para casa");
            volta28.Ligacoes.Add(voltaaviao10);
            No final46 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao10.Ligacoes.Add(final46);

            // Gramado-Aviao-Casa-Bom-Neutro
            No casaNeutro4 = new No("A casa dos nossos amigos até que está legal", true);
            aviaoBom2.Ligacoes.Add(casaNeutro4);
            No volta29 = new No("\nUma semana depois...");
            casaNeutro4.Ligacoes.Add(volta29);
            No voltaaviao11 = new No("Está na hora de voltar para casa");
            volta29.Ligacoes.Add(voltaaviao11);
            No final47 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            volta29.Ligacoes.Add(final47);

            // Gramado-Aviao-Casa-Bom-Ruim
            No casaRuim4 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            aviaoBom2.Ligacoes.Add(casaRuim4);
            No volta30 = new No("\nUma semana depois...");
            casaRuim4.Ligacoes.Add(volta30);
            No voltaaviao12 = new No("Está na hora de voltar para casa");
            volta30.Ligacoes.Add(voltaaviao12);
            No final48 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao12.Ligacoes.Add(final48);


            // Gramado-Aviao-Casa-Neutro-Bom
            No aviaoNeutro2 = new No("A viagem de avião foi normal", true);
            aleatoriedade4.Ligacoes.Add(aviaoNeutro2);
            No casaBom5 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            aviaoNeutro2.Ligacoes.Add(casaBom5);
            No volta31 = new No("\nUma semana depois...");
            casaBom5.Ligacoes.Add(volta31);
            No voltaaviao13 = new No("Está na hora de voltar para casa");
            volta31.Ligacoes.Add(voltaaviao13);
            No final49 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao13.Ligacoes.Add(final49);

            // Gramado-Aviao-Casa-Neutro-Neutro
            No casaNeutro5 = new No("A casa dos nossos amigos até que está legal", true);
            aviaoNeutro2.Ligacoes.Add(casaNeutro5);
            No volta32 = new No("\nUma semana depois...");
            casaNeutro5.Ligacoes.Add(volta32);
            No voltaaviao14 = new No("Está na hora de voltar para casa");
            volta32.Ligacoes.Add(voltaaviao14);
            No final50 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao14.Ligacoes.Add(final50);

            // Gramado-Aviao-Casa-Neutro-Ruim
            No casaRuim5 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            aviaoNeutro2.Ligacoes.Add(casaRuim5);
            No volta33 = new No("\nUma semana depois...");
            casaRuim5.Ligacoes.Add(volta33);
            No voltaaviao15 = new No("Está na hora de voltar para casa");
            volta33.Ligacoes.Add(voltaaviao15);
            No final51 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao15.Ligacoes.Add(final51);

            // Gramado-Aviao-Casa-Ruim-Bom
            No aviaoRuim2 = new No("O voo foi horrível e ainda por cima atrasou", true);
            aleatoriedade4.Ligacoes.Add(aviaoRuim2);
            No casaBom6 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            aviaoRuim2.Ligacoes.Add(casaBom6);
            No volta34 = new No("\nUma semana depois...");
            casaBom6.Ligacoes.Add(volta34);
            No voltaaviao16 = new No("Está na hora de voltar para casa");
            volta34.Ligacoes.Add(voltaaviao16);
            No final52 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao16.Ligacoes.Add(final52);

            // Gramado-Aviao-Casa-Ruim-Neutro
            No casaNeutro6 = new No("A casa dos nossos amigos até que está legal", true);
            aviaoRuim2.Ligacoes.Add(casaNeutro6);
            No volta35 = new No("\nUma semana depois...");
            casaNeutro6.Ligacoes.Add(volta35);
            No voltaaviao17 = new No("Está na hora de voltar para casa");
            volta35.Ligacoes.Add(voltaaviao17);
            No final53 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao17.Ligacoes.Add(final53);

            // Gramado-Aviao-Casa-Ruim-Ruim
            No casaRuim6 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            aviaoRuim2.Ligacoes.Add(casaRuim6);
            No volta36 = new No("\nUma semana depois...");
            casaRuim6.Ligacoes.Add(volta36);
            No voltaaviao18 = new No("Está na hora de voltar para casa");
            volta36.Ligacoes.Add(voltaaviao18);
            No final54 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            voltaaviao18.Ligacoes.Add(final54);

            // Natal-Carro-Hotel-Bom-Bom-Sim
            No natal = new No("Vamos para Natal"); // Método facil de instanciar um nó com escolha
            raiz.Ligacoes.Add(natal);
            No nt_veiculo = new No("Agora precisamos decidir com qual veículos vamos: ");
            natal.Ligacoes.Add(nt_veiculo);
            No nt_carro = new No("Vamos com nosso carro");
            nt_veiculo.Ligacoes.Add(nt_carro);
            No nt_hospedagem = new No("Ótimo! Agora só falta definir a hospedagem");
            nt_carro.Ligacoes.Add(nt_hospedagem);
            No nt_hotel = new No("Vamos ficar em um hotel");
            nt_hospedagem.Ligacoes.Add(nt_hotel);
            No nt_aleatoriedade = new No("Chegamos no nosso destino\n");
            nt_hotel.Ligacoes.Add(nt_aleatoriedade);
            No nt_carroBom = new No("Deu tudo certo no passeio, paramos em um posto na estrada e tinha muitos doces!", true);
            nt_aleatoriedade.Ligacoes.Add(nt_carroBom);
            No nt_hotelBom = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_carroBom.Ligacoes.Add(nt_hotelBom);
            No nt_volta = new No("\nUma semana depois...");
            nt_hotelBom.Ligacoes.Add(nt_volta);
            No nt_voltaCarro = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta.Ligacoes.Add(nt_voltaCarro);
            No nt_sim = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro.Ligacoes.Add(nt_sim);
            No nt_final = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim.Ligacoes.Add(nt_final);

            // Natal-Carro-Hotel-Bom-Bom-Não
            No nt_nao = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro.Ligacoes.Add(nt_nao);
            No nt_final2 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao.Ligacoes.Add(nt_final2);

            // Natal-Carro-Hotel-Bom-Neutro-Sim
            No nt_hotelNeutro = new No("O hotel aqui até que é legal", true);
            nt_carroBom.Ligacoes.Add(nt_hotelNeutro);
            No nt_volta2 = new No("\nUma semana depois...");
            nt_hotelNeutro.Ligacoes.Add(nt_volta2);
            No nt_voltaCarro2 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta2.Ligacoes.Add(nt_voltaCarro2);
            No nt_sim2 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro2.Ligacoes.Add(nt_sim2);
            No nt_final3 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim2.Ligacoes.Add(nt_final3);

            // Natal-Carro-Hotel-Bom-Neutro-Não
            No nt_nao2 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro2.Ligacoes.Add(nt_nao2);
            No nt_final4 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao2.Ligacoes.Add(nt_final4);

            // Natal-Carro-Hotel-Bom-Ruim-Sim
            No nt_hotelRuim = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_carroBom.Ligacoes.Add(nt_hotelRuim);
            No nt_volta3 = new No("\nUma semana depois...");
            nt_hotelRuim.Ligacoes.Add(nt_volta3);
            No nt_voltaCarro3 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta3.Ligacoes.Add(nt_voltaCarro3);
            No nt_sim3 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro3.Ligacoes.Add(nt_sim3);
            No nt_final5 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim3.Ligacoes.Add(nt_final5);

            // Natal-Carro-Hotel-Bom-Ruim-Não
            No nt_nao3 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro3.Ligacoes.Add(nt_nao3);
            No nt_final6 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao3.Ligacoes.Add(nt_final6);


            // Natal-Carro-Hotel-Neutro-Bom-Sim
            No nt_carroNeutro = new No("O passeio de carro foi normal", true);
            nt_aleatoriedade.Ligacoes.Add(nt_carroNeutro);
            No nt_hotelBom2 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_carroNeutro.Ligacoes.Add(nt_hotelBom2);
            No nt_volta4 = new No("\nUma semana depois...");
            nt_hotelBom2.Ligacoes.Add(nt_volta4);
            No nt_voltaCarro4 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta4.Ligacoes.Add(nt_voltaCarro4);
            No nt_sim4 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro4.Ligacoes.Add(nt_sim4);
            No nt_final7 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim4.Ligacoes.Add(nt_final7);

            // Natal-Carro-Hotel-Neutro-Bom-Não
            No nt_nao4 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro4.Ligacoes.Add(nt_nao);
            No nt_final8 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao4.Ligacoes.Add(nt_final8);

            // Natal-Carro-Hotel-Neutro-Neutro-Sim
            No nt_hotelNeutro2 = new No("O hotel aqui até que é legal", true);
            nt_carroNeutro.Ligacoes.Add(nt_hotelNeutro2);
            No nt_volta5 = new No("\nUma semana depois...");
            nt_hotelNeutro2.Ligacoes.Add(nt_volta5);
            No nt_voltaCarro5 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta5.Ligacoes.Add(nt_voltaCarro5);
            No nt_sim5 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro5.Ligacoes.Add(nt_sim5);
            No nt_final9 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim5.Ligacoes.Add(nt_final9);

            // Natal-Carro-Hotel-Neutro-Neutro-Não
            No nt_nao5 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro5.Ligacoes.Add(nt_nao5);
            No nt_final10 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao5.Ligacoes.Add(nt_final10);

            // Natal-Carro-Hotel-Neutro-Ruim-Sim
            No nt_hotelRuim2 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_carroNeutro.Ligacoes.Add(nt_hotelRuim2);
            No nt_volta6 = new No("\nUma semana depois...");
            nt_hotelRuim2.Ligacoes.Add(nt_volta6);
            No nt_voltaCarro6 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta6.Ligacoes.Add(nt_voltaCarro6);
            No nt_sim6 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro6.Ligacoes.Add(nt_sim6);
            No nt_final11 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim6.Ligacoes.Add(nt_final11);

            // Natal-Carro-Hotel-Neutro-Ruim-Não
            No nt_nao6 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro6.Ligacoes.Add(nt_nao6);
            No nt_final12 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao6.Ligacoes.Add(nt_final12);

            // Natal-Carro-Hotel-Ruim-Bom-Sim
            No nt_carroRuim = new No("A viagem de carro foi péssima! A estrada estava esburacada e o pneu furou", true);
            nt_aleatoriedade.Ligacoes.Add(nt_carroRuim);
            No nt_hotelBom3 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_carroRuim.Ligacoes.Add(nt_hotelBom3);
            No nt_volta7 = new No("\nUma semana depois...");
            nt_hotelBom3.Ligacoes.Add(nt_volta7);
            No nt_voltaCarro7 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta7.Ligacoes.Add(nt_voltaCarro7);
            No nt_sim7 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro7.Ligacoes.Add(nt_sim7);
            No nt_final13 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim7.Ligacoes.Add(nt_final13);

            // Natal-Carro-Hotel-Ruim-Bom-Não
            No nt_nao7 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro7.Ligacoes.Add(nt_nao);
            No nt_final14 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao7.Ligacoes.Add(nt_final14);

            // Natal-Carro-Hotel-Ruim-Neutro-Sim
            No nt_hotelNeutro3 = new No("O hotel aqui até que é legal", true);
            nt_carroRuim.Ligacoes.Add(nt_hotelNeutro3);
            No nt_volta8 = new No("\nUma semana depois...");
            nt_hotelNeutro3.Ligacoes.Add(nt_volta8);
            No nt_voltaCarro8 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta8.Ligacoes.Add(nt_voltaCarro8);
            No nt_sim8 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro8.Ligacoes.Add(nt_sim8);
            No nt_final15 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim8.Ligacoes.Add(nt_final15);

            // Natal-Carro-Hotel-Ruim-Neutro-Não
            No nt_nao8 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro8.Ligacoes.Add(nt_nao8);
            No nt_final16 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao8.Ligacoes.Add(nt_final16);

            // Natal-Carro-Hotel-Ruim-Ruim-Sim
            No nt_hotelRuim3 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_carroRuim.Ligacoes.Add(nt_hotelRuim3);
            No nt_volta9 = new No("\nUma semana depois...");
            nt_hotelRuim3.Ligacoes.Add(nt_volta9);
            No nt_voltaCarro9 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta9.Ligacoes.Add(nt_voltaCarro9);
            No nt_sim9 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro9.Ligacoes.Add(nt_sim9);
            No nt_final17 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim9.Ligacoes.Add(nt_final17);

            // Natal-Carro-Hotel-Ruim-Ruim-Não
            No nt_nao9 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro9.Ligacoes.Add(nt_nao9);
            No nt_final18 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao9.Ligacoes.Add(nt_final18);

            // Natal-Carro-Casa-Bom-Bom-Sim
            No nt_casa = new No("Vamos para a casa de um amigo");
            nt_hospedagem.Ligacoes.Add(nt_casa);
            No nt_aleatoriedade2 = new No("Chegamos no nosso destino\n");
            nt_casa.Ligacoes.Add(nt_aleatoriedade2);
            No nt_carroBom2 = new No("Deu tudo certo no passeio, paramos em um posto na estrada e tinha muitos doces!", true);
            nt_aleatoriedade2.Ligacoes.Add(nt_carroBom2);
            No nt_casaBom = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_carroBom2.Ligacoes.Add(nt_casaBom);
            No nt_volta10 = new No("\nUma semana depois...");
            nt_casaBom.Ligacoes.Add(nt_volta10);
            No nt_voltaCarro10 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta10.Ligacoes.Add(nt_voltaCarro10);
            No nt_sim10 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro10.Ligacoes.Add(nt_sim10);
            No nt_final19 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim10.Ligacoes.Add(nt_final19);

            // Natal-Carro-Casa-Bom-Bom-Não
            No nt_nao10 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro10.Ligacoes.Add(nt_nao10);
            No nt_final20 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao10.Ligacoes.Add(nt_final20);

            // Natal-Carro-Casa-Bom-Neutro-Sim
            No nt_casaNeutro = new No("A casa dos nossos amigos até que está legal", true);
            nt_carroBom2.Ligacoes.Add(nt_casaNeutro);
            No nt_volta11 = new No("\nUma semana depois...");
            nt_casaNeutro.Ligacoes.Add(nt_volta11);
            No nt_voltaCarro11 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta11.Ligacoes.Add(nt_voltaCarro11);
            No nt_sim11 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro11.Ligacoes.Add(nt_sim11);
            No nt_final21 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim11.Ligacoes.Add(nt_final21);

            // Natal-Carro-Casa-Bom-Neutro-Não
            No nt_nao11 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro11.Ligacoes.Add(nt_nao11);
            No nt_final22 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao11.Ligacoes.Add(nt_final22);

            // Natal-Carro-Casa-Bom-Ruim-Sim
            No nt_casaRuim = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_carroBom2.Ligacoes.Add(nt_casaRuim);
            No nt_volta12 = new No("\nUma semana depois...");
            nt_casaRuim.Ligacoes.Add(nt_volta12);
            No nt_voltaCarro12 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta12.Ligacoes.Add(nt_voltaCarro12);
            No nt_sim12 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro12.Ligacoes.Add(nt_sim12);
            No nt_final23 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim12.Ligacoes.Add(nt_final23);

            // Natal-Carro-Casa-Bom-Ruim-Não
            No nt_nao12 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro12.Ligacoes.Add(nt_nao12);
            No nt_final24 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao12.Ligacoes.Add(nt_final24);


            // Natal-Carro-Casa-Neutro-Bom-Sim
            No nt_carroNeutro2 = new No("O passeio de carro foi normal", true);
            nt_aleatoriedade2.Ligacoes.Add(nt_carroNeutro2);
            No nt_casaBom2 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_carroNeutro2.Ligacoes.Add(nt_casaBom2);
            No nt_volta13 = new No("\nUma semana depois...");
            nt_casaBom2.Ligacoes.Add(nt_volta13);
            No nt_voltaCarro13 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta13.Ligacoes.Add(nt_voltaCarro13);
            No nt_sim13 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro13.Ligacoes.Add(nt_sim13);
            No nt_final25 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim13.Ligacoes.Add(nt_final25);

            // Natal-Carro-Casa-Neutro-Bom-Não
            No nt_nao13 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro13.Ligacoes.Add(nt_nao13);
            No nt_final26 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao13.Ligacoes.Add(nt_final26);

            // Natal-Carro-Casa-Neutro-Neutro-Sim
            No nt_casaNeutro2 = new No("A casa dos nossos amigos até que está legal", true);
            nt_carroNeutro2.Ligacoes.Add(nt_casaNeutro2);
            No nt_volta14 = new No("\nUma semana depois...");
            nt_casaNeutro2.Ligacoes.Add(nt_volta14);
            No nt_voltaCarro14 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta14.Ligacoes.Add(nt_voltaCarro14);
            No nt_sim14 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro14.Ligacoes.Add(nt_sim14);
            No nt_final27 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim14.Ligacoes.Add(nt_final27);

            // Natal-Carro-Casa-Neutro-Neutro-Não
            No nt_nao14 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro14.Ligacoes.Add(nt_nao14);
            No nt_final28 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao14.Ligacoes.Add(nt_final28);

            // Natal-Carro-Casa-Neutro-Ruim-Sim
            No nt_casaRuim2 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_carroNeutro2.Ligacoes.Add(nt_casaRuim2);
            No nt_volta15 = new No("\nUma semana depois...");
            nt_casaRuim2.Ligacoes.Add(nt_volta15);
            No nt_voltaCarro15 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta15.Ligacoes.Add(nt_voltaCarro15);
            No nt_sim15 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro15.Ligacoes.Add(nt_sim15);
            No nt_final29 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim15.Ligacoes.Add(nt_final29);

            // Natal-Carro-Casa-Neutro-Ruim-Não
            No nt_nao15 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro15.Ligacoes.Add(nt_nao15);
            No nt_final30 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao15.Ligacoes.Add(nt_final30);

            // Natal-Carro-Casa-Ruim-Bom-Sim
            No nt_CarroRuim2 = new No("A viagem de carro foi péssima! A estrada estava esburacada e o pneu furou", true);
            nt_aleatoriedade2.Ligacoes.Add(nt_CarroRuim2);
            No nt_casaBom3 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_CarroRuim2.Ligacoes.Add(nt_casaBom3);
            No nt_volta16 = new No("\nUma semana depois...");
            nt_casaBom3.Ligacoes.Add(nt_volta16);
            No nt_voltaCarro16 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta16.Ligacoes.Add(nt_voltaCarro16);
            No nt_sim16 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro16.Ligacoes.Add(nt_sim16);
            No nt_final31 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim16.Ligacoes.Add(nt_final31);

            // Natal-Carro-Casa-Ruim-Bom-Não
            No nt_nao16 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro16.Ligacoes.Add(nt_nao16);
            No nt_final32 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao16.Ligacoes.Add(nt_final32);

            // Natal-Carro-Casa-Ruim-Neutro-Sim
            No nt_casaNeutro3 = new No("A casa dos nossos amigos até que está legal", true);
            nt_CarroRuim2.Ligacoes.Add(nt_casaNeutro3);
            No nt_volta17 = new No("\nUma semana depois...");
            nt_casaNeutro3.Ligacoes.Add(nt_volta17);
            No nt_voltaCarro17 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta17.Ligacoes.Add(nt_voltaCarro17);
            No nt_sim17 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro17.Ligacoes.Add(nt_sim17);
            No nt_final33 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim17.Ligacoes.Add(nt_final33);

            // Natal-Carro-Casa-Ruim-Neutro-Não
            No nt_nao17 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro17.Ligacoes.Add(nt_nao17);
            No nt_final34 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao17.Ligacoes.Add(nt_final34);

            // Natal-Carro-Casa-Ruim-Ruim-Sim
            No nt_casaRuim3 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_CarroRuim2.Ligacoes.Add(nt_casaRuim3);
            No nt_volta18 = new No("\nUma semana depois...");
            nt_casaRuim3.Ligacoes.Add(nt_volta18);
            No nt_voltaCarro18 = new No("Estaria na hora de voltar para casa, mas o que acha de ficarmos mais um dia?");
            nt_volta18.Ligacoes.Add(nt_voltaCarro18);
            No nt_sim18 = new No("Eba! Vamos ficar mais um dia");
            nt_voltaCarro18.Ligacoes.Add(nt_sim18);
            No nt_final35 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_sim18.Ligacoes.Add(nt_final35);

            // Natal-Carro-Casa-Ruim-Ruim-Não
            No nt_nao18 = new No("Acho melhor irmos, temos muito o que resolver em casa");
            nt_voltaCarro18.Ligacoes.Add(nt_nao18);
            No nt_final36 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_nao18.Ligacoes.Add(nt_final36);

            // Natal-Aviao-Hotel-Bom-Bom
            No nt_aviao = new No("Ir de Avião seria legal");
            nt_veiculo.Ligacoes.Add(nt_aviao);
            No nt_hospedagem2 = new No("Ótimo! Agora só falta definir a hospedagem");
            nt_aviao.Ligacoes.Add(nt_hospedagem2);
            No nt_hotel2 = new No("Vamos ficar em um hotel");
            nt_hospedagem2.Ligacoes.Add(nt_hotel2);
            No nt_aleatoriedade3 = new No("Chegamos no nosso destino\n");
            nt_hotel2.Ligacoes.Add(nt_aleatoriedade3);
            No nt_aviaoBom = new No("Uau! Ganhamos uma passagem primeira classe no voo", true);
            nt_aleatoriedade3.Ligacoes.Add(nt_aviaoBom);
            No nt_hotelBom4 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_aviaoBom.Ligacoes.Add(nt_hotelBom4);
            No nt_volta19 = new No("\nUma semana depois...");
            nt_hotelBom4.Ligacoes.Add(nt_volta19);
            No nt_voltaaviao = new No("Está na hora de voltar para casa");
            nt_volta19.Ligacoes.Add(nt_voltaaviao);
            No nt_final37 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao.Ligacoes.Add(nt_final37);

            // Natal-Aviao-Hotel-Bom-Neutro
            No nt_hotelNeutro4 = new No("O hotel aqui até que é legal", true);
            nt_aviaoBom.Ligacoes.Add(nt_hotelNeutro4);
            No nt_volta20 = new No("\nUma semana depois...");
            nt_hotelNeutro4.Ligacoes.Add(nt_volta20);
            No nt_voltaaviao2 = new No("Está na hora de voltar para casa");
            nt_volta20.Ligacoes.Add(nt_voltaaviao2);
            No nt_final38 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao2.Ligacoes.Add(nt_final38);

            // Natal-Aviao-Hotel-Bom-Ruim
            No nt_hotelRuim4 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_aviaoBom.Ligacoes.Add(nt_hotelRuim4);
            No nt_volta21 = new No("\nUma semana depois...");
            nt_hotelRuim4.Ligacoes.Add(nt_volta21);
            No nt_voltaaviao3 = new No("Está na hora de voltar para casa");
            nt_volta21.Ligacoes.Add(nt_voltaaviao3);
            No nt_final39 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao3.Ligacoes.Add(nt_final39);


            // Natal-Aviao-Hotel-Neutro-Bom
            No nt_aviaoNeutro = new No("A viagem de avião foi normal", true);
            nt_aleatoriedade3.Ligacoes.Add(nt_aviaoNeutro);
            No nt_hotelBom5 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_aviaoNeutro.Ligacoes.Add(nt_hotelBom5);
            No nt_volta22 = new No("\nUma semana depois...");
            nt_hotelBom5.Ligacoes.Add(nt_volta22);
            No nt_voltaaviao4 = new No("Está na hora de voltar para casa");
            nt_volta22.Ligacoes.Add(nt_voltaaviao4);
            No nt_final40 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao4.Ligacoes.Add(nt_final40);

            // Natal-Aviao-Hotel-Neutro-Neutro
            No nt_hotelNeutro5 = new No("O hotel aqui até que é legal", true);
            nt_aviaoNeutro.Ligacoes.Add(nt_hotelNeutro5);
            No nt_volta23 = new No("\nUma semana depois...");
            nt_hotelNeutro5.Ligacoes.Add(nt_volta23);
            No nt_voltaaviao5 = new No("Está na hora de voltar para casa");
            nt_volta23.Ligacoes.Add(nt_voltaaviao5);
            No nt_final41 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao5.Ligacoes.Add(nt_final41);

            // Natal-Aviao-Hotel-Neutro-Ruim
            No nt_hotelRuim5 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_aviaoNeutro.Ligacoes.Add(nt_hotelRuim5);
            No nt_volta24 = new No("\nUma semana depois...");
            nt_hotelRuim5.Ligacoes.Add(nt_volta24);
            No nt_voltaaviao6 = new No("Está na hora de voltar para casa");
            nt_volta24.Ligacoes.Add(nt_voltaaviao6);
            No nt_final42 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao6.Ligacoes.Add(nt_final42);

            // Natal-Aviao-Hotel-Ruim-Bom
            No nt_aviaoRuim = new No("O voo foi horrível e ainda por cima atrasou", true);
            nt_aleatoriedade3.Ligacoes.Add(nt_aviaoRuim);
            No nt_hotelBom6 = new No("Esse hotel é fantástico! Adorei a piscina", true);
            nt_aviaoRuim.Ligacoes.Add(nt_hotelBom6);
            No nt_volta25 = new No("\nUma semana depois...");
            nt_hotelBom6.Ligacoes.Add(nt_volta25);
            No nt_voltaaviao7 = new No("Está na hora de voltar para casa");
            nt_volta25.Ligacoes.Add(nt_voltaaviao7);
            No nt_final43 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao7.Ligacoes.Add(nt_final43);

            // Natal-Aviao-Hotel-Ruim-Neutro
            No nt_hotelNeutro6 = new No("O hotel aqui até que é legal", true);
            nt_aviaoRuim.Ligacoes.Add(nt_hotelNeutro6);
            No nt_volta26 = new No("\nUma semana depois...");
            nt_hotelNeutro6.Ligacoes.Add(nt_volta26);
            No nt_voltaaviao8 = new No("Está na hora de voltar para casa");
            nt_volta26.Ligacoes.Add(nt_voltaaviao8);
            No nt_final44 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao8.Ligacoes.Add(nt_final44);

            // Natal-Aviao-Hotel-Ruim-Ruim
            No nt_hotelRuim6 = new No("Não gostamos nada do hotel, não tinha nem agua quente", true);
            nt_aviaoRuim.Ligacoes.Add(nt_hotelRuim6);
            No nt_volta27 = new No("\nUma semana depois...");
            nt_hotelRuim6.Ligacoes.Add(nt_volta27);
            No nt_voltaaviao9 = new No("Está na hora de voltar para casa");
            nt_volta27.Ligacoes.Add(nt_voltaaviao9);
            No nt_final45 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao9.Ligacoes.Add(nt_final45);

            // Natal-Aviao-Casa-Bom-Bom
            No nt_casa2 = new No("Vamos para a casa de um amigo");
            nt_hospedagem2.Ligacoes.Add(nt_casa2);
            No nt_aleatoriedade4 = new No("Chegamos no nosso destino\n");
            nt_casa2.Ligacoes.Add(nt_aleatoriedade4);
            No nt_aviaoBom2 = new No("Uau! Ganhamos uma passagem primeira classe no voo", true);
            nt_aleatoriedade4.Ligacoes.Add(nt_aviaoBom2);
            No nt_casaBom4 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_aviaoBom2.Ligacoes.Add(nt_casaBom4);
            No nt_volta28 = new No("\nUma semana depois...");
            nt_casaBom4.Ligacoes.Add(nt_volta28);
            No nt_voltaaviao10 = new No("Está na hora de voltar para casa");
            nt_volta28.Ligacoes.Add(nt_voltaaviao10);
            No nt_final46 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao10.Ligacoes.Add(nt_final46);

            // Natal-Aviao-Casa-Bom-Neutro
            No nt_casaNeutro4 = new No("A casa dos nossos amigos até que está legal", true);
            nt_aviaoBom2.Ligacoes.Add(nt_casaNeutro4);
            No nt_volta29 = new No("\nUma semana depois...");
            nt_casaNeutro4.Ligacoes.Add(nt_volta29);
            No nt_voltaaviao11 = new No("Está na hora de voltar para casa");
            nt_volta29.Ligacoes.Add(nt_voltaaviao11);
            No nt_final47 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_volta29.Ligacoes.Add(nt_final47);

            // Natal-Aviao-Casa-Bom-Ruim
            No nt_casaRuim4 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_aviaoBom2.Ligacoes.Add(nt_casaRuim4);
            No nt_volta30 = new No("\nUma semana depois...");
            nt_casaRuim4.Ligacoes.Add(nt_volta30);
            No nt_voltaaviao12 = new No("Está na hora de voltar para casa");
            nt_volta30.Ligacoes.Add(nt_voltaaviao12);
            No nt_final48 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao12.Ligacoes.Add(nt_final48);


            // Natal-Aviao-Casa-Neutro-Bom
            No nt_aviaoNeutro2 = new No("A viagem de avião foi normal", true);
            nt_aleatoriedade4.Ligacoes.Add(nt_aviaoNeutro2);
            No nt_casaBom5 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_aviaoNeutro2.Ligacoes.Add(nt_casaBom5);
            No nt_volta31 = new No("\nUma semana depois...");
            nt_casaBom5.Ligacoes.Add(nt_volta31);
            No nt_voltaaviao13 = new No("Está na hora de voltar para casa");
            nt_volta31.Ligacoes.Add(nt_voltaaviao13);
            No nt_final49 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao13.Ligacoes.Add(nt_final49);

            // Natal-Aviao-Casa-Neutro-Neutro
            No nt_casaNeutro5 = new No("A casa dos nossos amigos até que está legal", true);
            nt_aviaoNeutro2.Ligacoes.Add(nt_casaNeutro5);
            No nt_volta32 = new No("\nUma semana depois...");
            nt_casaNeutro5.Ligacoes.Add(nt_volta32);
            No nt_voltaaviao14 = new No("Está na hora de voltar para casa");
            nt_volta32.Ligacoes.Add(nt_voltaaviao14);
            No nt_final50 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao14.Ligacoes.Add(nt_final50);

            // Natal-Aviao-Casa-Neutro-Ruim
            No nt_casaRuim5 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_aviaoNeutro2.Ligacoes.Add(nt_casaRuim5);
            No nt_volta33 = new No("\nUma semana depois...");
            nt_casaRuim5.Ligacoes.Add(nt_volta33);
            No nt_voltaaviao15 = new No("Está na hora de voltar para casa");
            nt_volta33.Ligacoes.Add(nt_voltaaviao15);
            No nt_final51 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao15.Ligacoes.Add(nt_final51);

            // Natal-Aviao-Casa-Ruim-Bom
            No nt_aviaoRuim2 = new No("O voo foi horrível e ainda por cima atrasou", true);
            nt_aleatoriedade4.Ligacoes.Add(nt_aviaoRuim2);
            No nt_casaBom6 = new No("Ahh... Nada melhor que momentos com os amigos, fazia tempo que não os via", true);
            nt_aviaoRuim2.Ligacoes.Add(nt_casaBom6);
            No nt_volta34 = new No("\nUma semana depois...");
            nt_casaBom6.Ligacoes.Add(nt_volta34);
            No nt_voltaaviao16 = new No("Está na hora de voltar para casa");
            nt_volta34.Ligacoes.Add(nt_voltaaviao16);
            No nt_final52 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao16.Ligacoes.Add(nt_final52);

            // Natal-Aviao-Casa-Ruim-Neutro
            No nt_casaNeutro6 = new No("A casa dos nossos amigos até que está legal", true);
            nt_aviaoRuim2.Ligacoes.Add(nt_casaNeutro6);
            No nt_volta35 = new No("\nUma semana depois...");
            nt_casaNeutro6.Ligacoes.Add(nt_volta35);
            No nt_voltaaviao17 = new No("Está na hora de voltar para casa");
            nt_volta35.Ligacoes.Add(nt_voltaaviao17);
            No nt_final53 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao17.Ligacoes.Add(nt_final53);

            // Natal-Aviao-Casa-Ruim-Ruim
            No nt_casaRuim6 = new No("Nossos amigos beberam e até vomitaram pela casa, eca!", true);
            nt_aviaoRuim2.Ligacoes.Add(nt_casaRuim6);
            No nt_volta36 = new No("\nUma semana depois...");
            nt_casaRuim6.Ligacoes.Add(nt_volta36);
            No nt_voltaaviao18 = new No("Está na hora de voltar para casa");
            nt_volta36.Ligacoes.Add(nt_voltaaviao18);
            No nt_final54 = new No("\nChegamos em casa...\nEssa viagem foi ótima, vai deixar lembranças");
            nt_voltaaviao18.Ligacoes.Add(nt_final54);

            narrativa.noAtual = narrativa.noRaiz;
            return narrativa;



        }


        private static Arvore OldNarrativa()
        {
            // Nomeclatura escolhida:
            // 0 = Nó único, obrigatorio
            // 1;2;3... = Vários nós, o numero representa a escolha feita
            // Ex: 2 = Foi na escolha 2
            // 1r;2r;3r... = Vários nós com escolha randomica, o numero representa a escolha feita
            // Ex: 2r = Randomicamente escolheu 2
            // 1-1-2r ; 0-1-1; 0-2-1 = Caminho percorrido
            // Ex: 0-1-2r = Primeiro nó era único, depois escolheu o nó 1 e depois randomicamente o 2
            // b0;b12;b23 = nó do branch 
            // b0 = Ultimo nó do percurso "0"
            // b12 = Ultimo nó do percurso "1-2"
            // eb0;eb12 = Escolha do nó em questão
            // eb12 = Escolha do ultimo nó do percurso "1-2"

            Arvore narrativa = new Arvore();
            // Raíz
            No raiz = narrativa.noRaiz = new No(new Escolha("Inicio do Jogo")); // Método inline de instanciar um nó e escolha

            Escolha eb0 = new Escolha("Bifurcação, o que fazer?"); // Método padrão de instanciar uma escolha
            No b0 = new No(eb0); // Método padrão de instanciar um nó
            raiz.Ligacoes.Add(b0); // Adicionar o nó b0 na ligação do nó raiz

            #region branchs

            #region branchs 0-1-x
            // Branch 0-1-1-1r
            No b01 = new No("Esquerda"); // Método facil de instanciar um nó com escolha
            b0.Ligacoes.Add(b01);
            No b011 = new No("Continuar em frente");
            b01.Ligacoes.Add(b011);
            No b0111r = new No("Adicionar caminho ao gps", true);
            b011.Ligacoes.Add(b0111r);
            // Branch 0-1-1-2r
            No b0112r = new No("Tentar outro caminho na próxima vez", true);
            b011.Ligacoes.Add(b0112r);
            // Branch 0-1-2-1r
            No b012 = new No("Voltar e ir pelo da direita");
            b01.Ligacoes.Add(b012);
            No b0121r = new No("Adicionar caminho ao gps", true);
            b012.Ligacoes.Add(b0121r);
            // Branch 0-1-2-2r
            No b0122r = new No("Tentar outro caminho na próxima vez", true);
            b012.Ligacoes.Add(b0122r);
            #endregion

            #region branchs 0-2-x
            // Branch 0-2-1-1r
            No b02 = new No("Direita");
            b0.Ligacoes.Add(b02);
            No b021 = new No("Continuar em frente");
            b02.Ligacoes.Add(b021);
            No b0211r = new No("Adicionar caminho ao gps", true);
            b021.Ligacoes.Add(b0211r);
            // Branch 0-2-1-2r
            No b0212r = new No("Tentar outro caminho na próxima vez", true);
            b021.Ligacoes.Add(b0212r);
            // Branch 0-2-2-1r
            No b022 = new No("Voltar e ir pelo da esquerda");
            b02.Ligacoes.Add(b022);
            No b0221r = new No("Adicionar caminho ao gps", true);
            b022.Ligacoes.Add(b0221r);
            // Branch 0-2-2-2r
            No b0222r = new No("Tentar outro caminho na próxima vez", true);
            b022.Ligacoes.Add(b0222r);
            #endregion

            #endregion

            narrativa.noAtual = narrativa.noRaiz;
            return narrativa;

        }

    }
}
