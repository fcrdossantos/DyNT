# DyNT - Dynarratreeve

## O que é?
DyNT é a sigla de Dynamic Narrative Tree, árvore dinâmica de narrativa, ou Dynarratreeve.

Seu intuito é proporcionar uma facilidade na hora de criar narrativas não lineares para jogos digitais, além de melhorar no desempenho do processamento.

## Por que usar?
Atualmente o número de jogos com enredos não lineares vem crescendo bastante, porém, os algoritmos para atender tal estilo de enredo estão um pouco ultrapassados, usando métodos antigos e complexos, como o **Threaded** ou arcaicos e verbosamente repetitivos, como o **Branching**.

Já na DyNT o processo de criação pode ser melhorado significativamente, uma vez que alguma das responsabilidades do desenvolvedor passam a se tornar responsabilidades do DyNT, como saber quais as próximas ligações possíveis, o que ainda não pode ser desbloqueado e quais partes da história já tem todos os requisitos completos e está apta a ser desbloqueada.

Além de precisar de um número bem menor de linhas de código, na DyNT a repetição de valores é nula, já que nunca dois tipos de nós iguais devem ser instanciados, o próprio algoritmo saberá onde encaixá-lo, diferente do que ocorre em algoritmos como o Branching, onde a configuração de cada ramificação é necessária, independente dos valores serem repetidos.

## Metodologia
A metodologia por trás da DyNT é bem simples, cada nó tem seus requisitos para ser atingida e necessidades para ter continuidade. De um jeito mais fácil, cada parte do enredo (nó) sabe o que é preciso para chegar até ele (receber uma ligação) e sabe o que os nós outros nós precisam para serem os próximos a ser chamados (fazer uma ligação)

Na DyNT chamamos isso de **Valoração**

Exemplo:

- O jogador entra em um castelo e avista duas portas, a da esquerda precisa ter nível 10 e a da direita 15, porém ele ainda está no nível 12. Neste caso, o nó atual é o "Castelo" e para ter continuidade ele precisa de nós que sejam do tipo "Portas".
- Já as portas precisam de um nível para serem ativadas, a "Esquerda" tem esse valor valendo 10 e a "Direita" tem o mesmo tipo de valor, porém valendo 15.
- O próprio processo de ligação do DyNT saberá que a o "Castelo" só pode se ligar as duas portas aqui mencionadas, porém, apenas mantêm a ligação com a "Esquerda", por não satisfazer o requisito da outra.   

Neste caso temos dois tipos de **Valoração**: *Portas* e *Nível Minimo*, onde cada uma tem seu respectivo tipo de valor e maneira de comparação, ou seja, a *Porta* pode ser um *boolean* e valer *true* quando for uma porta e o *Nivel Minimo* ser um inteiro que é válido apenas quando é igual ou maior que o requisitado.

## Por que 'Dinâmica' ?
A árvore é dinâmica pois ela não precisa de uma construção estática como de costume, embora o enredo já seja conhecido e você já tenha os dados necessários, você não precisa perder todo aquele tempo de fazer cada parte se ligar com cada outra parte e repetir inúmeras linhas de código para criar ramificações novas da sua história.

Além disso, caso um nó não seja mais utilizado, a árvore saberá disso e irá tirá-lo de lá.

## Instalação e uso
Atualmente o DyNT possui apenas a versão em C#, sendo código aberto e totalmente gratuito. Para instalação e uso não é preciso nenhuma dll ou pacote NuGet, basta clonar o repositório e importá-lo ao seu projeto.

Para exemplos de implementação consulte a nossa documentação através do link:
https://zarcky.developerhub.io/v1.0/dynt/dynt---dynarratreeve

Para consulta de como foi feito o benchmark, veja o arquivo *"Program.cs"*

## Licença
A lincença utilizada no DyNT é a GNU GPLv3
