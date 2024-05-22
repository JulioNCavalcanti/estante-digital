using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class MenuListarTodosOsLivros : Menu
{
    public override void Executar(Dictionary<string, Livro> livros)
    {
        base.Executar(livros);
        Livro.ExibirTodosOsLivros(livros);

        Console.Write("Pressine qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirOpcoesMenu(livros);
    }
}
