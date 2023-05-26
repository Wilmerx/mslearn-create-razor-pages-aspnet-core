using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    public class ListadePizzasModel : PageModel
    {
        private readonly PizzaService _service;
        public IList<Pizza> ListadePizza { get;set; } = default!;

        public ListadePizzasModel(PizzaService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            ListadePizza = _service.GetPizzas();
        }
    }
}
