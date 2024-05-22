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

        Console.WriteLine(" ------------------------ ");
        Console.WriteLine("| 1 | Adicionar um livro |");
        Console.WriteLine(" ------------------------ ");

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
