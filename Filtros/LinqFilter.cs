using EstanteDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDigital.Filtros;

internal class LinqFilter
{
    public static void FiltrarLivrosDeUmAutor(Dictionary<string, Livro> livros, string autor)
    {
        var livrosDoAutor = livros.Values.Where(livro => livro.Autor.Equals(autor)).ToList();

        foreach (var livro in livrosDoAutor)
        {
            Livro.ExibirDetalhes(livro);
        }
    }
}
