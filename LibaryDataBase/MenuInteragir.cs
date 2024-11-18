using System;

public class MenuInteragir
{
    public LivrariaDB livraria = new LivrariaDB();
    private bool continuar = true;

    public void ExibirMenu()
    {
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
                    livraria.adicionarLivro();
                    break;
                case "2":
                    livraria.listarLivros();
                    break;
                case "3":
                    livraria.buscarLivroPorTitulo();
                    break;
                case "4":
                    livraria.removerLivro();
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
}


