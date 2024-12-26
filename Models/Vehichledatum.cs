using System;
using System.Collections.Generic;

namespace Vehicleregsration.Models;

public partial class Vehichledatum
{
    public int VehId { get; set; }

    public int VehSerialno { get; set; }

    public string? VehName { get; set; }

    public int VehPrice { get; set; }
}
