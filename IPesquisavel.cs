
    public interface IPesquisavel
    {
        ItemBiblioteca PesquisarPorTitulo(string titulo);
        ItemBiblioteca PesquisarPorAutor(string autor);
        ItemBiblioteca PesquisarPorGenero(string genero);
    }
