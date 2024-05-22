using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Livro> livros)
    {
        base.Executar(livros);
        Console.Write("Pressione qualquer tecla para fechar a aplicação...");
        Console.ReadKey();
    }
}
