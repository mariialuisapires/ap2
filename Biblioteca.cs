


    public class Biblioteca
    {
      private List<Livro> Livros { get; set; } = new List<Livro>();
      private List<Usuario> Usuarios { get; set; } = new List<Usuario>();

      public void CadastrarLivro(Livro livro)
      {
        Livros.Add(livro);
        Console.WriteLine($"Livro '{livro.Titulo}' cadastrado com sucesso.");
      }

      public void CadastrarUsuario(Usuario usuario)
      {
        Usuarios.Add(usuario);
        Console.WriteLine($"Usuário '{usuario.Nome}' cadastrado com sucesso.");
      }

      public void ListarLivros()
      {
        Console.WriteLine("Lista de Livros:");
        foreach (var livro in Livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Código: {livro.Codigo}, Autor: {livro.Autor}, Gênero: {livro.Genero}, Estoque: {livro.QuantidadeEmEstoque}");
        }
      }

      public void ListarUsuarios()
      {
        Console.WriteLine("Lista de Usuários:");
        foreach (var usuario in Usuarios)
        {
            usuario.ExibirInformacoes();
        }
      }

      public void EmprestarLivro(string codigoLivro, string numeroUsuario)
      {
        var livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro));
        var usuario = Usuarios.FirstOrDefault(u => u.NumeroIdentificacao.Equals(numeroUsuario));

        if (livro != null && usuario != null)
        {
            livro.Emprestar(usuario);
        }
        else
        {
            Console.WriteLine("Livro ou usuário não encontrado.");
        }
      }

     public void DevolverLivro(string codigoLivro)
     {
        var livro = Livros.FirstOrDefault(l => l.Codigo.Equals(codigoLivro));

        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
     }
}
