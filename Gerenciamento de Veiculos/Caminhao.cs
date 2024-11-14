using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Veiculos
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }
        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoKM, double cpcdCarga)
            :base(modelo, ano, capacidadeTanque, consumoKM)
        {
            CapacidadeCarga= cpcdCarga;
        }
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine("Capacidade de Carga: " + CapacidadeCarga + "\n");
        }
        public double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoKM * CapacidadeCarga; 
        }
    }
}
