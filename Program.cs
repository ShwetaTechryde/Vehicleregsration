using Microsoft.EntityFrameworkCore;
using Vehicleregsration.DbContext;
using Vehicleregsration.Models;
// Configure DbContext
var optionsBuilder = new DbContextOptionsBuilder<AirlinesfeddbackContext>();
optionsBuilder.UseSqlServer("YourConnectionStringHere"); // Replace with your actual connection string

var context = new AirlinesfeddbackContext(optionsBuilder.Options);
var vehicleOps = new VehicleRegistrationOps(context);

Console.WriteLine("Vehicle Registration CRUD Operations\n");

while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Product by ID");
    Console.WriteLine("3. View All Products");
    Console.WriteLine("4. Update Product");
    Console.WriteLine("5. Delete Product");
    Console.WriteLine("6. Exit");

    var choice = Console.ReadLine();

    switch (choice)
    {
        
        case "1":
            Console.WriteLine("Enter product ID to delete:");
            var deleteId = int.Parse(Console.ReadLine());
            vehicleOps.DeleteProduct(deleteId);
            Console.WriteLine("Product deleted successfully!");
            break;

        case "6":
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
