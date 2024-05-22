using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class Menu
{
    public static void ExibirOpcoesMenu(Dictionary<string, Livro> livros)
    {
        Console.Clear();
        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuAdicionarLivro());
        opcoes.Add(2, new MenuListarTodosOsLivros());
        opcoes.Add(3, new MenuRemoverUmLivro());
        opcoes.Add(4, new MenuFiltrarLivrosDeUmAutor());
        opcoes.Add(0, new MenuSair());

        Console.WriteLine(" -------------------------------- ");
        Console.WriteLine("| 1 | Adicionar um livro         |");
        Console.WriteLine("| 2 | Listar todos os livros     |");
        Console.WriteLine("| 3 | Remover um livro           |");
        Console.WriteLine("| 4 | Filtrar livros de um autor |");
        Console.WriteLine("| 0 | Sair                       |");
        Console.WriteLine(" -------------------------------- ");

        Console.Write("Digite a opção que deseja: ");
        int opcaoEscolhida = int.Parse(Console.ReadLine()!);

        if (opcoes.ContainsKey(opcaoEscolhida))
        {
            Menu menuASerExibido = opcoes[opcaoEscolhida];
            menuASerExibido.Executar(livros);
        }
        else
        {
            Console.WriteLine($"A opção {opcaoEscolhida} não existe!");
            Console.Write("Pressine qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            ExibirOpcoesMenu(livros);
        }

    }

    public virtual void Executar(Dictionary<string, Livro> livros)
    {
        Console.Clear();
    }
}
