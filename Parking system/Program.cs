using System;

namespace DesafioEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                              "Digite o preço inicial:");
            precoInicial = decimal.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = decimal.Parse(Console.ReadLine() ?? "0");

            // Instanciação via abstração
            EstacionamentoBase es = new Estacionamento(precoInicial, precoPorHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Veículo saiu");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Editar veículo");
                Console.WriteLine("5 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdicionarVeiculo();
                        break;

                    case "2":
                        es.RemoverVeiculo();
                        break;

                    case "3":
                        es.ListarVeiculos();
                        break;

                    case "4":
                        es.EditarVeiculo();
                        break;

                    case "5":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}