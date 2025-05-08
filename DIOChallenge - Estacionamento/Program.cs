using DIOChallenge___Estacionamento.Models;

namespace DIOChallenge___Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\nDigite o preço inicial:");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preco por hora:");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());

            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite o número correspondente à opção desejada:");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Retirar Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Encerrar Programa");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo(new Veiculo());
                        break;

                    case "2":
                        Console.WriteLine("Digite a placa do veículo que deseja retirar:");
                        string placaVeiculo = Console.ReadLine();
                        estacionamento.RemoverVeiculo(placaVeiculo);
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }

            Console.WriteLine("Obrigado por utilizar nosso sistema de estacionamento!");
        }
    }
}
