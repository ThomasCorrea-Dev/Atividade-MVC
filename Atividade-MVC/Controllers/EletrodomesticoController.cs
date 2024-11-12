using Atividade_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_MVC.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Brastemp", Modelo = "BRE85AK", ConsumoEnergetico = 68, CapacidadeLitros = 588, TemFreezer = true },
                new Geladeira {Marca = "Electrolux", Modelo = "TF42", ConsumoEnergetico = 42, CapacidadeLitros = 410, TemFreezer = false },
                new Televisor {Marca = "Samsung", Modelo = "QLED 4K", ConsumoEnergetico = 22, TamanhoTela = 50, EhSmart = true }
            };
            return View(eletrodomesticos);
        }
    }
}
