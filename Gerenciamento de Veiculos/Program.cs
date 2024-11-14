using Gerenciamento_de_Veiculos;

Veiculo c = new Carro("Palio", 2012, 100, 20, "Fiat");
Veiculo C = new Caminhao("Caminhao", 2010, 300, 40, 10);

//c.ExibirDetalhes();
//C.ExibirDetalhes();

double consumo = c.CalcularConsumo(20);
Console.WriteLine(consumo);
double Consumo = C.CalcularConsumo(20);
Console.WriteLine(Consumo);

List<IVeiculo> lista = new List<IVeiculo> { c, C };

foreach(IVeiculo v in lista)
{
    v.ExibirDetalhes();
    v.CalcularConsumo(20);
}