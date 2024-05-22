using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Modelos;

internal class Livro
{
    public Livro(string titulo, string autor, string descricao)
    {
        Titulo = titulo;
        Autor = autor;
        Descricao = descricao;
    }

    public string Titulo { get; }
    public string Autor { get; set; }
    private string Descricao { get; set; }

    public static void ExibirDetalhes(Livro livro)
    {
        Console.WriteLine();
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($" - Autor: {livro.Autor}");
        Console.WriteLine($" - Descrição: {livro.Descricao}");
        Console.WriteLine();
    }

    public static void ExibirTodosOsLivros(Dictionary<string, Livro> livros)
    {
        foreach (var livro in livros)
        {
            ExibirDetalhes(livro.Value);
        }
    }
}
