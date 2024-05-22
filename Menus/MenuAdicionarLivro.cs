using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class MenuAdicionarLivro : Menu
{
    public override void Executar(Dictionary<string, Livro> livros)
    {
        base.Executar(livros);
        Console.WriteLine("Adicionar um livro à sua biblioteca");
        Console.Write("Digite o nome título do livro: ");

        string titulo = Console.ReadLine()!;

        if (!livros.ContainsKey(titulo!))
        {
            Console.Write($"Digite o nome do autor do livro {titulo}: ");
            string autor = Console.ReadLine()!;

            Console.Write($"Digite uma descrição para o livro {titulo}: ");
            string descricao = Console.ReadLine()!;

            Livro livro = new(titulo, autor, descricao);
            livros.Add(titulo, livro);

            Console.WriteLine($"O livro {titulo} foi adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine($"O livro {titulo} já está cadastrado!");
        }

        Console.Write("Pressine qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirOpcoesMenu(livros);
    }
}
