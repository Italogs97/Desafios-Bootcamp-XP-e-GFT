using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioEstacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string horasInput = Console.ReadLine();
                int horas = 0;

                if (!int.TryParse(horasInput, out horas))
                {
                    Console.WriteLine("Valor de horas inválido. Por favor, digite um número inteiro.");
                    return;
                }

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                GerarRecibo(placa, valorTotal, horas);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private void GerarRecibo(string placa, decimal valor, int horas)
        {
            Console.WriteLine("\n--- RECIBO DE PAGAMENTO ---");
            Console.WriteLine($"Veículo: {placa.ToUpper()}");
            Console.WriteLine($"Horas estacionado: {horas}");
            Console.WriteLine($"Valor total: R$ {valor:F2}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Obrigado por utilizar nosso estacionamento!\n");
        }
    }
}


