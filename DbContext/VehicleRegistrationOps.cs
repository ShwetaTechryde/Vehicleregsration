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
        public void UpdateProduct(Vehichledatum vehichledatum)
        {
            var existingVehichle = _context.Vehichledata.FirstOrDefault(v => v.VehId == vehichledatum.VehId);

            if (existingVehichle != null)
            {
                // Update the properties of the existing record with new values
                existingVehichle.VehSerialno = vehichledatum.VehSerialno;
                existingVehichle.VehName = vehichledatum.VehName;
                existingVehichle.VehPrice = vehichledatum.VehPrice;
                // Repeat for all relevant properties

                // Save changes to the database
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Vehicle with ID {vehichledatum.VehId} not found.");
            }
        }
    }
}
