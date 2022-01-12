using _01_HuExercice3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HuExercice3.Interfaces
{
    internal interface IProductManager
    {
        Product GetProduct(Guid id);
        IEnumerable<Product> GetProducts();
        void UpdatePrudoct(Product product);
        void DeletePrudoct(Guid id);
        void CreatePrudoct(Product product);       
    }
}
