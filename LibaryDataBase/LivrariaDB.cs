public class LivrariaDB{

    public List<Livro> livros = new List<Livro>();
    int id = 0;

        public void adicionarLivro(){
            id++ ;
        Console.WriteLine("Titulo do Livro:");
        string nome = Console.ReadLine();

        Console.WriteLine("Autor do Livro:");
        string autor = Console.ReadLine();

        Console.WriteLine("Preço do Livro:");
        decimal preco = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade em Estoque:");
        int quantidadeEstoque = int.Parse(Console.ReadLine());

        Livro livro = new Livro(id, nome, autor, preco, quantidadeEstoque);
        livros.Add(livro);
    }

    public void listarLivros(){
        foreach(Livro livro in livros){
            Console.WriteLine("LIVRO:" + livro.titulo);
        }
    }

    public void buscarLivroPorTitulo(){
        Console.WriteLine("Digite o titulo do livro que você deseja fazer consulta:");
        string nome = Console.ReadLine();
            foreach(Livro livro in livros){
                if(livro.titulo == nome){
                    Console.WriteLine("Preço do livro: R$" + livro.preco);
                    Console.WriteLine("Quantidade em Estoque: " + livro.quantidadeEstoque);
                    Console.WriteLine("Autor: " + livro.autor);
                    Console.WriteLine("Id: " + livro.id);
                }
            }
    }

    public void removerLivro(){
        
        Console.WriteLine("Digite o ID do livro que deseja remover:");
        int idLivro = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < livros.Count; i++){
            if(idLivro == livros[i].id){
                livros.Remove(livros[i]);
            }
        

            Console.WriteLine("Livro removido com sucesso.");
        }
        
    }
}


    