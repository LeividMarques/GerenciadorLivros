using System.Threading.Channels;

var livros = new List<string>();

while (true)
{
    Console.WriteLine("-----MENU PRINCIPAL----- \n\nBem vindo ao Gerenciador de Livros! O que gostaria de fazer?\n");
    Console.WriteLine("1- Cadastrar Livro:");
    Console.WriteLine("2- Listar Livros");
    Console.WriteLine("3- Remover Livro");
    Console.WriteLine("0- Sair\n");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("\nDigite o titulo do livro: \n");

            var nomeLivro = Console.ReadLine();

            livros.Add(nomeLivro);

            Console.WriteLine("\nLivro cadastrado com sucesso!\n");

            break;

        case "2":
            foreach(var livro in livros)
            {
                Console.WriteLine(livro);
            }
            break;

        case "3":
            Console.WriteLine("\nDigite o nome do livro que será removido:\n");

            var livroRemover = Console.ReadLine();

            var sucesso = livros.Remove(livroRemover);

            if (sucesso)
            {
                Console.WriteLine("\nLivro Removido com sucesso.\n");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado.\n");
            }

            break;

        case "0":
            Console.WriteLine("\nEncerrando a aplicação....\n");
            Thread.Sleep(2000);

            return;

        default:
            Console.WriteLine("Opção inválida!\n");
            break;
    }
}