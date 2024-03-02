using GetYourDrink.Data.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourDrink.Bussiness.Products.Commands
{
    public class AddNewProductCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Alcohol { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public float Price { get; set; }
    }
}
