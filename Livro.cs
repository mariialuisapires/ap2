public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidade)
        : base(titulo, codigo)
    {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidade;
    }

    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            Console.WriteLine($"Empréstimo realizado com sucesso para {usuario.Nome} do livro '{Titulo}'.");
        }
        else
        {
            Console.WriteLine($"Não há exemplares disponíveis do livro '{Titulo}'.");
        }
    }

    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso.");
    }
}

