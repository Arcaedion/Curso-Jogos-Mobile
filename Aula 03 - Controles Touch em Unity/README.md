## Aulas escritas EM PROGRESSO

# Como fazer um Jogo de Celular :iphone:

Vídeo-aula: Clique [Aqui!](https://www.youtube.com/watch?v=ETJU5D5W5eg&list=PLsTmpCmfnjZeYB0ZuGjszmEEW4NVC4cpH&index=4)


# Aula 3 - Controles Touch em Unity :video_game:

## Resumo

Gamepad virtual em Unity
1. Testando nova cena :suspect:
2. Joystick virtual para andar :godmode:
3. Botão para Pular :rage2:


## Introdução :exclamation:
Voltamos aqui a mais uma aula desse curso de __Programação de jogos para Celular!__ :fire: :fire: 

Hoje, vamos aprender a colocar um gamepad virtual com um joystick e um botão na tela do jogador para ele se mover.  :thumbsup:

## Gamepad virtual em Unity :video_game:

Um dos __desafios__ de fazer um jogo multiplataforma é que temos que contar com várias situações diferentes. Sabe quando num jogo aparece pra vc apertar '_E_' para interagir? Pois é, se o jogador tiver usando um controle de __PS4__ vc vai querer mostrar outra coisa, tipo Aperte "_Triangulo_" para interagir. No caso de incluir mobile na história, vc ainda tem que colocar os controles na tela!

## Testando a nova cena 

Antes de mais nada, vamos dar uma olhada na cena que eu preparei para o exemplo dessa aula. Você pode baixar todos os assets aqui:

Muito bem, aqui temos uma cena bem simples. Um personagem que é esse monstrinho marrom, e uns terrenos. O monstrinho pode andar e pular. Só isso.

Com o celular preparado com o Unity Remote, como eu ensinei na [última aula](), tudo que eu preciso fazer é dar Play.

Vai ficar esquisito, o celular tá em modo __Retrato__ :iphone:, e se a gente __virar de lado__, fica em paisagem e ta tudo ok. Mas, no momento, __não adianta eu apertar nada__, afinal, nada funciona aqui. E é isso que vamos fazer, mas primeiro vamos __desabilitar__ a rotação da tela indo em:

__Edit > Project Settings > Player__

E escolhendo a parte __Resolution and Presentation__ e nas __Allowed Orientations__, desmarca as opções __Portrait__ e __Portrait Upside Down__.


## Joystick virtual para andar

Pronto, agora a tela não roda e podemos ja trabalhar nos inputs

Para criar um __Joystick__ :video_game:, podemos fazer nós mesmos um ou evitar __re-inventar a roda__ :ferris_wheel:. 

Para deixar o guia mais rápido e porque eu acho que é a preferência da maioria, vamos usar um __pack gratuito na asset store do Unity__. Também dá para criar um Joystick do zero, vamos ver o que pessoal acha e quem sabe não fazemos também!

Aperte __CTRL+9__ no atalho padrão, ou vá em __Window > Asset Store__ e procure por "_Joystick pack_". Baixe o primeiro projeto que aparecer. Ele tem só __600kb__

Vamos começar criando um _Canvas_. Ele vai servir para segurar os nossos elementos de UI, que no caso são também nosso controle

** EM CONSTRUÇÃO
