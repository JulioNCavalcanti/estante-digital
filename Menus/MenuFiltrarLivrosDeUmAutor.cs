using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class MenuFiltrarLivrosDeUmAutor : Menu
{
    public override void Executar(Dictionary<string, Livro> livros)
    {
        base.Executar(livros);

        Console.Write("Digite o nome de um autor: ");
        string nomeDoAutor = Console.ReadLine()!;

        var autores = livros.Values.Select(livro => livro.Autor).ToList();

        if (autores.Contains(nomeDoAutor))
        {
            var livrosDoAutor = livros.Values.Where(livro => livro.Autor.Equals(nomeDoAutor)).ToList();

            foreach (var livro in livrosDoAutor)
            {
                Livro.ExibirDetalhes(livro);
            }
        }
        else
        {
            Console.WriteLine($"O autor {nomeDoAutor} não foi encontrado");
        }

        Console.Write("Pressine qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirOpcoesMenu(livros);
    }
}
