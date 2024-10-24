
        Biblioteca biblioteca = new Biblioteca();



        biblioteca.CadastrarLivro(new Livro("O Senhor dos Anéis", "001", "J.R.R. Tolkien", "978-85-365-0096-8", "Fantasia", 5));
        biblioteca.CadastrarLivro(new Livro("1984", "002", "George Orwell", "978-85-359-0277-0", "Ficção", 3));


        biblioteca.ListarLivros();


        biblioteca.CadastrarUsuario(new Usuario("João ", "001", "Rua A, 123", "98765-4321"));
        biblioteca.CadastrarUsuario(new Usuario("Maria ", "002", "Rua B, 456", "91234-5678"));


        biblioteca.ListarUsuarios();


        biblioteca.EmprestarLivro("001", "001");


        biblioteca.DevolverLivro("001");


        

        

