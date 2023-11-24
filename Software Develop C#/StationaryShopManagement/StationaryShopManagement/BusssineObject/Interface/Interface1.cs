﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement.BusssineObject.Interface
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Color { get; set; }
        double Weight { get; set; }
        double Price { get; set; }
        string Description { get; set; }
    }
}
