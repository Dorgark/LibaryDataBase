public class Livro{
    public int id;
    public string titulo;
    public string autor;
    public decimal preco;
    public int quantidadeEstoque;

    public Livro(int id, string titulo, string autor, decimal preco, int quantidadeEstoque) {
            this.id = id;
            this.titulo = titulo; 
            this.autor = autor; 
            this.preco = preco; 
            this.quantidadeEstoque = quantidadeEstoque;
    }
}