## Aulas escritas EM PROGRESSO

# Como fazer um Jogo de Celular :iphone:

# Aula 2 - Configurando o Unity :gear:

## Resumo

1. Projeto de Teste
2. Build do APK
3. Usando Unity Remote

## Introdução

O negócio é o seguinte: Nem tudo são flores quando se trata de um jogo mobile. Isso é porque vc tá programando seu jogo no seu PC, mas está testando em outro dispositivo. 

Isso é porque no PC não temos as mesmas funcionalidades que no smartphone. Sâo simplesmente diferentes. 

Isso tudo que eu tô falando é só para amenizar o fato de que a gente vai ter que fazer umas paradinhas chatas antes de começar o jogo, mas não é muita coisa não, prometo.

Aqui no Unity Hub, eu vou criar um novo projeto. Fazemos isso indo na aba Projects e depois New. Pode deixar marcado o 3D mesmo, escolha um nome, no meu caso vai ser InputsMobile e uma localização para salvar seu projeto e clique em Create. Se o Firewall do Windows reclamar é só clicar em permitir. O Unity vai pensar aí um bocado enquanto cria seu projeto. Aproveita pra ir buscar um suco coisa assim.

## Projeto de Teste

Aqui no Unity, vá em Window > Asset Store. A primeira coisa que vamos fazer é abrir a asset store do Unity porque vamos baixar um projetinho de teste para testar o mobile. É só procurar na asset store "simple mobile placeholder". É eu sei que escrevi "project" mas enfim funcionou. Clique no Simple Mobile Placeholder, depois na página clique em "Download" e depois em "Import", na janela que abrir clique também em Import. O Unity vai abrir uma janela dizendo que a versão de Scripting Runtime mudou bla bla bla, só clique em Restart que tamo bem. Como vc pode ver depois ele pergunta de novo, então clica em restart de novo se acontecer com vc também.

Daí o unity vai restartar e tal, vc pega outro suco e quando ele abrir vai ali na pasta Scenes e clica duas vezes na cena "Main". Essa cena não é nada de mais, só tem um cubo que roda e se você clicar nele ele roda pro lado contrário. Só isso, é lindo.

## Build fo APK

Enfim, agora clica em File > Build Settings... Ali tem todas as opções de builds, clica em Android e depois em Switch Platform para mudar a build para Android. Depois disso, vamos configurar o arquivo que é criado quando fazemos build para Android, indo em Edit > Project Settings... 

Aqui no Project Settings, abre essa parte Other Settings e desce até essa caixa "Package Name", aqui você coloca o nome do seu projeto nesse formato "com.nome-do-seu-projeto", se quiser seguir essa nomenclatura não tem problema. Não se preocupa em ser algo muuuito único porque vc pode mudar depois quando for colocar sua app na Store. Agora vou só subir aqui e mudar o "Scripting Backend" de 'Mono' para 'IL2CPP', o API Compatibility para .NET 4.x e no target architectures desmarca x86 e marca ARM64. O Mono só suporta criar arquivos em 32 bits, e o Google não permite mais apps em 32 bits. Fazer isso vai recarregar API's, então espera uns segundos...


Falando em API's, aqui em cima vc pode configurar o Minimum API Level e suportar seu jogo até a versão 4.1 se quiser. Claro que quanto mais pesado seu jogo, pior ele vai rodar nesses celulares mais antigos. Por enquanto vou manter na versão 4.1.

Agora vamos configurar o seu celular. Isso muda de Android para Android, mas é sempre parecido. Vá nas Opções ou Configurações, desca até o fim onde vc tem escrito "Sobre o telefone", clique ali. Depois nessa tela vc tem algo como "número de compilação", toque repetidamente nesse número até aparecer a mensagem: "Você é um programador!"

Podemos acessar as opções de programador agora. No meu, eu tenho que voltar para as Configurações e clicar em Sistema, e depois em Opções de Programador.

Aqui, faça enable da opção Depuração USB e confirme na caixa de diálogo. Ligue o seu celular com um cabo USB ao seu PC, e uma janela perguntando "Permitir depuração USB?" vai aparecer. Toque em OK e é isso, seu celular ta pronto pra receber seus jogos.


## Usando Unity Remote


