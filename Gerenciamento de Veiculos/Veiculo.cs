using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Veiculos
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoKM { get; set; }

        public Veiculo(string modelo, int ano, double capacidadeTanque, double consumoKM)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            ConsumoKM = consumoKM;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine("DETALHES: \n" +
                "Modelo: " + Modelo + "\nAno: " + Ano + "\nCapacidade do Tanque: " + CapacidadeTanque + "\nConsumo por Km: " + ConsumoKM);
        }

        public double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoKM;
        }
    }
}
