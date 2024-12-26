using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicleregsration.Models;

namespace Vehicleregsration.Interfaces
{
    
    public interface IVehicles
    {
        void AddProduct(Vehichledatum product);
        Vehichledatum GetProductById(int id);
        List<Vehichledatum> GetAllProducts();
        void UpdateProduct(Vehichledatum product);
        void DeleteProduct(int id);
    }

}
