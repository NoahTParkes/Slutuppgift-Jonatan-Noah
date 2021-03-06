using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlutUppgift_Jonatan_Noah
{
    public class ProductManager
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string ImageFileName { get; set; }

        public string Color { get; set; }
    }
    public class Shirts : ProductManager 
    { 
        public string ShirtSize { get; set; }
    }

    public class Pants : ProductManager 
    { 
        public string PantsSize { get; set; }
    }

    public class Shoes : ProductManager
    {
        public int ShoeSize { get; set; }
    }

    
}
