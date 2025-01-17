using System;

class Program
{
    static void Main(string[] args)
    {
        var banco = new PessoasDB();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menu do Banco de Pessoas ---");
            Console.WriteLine("1. Adicionar Pessoa");
            Console.WriteLine("2. Listar Pessoas");
            Console.WriteLine("3. Buscar Pessoa pelo nome");
            Console.WriteLine("4. Remover Pessoa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarPessoa(banco);
                    break;
                case "2":
                    ListarPessoas(banco);
                    break;
                case "3":
                    BuscarPessoaPeloNome(banco);
                    break;
                case "4":
                    RemoverPessoa(banco);
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

    static void AdicionarPessoa(PessoasDB banco)
    {
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o CPF da pessoa: ");
        string cpf = Console.ReadLine();

        Console.Write("Digite o endereço da pessoa: ");
        string endereco = Console.ReadLine();

        Console.Write("Digite a quantidade de viagens feitas: ");
        int quantidadeViagens = int.Parse(Console.ReadLine());

        banco.AdicionarPessoa(nome, cpf, endereco, quantidadeViagens);
    }

    static void ListarPessoas(PessoasDB banco)
    {
        var pessoas = banco.ListarPessoas();
        Console.WriteLine("\n--- Lista de Pessoas ---");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($" ID: {pessoa.Id} Nome: {pessoa.Nome} - CPF: {pessoa.CPF} - Endereço: {pessoa.Endereco} - Viagens: {pessoa.QuantidadeViagens}");
        }
    }

    static void BuscarPessoaPeloNome(PessoasDB banco)
    {
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();

        var pessoa = banco.BuscarPessoaPeloNome(nome);
        if (pessoa != null)
        {
            Console.WriteLine($"Pessoa encontrada: ID: {pessoa.Id} Nome: {pessoa.Nome} - CPF: {pessoa.CPF} - Endereço: {pessoa.Endereco} - Viagens: {pessoa.QuantidadeViagens}");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }
    }

    static void RemoverPessoa(PessoasDB banco)
    {
        Console.Write("Digite o ID da pessoa que deseja remover: ");
        int id = int.Parse(Console.ReadLine());

        banco.RemoverPessoa(id);
    }
}