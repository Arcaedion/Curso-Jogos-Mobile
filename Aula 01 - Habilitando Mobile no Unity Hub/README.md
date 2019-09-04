## Aulas escritas EM PROGRESSO

# Como fazer um Jogo de Celular :iphone:

# Aula 1 - Instalando e Habilitando Mobile no Unity :computer:

## Resumo

1. Usando o Unity Hub
2. Baixando e Instalando
3. Configurando módulos

# Introdução

Hoje eu vou começar com um curso bem legal sobre __jogos mobile__! :clap: :clap: :clap:

Nele vamos falar sobre tudo que você precisa se preocupar quando quiser fazer build do seu jogo para o __ambiente mobile__. E olha, não é pouca coisa não. Para começar, toda a jogabilidade muda de apertar botões para gestos, você pode usar giroscópio etc. 

O design tem que estar de acordo, mas dependendo do seu jogo ele pode ser multiplataforma! E por isso vamos também conversar sobre como podemos por exemplo fazer um jogo para PC que funcione com gamepad e o mesmo jogo seja lançado no seu smartphone conectado com um gamepad também!

De qualquer forma, antes de programar um jogo mobile, precisamos configurar o Unity pra conseguir fazer isso. É coisa rápida e talvez vc ja tenha até feito. Se for o caso, só tenha certeza de ter pelo menos a versão 2019.2 e segue em frente, senão, nesse post eu vou ensinar como configurar o Unity para fazer build para mobile, bem tranquilo! Bora lá ver!

## Usando o Unity Hub

O primeiro passo é baixar a versão 2019.2 do Unity. Se você estiver lendo este post no futuro, é provável que qualquer versão mais atualizada funcione assim também.

Ah, e olha eu tô assumindo que vc já tem baixado o Unity Hub, nesse caso aqui versão 2.1.0 ou superior. Se não tiver baixado, é claro que tenho um vídeo explicando. Eu coloquei na descrição um link para o vídeo e também um link de download direto caso vc saiba como fazer sozinho.

## Baixando e Instalando

Muito bem. Abra o Unity Hub, vá para a aba _'Installs'_ e lá clique em "Add". Aparecerá uma janela para escolher a versão, escolha 2019.2. Se você já tiver essa versão instalada, no fim do vídeo eu explico como atualizá-la.

Dê next e agora vai ter uma segunda parte onde você adiciona módulos. 

Nesse curso vamos trabalhar com Android, mas você pode seguir quase os mesmos passos no caso do iOS. Aqui eu marquei Android Build Support e em baixo Android SDK & NDK Tools. Percebe que eu não marquei o OpenJDK, isso é porque no meu PC eu já tenho o Java JDK instalado, mas como eu não tenho o Android SDK e NDK instalados eu marquei o primeiro. Se você não sabe bem o que são essas coisas, marca os dois: SDK e NDK e também o OpenJDK.

Eu gosto de marcar a documentação para não precisar de internet caso precise pesquisar alguma coisa na documentação do Unity. Dê next, leia e aceite os termos de licença e clique em Done. Agora é só esperar, mas olha, espera sentado porque com esses módulos do Android o tamanho ficou de 10gb!

## Configurando módulos

Olha e se você quiser também lançar o jogo para iOS, vc só precisa clicar nos 3 pontos, _'Add Modules'_ e aqui escolher os módulos como eu acabei de fazer.