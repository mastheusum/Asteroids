# Asteroids 
###### *Version 0.1*

## Identidade do jogo
Red é uma nave vermelha que está no espaço no meio de uma chuva de asteroides que está a caminho do seu planeta. Sua missão é assumir o controle da Red e destruir o máximo possível de asteroides para proteger o seu planeta natal.

## Descrição da mecânica
Informações sobre as mecânicas do jogo
1. **Mecânicas do Mundo**
	1. **Wrap**
Quando a posição de um objeto for maior ou menor que as dimensões da tela (em outras palavras, quando um objeto sai da tela) ele deve aparecer na posição oposta a qual ele estava indo. 
Ex: se o asteroide está indo para a direita e ele sai da tela pela direita, então ele deve aparecer no lado esquerdo da tela
A mecânica de **Wrap** não se aplica ao laser

2. **Mecânicas do Asteroide**
	1. **Movimento Contínuo**
Quando for criado, deve ser impulsionado na direção de sua rotação sem perda de velocidade ou alteração na direção
	2. **Destruição**
Quando atingido por um outro objeto qualquer, deve se dividir em outros dois asteroides com perda tamanho de 0.25 direto na escala. A rotação desses novos asteroides será recalculada e o asteroide original deve ser destruído.
3. **Mecânicas do Laser**
	1. **Movimento Contínuo**
Quando for criado, deve ser impulsionado na direção de sua rotação sem perda de velocidade ou alteração na direção.
	2. **Destruição**
Caso atinja um asteroide o Laser deve ser destruído e uma quantidade X de pontos adicionada a pontuação do jogador
	3. **Limite Espacial**
A mecânica de <Wrap> não deve afetar o Laser, portanto, ao passar os limites do cenário ele deve ser eliminado
4. **Mecânicas da Nave**
	1. **Impulso**
Ao pressionar a tecla a Nave deve ser impulsionada para frente
	2. **Rotação**
Ao pressionar as teclas a Nave deve rotacionar em torno do próprio eixo, alterando a sua direção frontal
	3. **Disparar**
Ao pressionar a tecla a Nave deve disparar um Laser na sua direção frontal

## Características
O jogo tem ambientação espacial.
Os asteroides se movem de forma linear e a nave tem poucos controles, exigindo muita atenção e estratégia do jogador para destruir todos.

## Arte
Será um jogo 2D.

## Música/Trilha Sonora
-  Música tema: 
[O Come O Come Emmanuel - Mystery Mammal](https://freemusicarchive.org/music/Mystery_Mammal/Xmas_on_Tape/o_come_emmanuel_1272 "O Come O Come Emmanuel - Mystery Mammal")
-  Música tiro: 
[Laser](https://freesound.org/people/Daleonfire/sounds/376694/  "Laser")
-  Explosão asteroide: 
[Concrete Smash](https://freesound.org/people/magnuswaker/sounds/522099/  "Concrete Smash")

## Interface/Controles
| **Ação**  |  **Controles** |
| ------------ | ------------ |
|  Inpulso para frente | Up Arrow ou Key W  |
|  Rotação | Left/Right Arrow ou Key A/D  |
|  Atirar | Space Bar  |

## Dificuldade
O Jogo terá um total de 4 níveis de dificuldades
1. O jogo começa com um asteroide em uma de quatro posições marcadas no cenário
2. O jogo começa com dois asteróides em duas das quatro posições marcadas no cenário
3. O jogo começa com três asteróides em três das quatro posições marcadas no cenário
4. O jogo começa com quatro asteróides, um em cada uma das posições marcadas no cenário

A cada trinta segundos novos asteroides são criados no cenário. A quantidade de asteroides criada vai mudar, variando de 1 a 4 dependendo do nível.

## Definições gerais
Gênero: Arcade
Plataformas: Linux, Windows e Android;
Quantidade de níveis: 4/
Quantidade de vilões/inimigos: 1 asteroide no nível 1 e 1 asteroide é incrementado em cada nível;

