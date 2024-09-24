using System;

class Program
{
    static void Main(string[] args)
    {
        var livraria = new LivrariaDB();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menu da Livraria ---");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Listar Livros");
            Console.WriteLine("3. Buscar Livro por Título");
            Console.WriteLine("4. Remover Livro");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLivro(livraria);
                    break;
                case "2":
                    ListarLivros(livraria);
                    break;
                case "3":
                    BuscarLivroPorTitulo(livraria);
                    break;
                case "4":
                    RemoverLivro(livraria);
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("Encerrando o sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarLivro(LivrariaDB livraria)
    {
        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        string autor = Console.ReadLine();

        Console.Write("Digite o preço do livro: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade em estoque: ");
        int quantidadeEstoque = int.Parse(Console.ReadLine());

        livraria.AdicionarLivro(titulo, autor, preco, quantidadeEstoque);
    }

    static void ListarLivros(LivrariaDB livraria)
    {
        var livros = livraria.ListarLivros();
        Console.WriteLine("\n--- Lista de Livros ---");
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Id}: {livro.Titulo} - {livro.Autor} - R${livro.Preco} - Estoque: {livro.QuantidadeEstoque}");
        }
    }

    static void BuscarLivroPorTitulo(LivrariaDB livraria)
    {
        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        var livro = livraria.BuscarLivroPorTitulo(titulo);
        if (livro != null)
        {
            Console.WriteLine($"Livro encontrado: {livro.Titulo} - {livro.Autor} - R${livro.Preco} - Estoque: {livro.QuantidadeEstoque}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void RemoverLivro(LivrariaDB livraria)
    {
        Console.Write("Digite o ID do livro que deseja remover: ");
        int id = int.Parse(Console.ReadLine());

        livraria.RemoverLivro(id);
    }
}