## Aulas escritas EM PROGRESSO

# Como fazer um Jogo de Celular :iphone:

Vídeo-aula: 


# Aula 3 - Controles Touch em Unity :video_game:

## Resumo

Gamepad virtual em Unity
1. Testando nova cena
2. Joystick virtual para andar
3. Botão para Pular


## Introdução
Voltamos aqui a mais uma aula de Unity para Mobile! Hoje, vamos aprender a colocar um gamepad virtual com um joystick e um botão em Unity.

## Gamepad virtual em Unity

Um dos desafios de fazer um jogo multiplataforma é que temos que contar com várias situações diferentes. Sabe quando num jogo aparece pra vc apertar E para interagir? Pois é, se o jogador tiver usando um controle de PS4 vc vai querer mostrar outra coisa, tipo Aperte "Triangulo" para interagir. No caso de incluir mobile na história, vc ainda tem que colocar os controles na tela!

## Testando a nova cena 
Mas antes de mais nada, vamos dar uma olhada na cena que eu preparei para o exemplo dessa aula.

Muito bem, aqui temos uma cena bem simples. Um personagem que é esse monstrinho marrom, e uns terrenos. O monstrinho pode andar e pular. Só isso.

Eu já tenho o celular preparado com o Unity Remote como eu ensinei na última aula, e tudo que eu preciso fazer é dar Play.

Vai ficar esquisito, o celular tá em modo Retrato, e se a gente virar de lado, fica em paisagem e ta tudo ok. Mas no momento não adianta eu apertar nada, nada funciona aqui. E é isso que vamos fazer, mas primeiro vamos desabilitar a rotação da tela indo em

Edit > Project Settings > Player 

E escolhendo a parte "Resolution and Presentation" e nas Allowed Orientations, desmarca as opções Portrait e Portrait Upside Down.

                                                >Joystick virtual para andar<
Pronto, agora a tela não roda e podemos ja trabalhar nos inputs

Para criar um Joystick, podemos fazer nós mesmos um ou evitar re-inventar a roda. Para deixar o vídeo mais rápido e porque eu acho que é a preferência da maioria, vamos usar um pack gratuito na asset store do Unity. Mas manda um comentário nesse vídeo caso você queira aprender a criar um joystick do zero, dá pra fazer também!

Aperte CTRL+9 no atalho padrão, ou vá em Window>Asset Store e procure por Joystick pack
Isso aqui tem 600kb

Vamos começar criando um Canvas. Ele vai servir para segurar os nossos elementos de UI, que no caso são também nosso controle

Ir em 
- Jogador.cs
- Adiciona nova variável joystick
- faz um if no movimento horizontal
- troca por joystick.Horizontal
- Passa Joystick para jogador
- Pode testar

Durante o teste:
- Isso funciona como um joystick de PS4: vc pode controlar o quanto quer se mover pro lado
- Deixar isso desse jeito ou não fica a seu critério, mas se você não quiser
- joystick.Horizontal é um valor de 0 a 1, enquanto teclas é sempre 0 ou 1
- Pode fazer um if para saber se é > 0 ou < 0 e se for passa 1 no horizontal move.


Agora, nada impede que o jogador ligue um Gamepad ao celular dele, talvez usando uma daquelas coisas q prende o celular num controle, ou até mesmo usando um teclado(sim, vc pode usar um teclado bluetooth também!)

Então para isso vamos deixar ainda o Input.GetAxisRaw no código, e detectar se apenas algum desses dois é maior que 0 e aplicar o movimento!

Depois é só fazer alguma opção nas configurações para mostrar ou esconder o gamepad. Legal né?


Agora, daqui vc pode fazer um pulo usando joystick.Vertical, e se for > 0 o personagem pula. Mas na minha opinião, um design melhor, pelo menos para jogos plataforma, é apertando um botão com a mão direita para pular
                    >Botão para Pular<
e é exatamente isso que vamos ver agora.

Para fazer um botão para pular é extremamente simples. Vou colocar aqui na cena uma imagem


- Coloca imagem
- Troca imagem para Knob
- Adiciona Button component
- OnClick -> Jogador -> Pula()

Fazendo agora um ultimo teste ja vemos que podemos jogar o jogo no celular do jeito que queremos! Muito maneiro né?


É isso por hoje, se inscreva e deixa aquele like que ajuda muito o canal a crescer e te vejo na próxima aula, FUI!

