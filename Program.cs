using System;
using System.Security.AccessControl;
class Program
{
    static void Main(string[] args)
    {

        int Riqueza = 0;
        int Ocultismo = 0;
        int Brutalidade = 0;
        int Mentalidade = 0;
        int Corpo = 0;
        int Artístico = 0;

        string PrimeiraPergunta = "";
        string SegundaPergunta = "";
        string TerceiraPergunta = "";
        string QuartaPergunta = "";
        string QuintaPergunta = "";
        string SextaPergunta = "";
        string SetimaPergunta = "";
        string OitavaPergunta = "";
        string NonaPergunta = "";
        string DecimaPergunta = "";

        while (true) // Pergunta 1
        {
            Console.WriteLine("1: Qual foi a frase mais impactante que já ouviu na sua vida?");
            Console.WriteLine("A) Fala de Afeto: Uma frase feita por alguém especial pra você, recheada de afeto.");
            Console.WriteLine("B) Fala de Despedida: ... você não entrou mais em contato com quem te falou isso depois, né?");
            Console.WriteLine("C) Fala Esquisita: Você não entendeu direito oque foi dito, mas por algum motivo, se prendeu na sua mente e NÃO SAI.");
            Console.WriteLine("D) Fala de Apoio: Inocente, simples e efetiva. Essa frase te motiva até hoje quando precisa.\n");
            PrimeiraPergunta = Console.ReadLine() ?? "";
            if (PrimeiraPergunta == "A" || PrimeiraPergunta == "B" || PrimeiraPergunta == "C" || PrimeiraPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (PrimeiraPergunta)
        {
            case "A": Mentalidade++; Artístico++; break;
            case "B": Brutalidade += 2; break;
            case "C": Ocultismo += 2; break;
            case "D": Corpo++; Riqueza++; break;
        }
        while (true) // Pergunta 2
        {
            Console.WriteLine("\n2: Qual o seu grande objetivo pessoal?");
            Console.WriteLine("A) Objetivo Honroso: Que... lindo da sua parte. Nesse mundo, poucos tem o direito de pensar assim.");
            Console.WriteLine("B) Objetivo Egoísta: Isso, isso sim é um objetivo de alguém que não vive numa bolha.");
            Console.WriteLine("C) Objetivo Estranho: Er... sério? Que hilário.");
            Console.WriteLine("D) Objetivo Redentor: É... talvez você precise disso para poder dormir tranquilo.\n");
            SegundaPergunta = Console.ReadLine() ?? "";
            if (SegundaPergunta == "A" || SegundaPergunta == "B" || SegundaPergunta == "C" || SegundaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (SegundaPergunta)
        {
            case "A": Riqueza += 2; break;
            case "B": Brutalidade++; Corpo++; break;
            case "C": Ocultismo++; Artístico++; break;
            case "D": Mentalidade += 2; break;
        }
        while (true) // Pergunta 3
        {
            Console.WriteLine("\n3: Qual foi a sua relação mais marcante?");
            Console.WriteLine("A) Relação Afetiva: É... uma pena que não estão mais juntos.");
            Console.WriteLine("B) Relação Familiar: ... talvez eles mereciam? Não sei, você que me diz.");
            Console.WriteLine("C) Relação Imaginária: Isso... isso só é triste.");
            Console.WriteLine("D) Relação Inexistente: Pensa bem, ao menos pra você ela existia.\n");
            TerceiraPergunta = Console.ReadLine() ?? "";
            if (TerceiraPergunta == "A" || TerceiraPergunta == "B" || TerceiraPergunta == "C" || TerceiraPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (TerceiraPergunta)
        {
            case "A": Brutalidade++; Mentalidade++; break;
            case "B": Riqueza += 2; break;
            case "C": Artístico += 2; break;
            case "D": Ocultismo += 2; break;
        }
        while (true) // Pergunta 4
        {
            Console.WriteLine("\n4: Qual o lugar que te faz relaxar?");
            Console.WriteLine("A) Lugar Ocupado: Entendi, você gosta de gente e barulho.");
            Console.WriteLine("B) Lugar Natural: Que intrigante. Você achou um pedaço de natureza em meio as paredes e pisos de concreto do labirinto.");
            Console.WriteLine("C) Lugar Torturante: Não vou questionar o porque você gosta daqui. Cada um tem suas... penitências.");
            Console.WriteLine("D) Lugar Impossível: Como? Como isso veio a existir?!\n");
            QuartaPergunta = Console.ReadLine() ?? "";
            if (QuartaPergunta == "A" || QuartaPergunta == "B" || QuartaPergunta == "C" || QuartaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (QuartaPergunta)
        {
            case "A": Riqueza++; Mentalidade++; break;
            case "B": Artístico += 2; break;
            case "C": Brutalidade += 2; Corpo++; break;
            case "D": Ocultismo += 3; break;
        }
        while (true) // Pergunta 5
        {
            Console.WriteLine("\n5: Qual foi a decisão que mudou sua vida?");
            Console.WriteLine("A) \"Perdoar Aquela Pessoa\": ...");
            Console.WriteLine("B) \"Nunca Desistir\" : ...");
            Console.WriteLine("C) \"Prestar Atenção nos Sussurros\" : ...");
            Console.WriteLine("D) \"Puxar o Gatilho\": ...\n");
            QuintaPergunta = Console.ReadLine() ?? "";
            if (QuintaPergunta == "A" || QuintaPergunta == "B" || QuintaPergunta == "C" || QuintaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (QuintaPergunta)
        {
            case "A": Mentalidade += 3; break;
            case "B": Corpo += 3; break;
            case "C": Ocultismo += 3; break;
            case "D": Brutalidade += 3; break;
        }
        while (true) // Pergunta 6
        {
            Console.WriteLine("\n6: O que te assusta mais?");
            Console.WriteLine("A) A solidão infinita: Ser a única pessoa em um vazio eterno. Sem som. Sem companhia.");
            Console.WriteLine("B) O inevitável desconhecido: Algo que você não entende e que provavelmente nunca será explicado.");
            Console.WriteLine("C) A fragilidade do corpo: Uma queda, um golpe, um momento, e tudo pode acabar.");
            Console.WriteLine("D) A crueldade das pessoas: Você já viu do que o ser humano é capaz, e isso te assombra.\n");
            SextaPergunta = Console.ReadLine() ?? "";
            if (SextaPergunta == "A" || SextaPergunta == "B" || SextaPergunta == "C" || SextaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (SextaPergunta)
        {
            case "A": Mentalidade += 2; Artístico--; break;
            case "B": Ocultismo += 2; break;
            case "C": Corpo += 2; break;
            case "D": Mentalidade++; Artístico++; break;
        }
        while (true) // Pergunta 7 (Random D)
        {
            Console.WriteLine("\n7: Com o que você sonha à noite?");
            Console.WriteLine("A) Um mundo onde você é amado: Um lugar onde você finalmente se sente compreendido.");
            Console.WriteLine("B) Um labirinto sem fim: Você sempre está perdido, mas há algo te observando.");
            Console.WriteLine("C) Poder além da imaginação: Você sonha em nunca mais ser impotente.");
            Console.WriteLine("D) Nada. Apenas o vazio: Seu sono é tão profundo e estranho que nem sonhos você se lembra.\n");
            SetimaPergunta = Console.ReadLine() ?? "";
            if (SetimaPergunta == "A" || SetimaPergunta == "B" || SetimaPergunta == "C" || SetimaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (SetimaPergunta)
        {
            case "A": Artístico += 2; Mentalidade++; break;
            case "B": Ocultismo += 4; Mentalidade -= 2; break;
            case "C": Brutalidade++; Corpo++; break;
            case "D":
                Random rnd = new Random();
                int escolha = rnd.Next(0, 6); // 0 a 5
                switch (escolha)
                {
                    case 0: Riqueza += 2; break;
                    case 1: Artístico += 2; break;
                    case 2: Mentalidade += 2; break;
                    case 3: Ocultismo += 2; break;
                    case 4: Corpo += 2; break;
                    case 5: Brutalidade += 2; break;
                }
                break;
        }
        while (true) // Pergunta 8
        {
            Console.WriteLine("\n8: Qual foi a maior lição que você aprendeu?");
            Console.WriteLine("A) A importância de se adaptar: Você precisa ser flexível e se moldar para sobreviver.");
            Console.WriteLine("B) A força bruta resolve mais do que parece: Se você é forte o suficiente, o resto não importa.");
            Console.WriteLine("C) Nem todos querem te ajudar: Você aprendeu isso da pior forma.");
            Console.WriteLine("D) A beleza pode mudar corações: A arte, a música, ou um gesto belo podem ser mais poderosos do que palavras.\n");
            OitavaPergunta = Console.ReadLine() ?? "";
            if (OitavaPergunta == "A" || OitavaPergunta == "B" || OitavaPergunta == "C" || OitavaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (OitavaPergunta)
        {
            case "A": Corpo++; Mentalidade++; break;
            case "B": Brutalidade++; Corpo++; break;
            case "C": Riqueza++; Brutalidade++; break;
            case "D": Artístico += 2; Brutalidade--; break;
        }
        while (true) // Pergunta 9
        {
            Console.WriteLine("\n9: O que você faria por poder?");
            Console.WriteLine("A) Qualquer coisa: Você não vê limites quando o poder está em jogo.");
            Console.WriteLine("B) Sacrificaria seus valores: Você abriria mão de quem acredita ser para conseguir mais.");
            Console.WriteLine("C) Nada que envolva machucar inocentes: Você tem um limite, e não ultrapassaria isso.");
            Console.WriteLine("D) Não tenho interesse em poder: Seu foco está em outras coisas.\n");
            NonaPergunta = Console.ReadLine() ?? "";
            if (NonaPergunta == "A" || NonaPergunta == "B" || NonaPergunta == "C" || NonaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (NonaPergunta)
        {
            case "A": Brutalidade += 2; Mentalidade++; break;
            case "B": Corpo++; Ocultismo++; break;
            case "C": Mentalidade++; Riqueza += 2; break;
            case "D": Artístico += 2; Riqueza++; break;
        }
        while (true) // Pergunta 10 (Random D)
        {
            Console.WriteLine("\n10: Qual memória mais te atormenta?");
            Console.WriteLine("A) Um erro imperdoável: Você ainda carrega a culpa pelo que fez.");
            Console.WriteLine("B) Algo que não deveria existir: Você viu algo... e ninguém acreditou em você.");
            Console.WriteLine("C) A morte de alguém próximo: Você ainda revive esse momento em seus pesadelos.");
            Console.WriteLine("D) Nada. Sua mente bloqueou tudo: Talvez você devesse se lembrar, mas algo te impede.\n");
            DecimaPergunta = Console.ReadLine() ?? "";
            if (DecimaPergunta == "A" || DecimaPergunta == "B" || DecimaPergunta == "C" || DecimaPergunta == "D")
                break;
            Console.WriteLine("Resposta inválida. Por favor, escolha A, B, C ou D.");
        }
        switch (DecimaPergunta)
        {
            case "A": Mentalidade += 3; Brutalidade -= 2; break;
            case "B": Ocultismo += 2; Artístico -= 2; break;
            case "C": Brutalidade += 3; Mentalidade -= 2; break;
            case "D":
                Random rnd = new Random();
                int escolha = rnd.Next(0, 6); // 0 a 5
                switch (escolha)
                {
                    case 0: Riqueza += 2; break;
                    case 1: Artístico += 2; break;
                    case 2: Mentalidade += 2; break;
                    case 3: Ocultismo += 2; break;
                    case 4: Corpo += 2; break;
                    case 5: Brutalidade += 2; break;
                    default: break;
                }
                break;
        }


        Console.WriteLine("\nSeus Pontos de Característica São: \nRiqueza: " + Riqueza + "\nOcultismo: " + Ocultismo + "\nBrutalidade: " + Brutalidade + "\nMentalidade: " + Mentalidade + "\nCorpo: " + Corpo + "\nArtístico: " + Artístico);

        string ClassesDisponiveis = "";

        if (Mentalidade >= 5 && Corpo <= 3) // Psíquico
            ClassesDisponiveis += "Psíquico, ";

        if (Ocultismo >= 4 && Corpo >= 2 && Riqueza >= 6) // Arquiteto
            ClassesDisponiveis += "Arquiteto, ";

        if (Corpo >= 4) // Escalador
            ClassesDisponiveis += "Escalador, ";

        if (Ocultismo >= 7 && Mentalidade >= 3) // Ritualista
            ClassesDisponiveis += "Ritualista, ";

        if (Brutalidade >= 5) // Armeiro
            ClassesDisponiveis += "Armeiro, ";

        if (Corpo >= 3 && Brutalidade >= 7) // Carrasco
            ClassesDisponiveis += "Carrasco, ";

        if (Riqueza >= 2 && Ocultismo >= 5 && Mentalidade >= 2) // Demonologista
            ClassesDisponiveis += "Demonologista, ";

        if (Corpo >= 8) // Acorrentado
            ClassesDisponiveis += "Acorrentado, ";

        if (Corpo >= 3 && Ocultismo >= 3 && Mentalidade >= 1 && Brutalidade >= 2 && Artístico <= 2 && Riqueza <= 2) // Filho das Sombras
            ClassesDisponiveis += "Filho das Sombras, ";

        if (Mentalidade >= 6 && Brutalidade <= 2 && Riqueza < 2) // Coração Radiante
            ClassesDisponiveis += "Coração Radiante, ";

        if (Artístico >= 5 && Mentalidade >= 1 && Riqueza <= 2) // Operário
            ClassesDisponiveis += "Operário, ";

        if (Ocultismo >= 7 && Mentalidade >= 2 && Artístico >= 3) // Relojoeiro
            ClassesDisponiveis += "Relojoeiro, ";

        if (Mentalidade >= 25) // Sonhador
            ClassesDisponiveis += "Sonhador, ";

        if (Corpo >= 5 && Mentalidade >= 5) // Ressonante
            ClassesDisponiveis += "Ressonante, ";

        if (Ocultismo >= 7 && Riqueza <= 2 && Mentalidade <= 2) // Antigo
            ClassesDisponiveis += "Antigo, ";

        if (Riqueza == 1 || Riqueza == 10) // Bastardo do Labirinto
            ClassesDisponiveis += "Bastardo do Labirinto, ";

        if (Corpo <= 2 && Brutalidade <= 2) // Espectro
            ClassesDisponiveis += "Espectro, ";

        if (Mentalidade >= 5 && Ocultismo >= 5 && Corpo <= 2) // Marca das Profundezas
            ClassesDisponiveis += "Marca das Profundezas, ";

        if (ClassesDisponiveis.Length > 2)
            ClassesDisponiveis = ClassesDisponiveis.Substring(0, ClassesDisponiveis.Length - 2);
        else
            ClassesDisponiveis = "Nenhuma identidade disponível.";


        Console.WriteLine("\nIdentidades disponíveis para seu personagem: \n" + ClassesDisponiveis);

        while (true)
        {
            Console.WriteLine("\nEscreva o Nome da Sua Identidade Para saber Mais Sobre Ela (ou digite 'sair' para encerrar):\n");
            string? IdentidadeEscolhida = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(IdentidadeEscolhida) || IdentidadeEscolhida.Trim().ToLower() == "sair")
                break;

            switch (IdentidadeEscolhida)
            {
                case "Psíquico":
                    Console.WriteLine("\nSão os mestres da mente, capazes de afetar o mundo com a sua própria mente, além de tornarem a dos outros o seu parquinho de diversão. Infelizmente, são os com o corpo mais fraco e nem sempre são bons em reagir. Excelentes em dano mental e aplicação de efeitos de status\n");
                    break;
                case "Arquiteto":
                    Console.WriteLine("\nSão os mais conectados com o labirinto, arquitetos possuem um link tão forte com o labirinto que podem controlar partes do mesmo. É um segredo como surge um arquiteto, visto que, só os mais ricos os têm em sua família. Seu corpo é fortinho em todos os aspectos, além de seu controle sobre o labirinto, mas sua mente é bem frágil pela corrupção do labirinto. Excelentes em combate físico e em gerar ambientes favoráveis ou desfavoráveis.\n");
                    break;
                case "Escalador":
                    Console.WriteLine("\nSão os que nasceram para explorarem o labirinto. Capazes de se agarrar nas paredes lisas do labirinto e ainda por cima se jogar de um lado pro outro. Todos os grandes grupos possuem ao menos um, definitivamente úteis. Seu corpo é resistente e possuem considerável força física, frequentemente agarrando seus oponentes. Excelentes em combate físico e em incapacitar inimigos, independente do seu tamanho.\n");
                    break;
                case "Ritualista":
                    Console.WriteLine("\nSão os mais extremos entre todos. Ouviram a voz do labirinto junto da voz de infinitas almas em desespero, podem sacrificar itens, seres ou partes do corpo em troca de poderes temporários ou permanentes. São os mais variados, podendo serem tanto bons em combate corpo a corpo como bons em magia, tudo depende do que sacrificaram. Suas excelências variam de acordo com seus sacrifícios feitos.\n");
                    break;
                case "Armeiro":
                    Console.WriteLine("\nSão os únicos realmente capazes de utilizarem armas quentes, capazes de atingir alvos distantes com uma precisão mortal. Armas de fogo, arcos, bestas, fundas, oque for. Quão mais distante estiver de um armeiro, mais certo é o seu fim. O corpo dos mesmos não é dos melhores, mas são excelentes em reagir. Excelentes em combate a longa distância e em evitar ataques.\n");
                    break;
                case "Carrasco":
                    Console.WriteLine("\nSão a face da morte. Usuários de toda e qualquer arma branca, desde uma espada feita para a guerra até mesmo uma simples faca de cozinha. Seu corpo é bem comum entre os outros despertos, mas sua capacidade de causar feridas horríveis é além da comparação. Excelentes em combate corpo a corpo e assassinato.\n");
                    break;
                case "Demonologista":
                    Console.WriteLine("\nSão os únicos capazes de interagir com as criaturas do labirinto e domesticar as mesmas, mas não dependem somente delas. Alguns demonologistas foram vistos com livros profanos e realizando encantamentos tanto em sí quanto em seus animais. Seu corpo é normal, mais pende pro lado mais fraco. Sua excelência depende das criaturas domadas e encantamentos conhecidos.\n");
                    break;
                case "Acorrentado":
                    Console.WriteLine("\nSão castigados pelo próprio labirinto, mas a justiça do mesmo não o permite só causar o mal. Acorrentados tem a marca do labirinto em seus corpos e portanto, são tratados como semelhantes pelas criaturas dalí. Isso não significa que não são atacados, mas ao menos, conseguem evitar confrontos na maioria dos casos. Seus corpos são absurdos, porém, não possuem nenhum método mental ou habilidades de utilização de armas, somente seu corpo pode ser uma arma. São excelentes em combate corpo a corpo e em sobreviver a situações desesperadoras.\n");
                    break;
                case "Filho das Sombras":
                    Console.WriteLine("\nSão os discípulos de um ser misterioso. Capazes de criar e manipular as sombras, são os príncipes da noite, mas seus estágios iniciais são especialmente miseráveis. Suas excelências só se mostram após sobreviverem ao inferno inicial, mas quando se mostram, abrangem muitas áreas.\n");
                    break;
                case "Coração Radiante":
                    Console.WriteLine("\nSão aqueles que mais sonharam, sonharam tanto que de alguma forma, o sol, um astro há muito esquecido, respondeu a tais crianças. Possuem um poder purificador e capaz de queimar, desde que mantenham atrás de seus sonhos, tudo ao seu redor será batizado pelas chamas sagradas. São excelentes em prover suporte para um grupo e danos explosivos.\n");
                    break;
                case "Operário":
                    Console.WriteLine("\nSão os únicos capazes de fazer uso das porcarias inúteis que são colhidas do labirinto. \"Capazes de identificar o ouro em meio ao lixo\" é uma frase que os descreve, podem criar coisas além do normal, mas seu corpo é bem frágil por sí só. São excelentes em criar itens e gerar dinheiro.\n");
                    break;
                case "Relojoeiro":
                    Console.WriteLine("\nSão... estranhos. Capazes de afetar o tempo-espaço de determinadas áreas, junto de um operário, podem fazer coisas fora de comparação. Seu corpo é estranhamente comum, apesar de suas habilidades místicas fortes, mas sua mente é consumida a cada uso. São excelentes em controle de grupo e criação de itens.\n");
                    break;
                case "Sonhador":
                    Console.WriteLine("\nExistem somente dois seres conhecidos com essa identidade, sendo as duas crianças originais. Capazes de criar e manipular a realidade como se fosse nada, mas acabaram sendo devoradas pelo labirinto no fim. São deuses caídos.\n");
                    break;
                case "Ressonante":
                    Console.WriteLine("\nA Ressonância é uma habilidade perigosa: o indivíduo sintoniza seu corpo e alma com as vibrações do labirinto e das criaturas ao seu redor. Com cada batalha, o Ressonante se torna mais semelhante àquilo que ele enfrenta, adotando habilidades e deformidades momentâneas ou permanentes. Excelentes em adaptação durante combates e copiar habilidades temporárias.\n");
                    break;
                case "Antigo":
                    Console.WriteLine("\nPoucos sabem, mas há seres humanos que sobreviveram desde os primórdios do labirinto, preservados por forças além da compreensão. Os Antigos despertam com fragmentos da memória da Era Antiga e poderes que foram esquecidos. No entanto, o passado e o presente colidem em suas mentes, fazendo deles figuras instáveis. Excelentes em habilidades arcanas raras, mas com efeitos aleatórios.\n");
                    break;
                case "Bastardo do Labirinto":
                    Console.WriteLine("\nNinguém sabe se são humanos ou outra coisa, mas os Bastardos nascem com o labirinto impregnado em sua essência. Possuem um magnetismo que atrai eventos caóticos ao seu redor e prosperam no caos. Excelentes em manipulação da sorte e caos, mas difíceis de controlar.\n");
                    break;
                case "Espectro":
                    Console.WriteLine("\nUm indivíduo entre a vida e a morte. Esses seres caminham na fronteira entre os dois mundos, enxergando e interagindo com espíritos e almas perdidas. Conseguem atravessar paredes do labirinto por curtos períodos e corromper as almas de inimigos. Excelentes em evasão e furtividade.\n");
                    break;
                case "Marca das Profundezas":
                    Console.WriteLine("\nEsses seres ouviram algo nas camadas mais profundas do labirinto e sobreviveram para contar a história. São portadores de um conhecimento proibido e manifestam poderes diretamente relacionados às criaturas das profundezas. No entanto, quanto mais usam esses poderes, mais próximos estão de perder a sanidade. Excelentes em magia poderosa e destrutiva.\n");
                    break;
                default:
                    Console.WriteLine("\nIdentidade não reconhecida. Por favor, escolha uma identidade válida.");
                    break;
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}