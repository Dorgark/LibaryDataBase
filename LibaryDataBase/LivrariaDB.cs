public class LivrariaDB
{
    private List<Livro> livros;
    private int ultimoId;

    public LivrariaDB()
    {
        livros = new List<Livro>();
        ultimoId = 0; // Para gerar IDs incrementais
    }

    public void AdicionarLivro(string titulo, string autor, decimal preco, int quantidadeEstoque)
    {
        var novoLivro = new Livro
        {
            Id = ++ultimoId, // Gera um novo ID
            Titulo = titulo,
            Autor = autor,
            Preco = preco,
            QuantidadeEstoque = quantidadeEstoque
        };
        livros.Add(novoLivro);
        Console.WriteLine("Livro adicionado com sucesso!");
    }

    public List<Livro> ListarLivros()
    {
        return livros;
    }

    public Livro BuscarLivroPorTitulo(string titulo)
    {
        return livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoverLivro(int id)
    {
        var livro = livros.FirstOrDefault(l => l.Id == id);
        if (livro != null)
        {
            livros.Remove(livro);
            Console.WriteLine("Livro removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Livro não encontrado!");
        }
    }
}