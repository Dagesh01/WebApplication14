using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14.Services
{
    public interface IPizzaService
    {
        List<Pizza> GetAllPizzas();
        Pizza GetById(Guid Id);
        Pizza AddPizza(Pizza newPizza);
        Pizza UpdatePizza(Pizza Pizza);
        Pizza DeletePizza(Pizza Pizza);
    }
}
