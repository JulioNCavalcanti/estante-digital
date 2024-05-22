using EstanteDigital.Menus;
using EstanteDigital.Modelos;

Dictionary<string, Livro> livros = new Dictionary<string, Livro>()
{
    { "Dom Quixote", new Livro("Dom Quixote", "Miguel de Cervantes", "Um romance clássico espanhol considerado uma das obras mais importantes da literatura ocidental. Conta a história de um fidalgo espanhol que se torna cavaleiro andante e sai em busca de aventuras.") },
    { "1984", new Livro("1984", "George Orwell", "Um romance distópico que se passa em um futuro totalitário onde o governo controla todos os aspectos da vida das pessoas. Winston Smith, o protagonista, trabalha para o Ministério da Verdade, reescrevendo a história para se adequar à propaganda do governo. No entanto, ele se rebela contra o regime e se junta à Irmandade, um movimento clandestino que luta pela liberdade.") }
};

Menu.ExibirOpcoesMenu(livros);

