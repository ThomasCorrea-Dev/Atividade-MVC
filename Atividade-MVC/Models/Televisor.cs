namespace Atividade_MVC.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico}, Polegadas: {TamanhoTela}, É Smart: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
