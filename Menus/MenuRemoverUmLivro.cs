using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Menus;

internal class MenuRemoverUmLivro : Menu
{
    public override void Executar(Dictionary<string, Livro> livros)
    {
        base.Executar(livros);

        Console.Write("Informe o título do liro que deseja remover: ");
        string tituloParaRemover = Console.ReadLine()!;

        if (livros.ContainsKey(tituloParaRemover))
        {
            Console.Write($"Digite \"remover\"  para confirmar a remoção do livro {tituloParaRemover}: ");
            string confirmarRemocao = Console.ReadLine()!;

            if (confirmarRemocao.Equals("remover", StringComparison.OrdinalIgnoreCase))
            {
                livros.Remove(tituloParaRemover);
                Console.WriteLine($"O livro {tituloParaRemover} foi removido com sucesso!");
            }
        }
        else
        {
            Console.WriteLine($"O livro {tituloParaRemover} não foi encontrado");
        }

        Console.Write("Pressine qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        ExibirOpcoesMenu(livros);
    }
}
