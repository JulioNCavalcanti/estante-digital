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
    private string Autor { get; set; }
    private string Descricao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine();
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($" - Autor: {Autor}");
        Console.WriteLine($" - Descrição: {Descricao}");
        Console.WriteLine();
    }

    public static void ExibirTodosOsLivros(List<Livro> livros)
    {
        foreach (var livro in livros)
        {
            livro.ExibirDetalhes();
        }
    }
}
