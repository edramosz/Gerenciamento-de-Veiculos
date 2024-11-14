using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Veiculos
{
    public class Carro : Veiculo
    {
        public string Tipo { get; set; }
        public Carro(string modelo, int ano, double capacidadeTanque, double consumoKM, string tipo)
            : base(modelo, ano, capacidadeTanque, consumoKM)
        {
            Tipo = tipo;
        }
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine("Tipo: " + Tipo + "\n");
        }
        public double CalcularConsumo(double distancia)
        {
            Console.WriteLine("É híbrido?  1 - Sim  2 - Não");
            int resposta = int.Parse(Console.ReadLine());
            if(resposta == 1)
            {
                return distancia / ConsumoKM / 2;
            }
            else
            {
                return distancia / ConsumoKM;
            }
        }
    }
}
