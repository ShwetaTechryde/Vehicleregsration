using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicleregsration.Models;
using Vehicleregsration.Interfaces;
namespace Vehicleregsration.DbContext
{
    public class VehicleRegistrationOps : IVehicles
    {
        private readonly AirlinesfeddbackContext _context;
        public VehicleRegistrationOps(AirlinesfeddbackContext context)
        {
            _context = context;
        }
        public void AddProduct(Models.Vehichledatum vehichledatum)
        {
            _context.Vehichledata.Add(vehichledatum);
            _context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var vehichledatum = _context.Vehichledata.Find(id);
            _context.Vehichledata.Remove(vehichledatum);
            _context.SaveChanges();
        }
        public List<Models.Vehichledatum> GetAllProducts()
        {
            return _context.Vehichledata.ToList();
        }
        public Models.Vehichledatum GetProductById(int id)
        {
            return _context.Vehichledata.Find(id);
        }
        public void UpdateProduct(Models.Vehichledatum vehichledatum)
        {
            _context.Vehichledata.Update(vehichledatum);
            _context.SaveChanges();
        }
    }
}
