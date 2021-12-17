using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.DataEF;
using WebApplication14.Models;

namespace WebApplication14.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly ApplicationDbContext _dbContext;
        public PizzaService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pizza AddPizza(Pizza newPizza)
        {
            throw new NotImplementedException();
        }

        public Pizza DeletePizza(Pizza Pizza)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAllPizzas()
        {
            throw new NotImplementedException();
        }

        public Pizza GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Pizza UpdatePizza(Pizza Pizza)
        {
            throw new NotImplementedException();
        }
    }
}
