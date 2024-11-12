namespace Atividade_MVC.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico}, Capacidade: {CapacidadeLitros}, Tem Freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}
