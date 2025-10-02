using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace proj_Sistema_para_Estacionamento.Models
{
    public class Estancionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estancionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"O veiculo {placa.ToUpper()} estacionada com sucesso!");

        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine()!.ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu no estacionamento:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorFinal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"Veiculo {placa} removido valor a pagar: R$ {valorFinal}");

            }
            else
            {
                Console.WriteLine("Desculpe esse veiculo nao esta estancionado aqui");
            }

        }
        public void ListarVeiculo()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veiculos Estancionados: ");
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"- {v}");
                }

            }
            else
            {
                Console.WriteLine("Não ha veiculos estancionados.");
            }
        }
    }
}