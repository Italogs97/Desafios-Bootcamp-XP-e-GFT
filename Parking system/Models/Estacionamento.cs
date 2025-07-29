using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioEstacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private Dictionary<int, string> vagas = new Dictionary<int, string>();
        private int totalVagas = 10;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            if (vagas.Count == totalVagas)
            {
                Console.WriteLine("Desculpe, o estacionamento está lotado. Não há vagas disponíveis.");
                return;
            }

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                Console.WriteLine($"Digite o número da vaga (1 a {totalVagas}) para estacionar o veículo {placa}:");
                string vagaInput = Console.ReadLine() ?? string.Empty;
                int numeroVaga;

                if (!int.TryParse(vagaInput, out numeroVaga) || numeroVaga < 1 || numeroVaga > totalVagas)
                {
                    Console.WriteLine("Número de vaga inválido. Por favor, digite um número entre 1 e " + totalVagas + ".");
                    continue;
                }

                if (vagas.ContainsKey(numeroVaga))
                {
                    Console.WriteLine($"A vaga {numeroVaga} já está ocupada pelo veículo {vagas[numeroVaga]}. Por favor, escolha outra vaga.");
                }
                else
                {
                    vagas.Add(numeroVaga, placa);
                    Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso na vaga {numeroVaga}!");
                    break;
                }
            }
        }

        public void RemoverVeiculo()
        {
            while (true)
            {
                Console.WriteLine("Digite o número da vaga do veículo para remover (ou '0' para voltar ao menu):");
                string vagaInput = Console.ReadLine() ?? string.Empty;
                int numeroVaga;

                if (!int.TryParse(vagaInput, out numeroVaga))
                {
                    Console.WriteLine("Número de vaga inválido. Por favor, digite um número inteiro.");
                    continue;
                }

                if (numeroVaga == 0)
                {
                    Console.WriteLine("Operação cancelada.");
                    return;
                }

                if (vagas.ContainsKey(numeroVaga))
                {
                    string placa = vagas[numeroVaga];
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string horasInput = Console.ReadLine();
                    int horas = 0;

                    if (!int.TryParse(horasInput, out horas))
                    {
                        Console.WriteLine("Valor de horas inválido. Por favor, digite um número inteiro.");
                        continue; // Permite tentar novamente
                    }

                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    vagas.Remove(numeroVaga);

                    Console.WriteLine($"O veículo {placa} da vaga {numeroVaga} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                    GerarRecibo(placa, valorTotal, horas);
                    break; // Sai do loop após a remoção bem-sucedida
                }
                else
                {
                    Console.WriteLine("Desculpe, a vaga informada não está ocupada. Confira se digitou o número corretamente ou digite '0' para voltar ao menu.");
                }
            }
        }

        public void EditarVeiculo()
        {
            while (true)
            {
                Console.WriteLine("Digite o número da vaga do veículo que deseja editar (ou \'0\' para voltar ao menu):");
                string vagaInput = Console.ReadLine() ?? string.Empty;
                int numeroVaga;

                if (!int.TryParse(vagaInput, out numeroVaga))
                {
                    Console.WriteLine("Número de vaga inválido. Por favor, digite um número inteiro.");
                    continue;
                }

                if (numeroVaga == 0)
                {
                    Console.WriteLine("Operação cancelada.");
                    return;
                }

                if (vagas.ContainsKey(numeroVaga))
                {
                    string placaAntiga = vagas[numeroVaga];
                    Console.WriteLine($"A vaga {numeroVaga} está ocupada pelo veículo {placaAntiga}. Digite a nova placa para o veículo:");
                    string placaNova = Console.ReadLine() ?? string.Empty;

                    vagas[numeroVaga] = placaNova;
                    Console.WriteLine($"Placa do veículo na vaga {numeroVaga} alterada de {placaAntiga} para {placaNova} com sucesso!");
                    break; // Sai do loop após a edição bem-sucedida
                }
                else
                {
                    Console.WriteLine("Desculpe, a vaga informada não está ocupada. Confira se digitou o número corretamente ou digite \'0\' para voltar ao menu.");
                }
            }
        }

        public void ListarVeiculos()
        {
            if (vagas.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var vaga in vagas.OrderBy(v => v.Key))
                {
                    Console.WriteLine($"Vaga {vaga.Key}: {vaga.Value}");
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

