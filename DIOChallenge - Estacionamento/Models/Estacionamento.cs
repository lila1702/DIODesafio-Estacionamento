using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DIOChallenge___Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            bool continuar = false;
            string placaVeiculo = string.Empty;
            while (!continuar)
            {
                Console.WriteLine("Digite a placa do veículo aqui para estacionar:");
                placaVeiculo = Console.ReadLine();
                continuar = veiculo.CheckPlacaVálida(placaVeiculo);
            }

            Console.WriteLine("Digite o nome do motorista:");
            string motorista = Console.ReadLine();

            veiculo.Placa = placaVeiculo;
            veiculo.Motorista = motorista;
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(string placaVeiculo)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placaVeiculo);
            if (veiculo != null)
            {
                Console.WriteLine("Digite a quantidade de horas em que o veículo permaneceu no estacionamento:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {placaVeiculo} retirado, e o valor pago foi de {valorTotal}.");
            }
            else
            {
                Console.WriteLine($"Veículo {placaVeiculo} não encontrado. Verifique se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa}; Motorista: {veiculo.Motorista}");
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum veículo estacionado.");
            }
        }
    }
}
