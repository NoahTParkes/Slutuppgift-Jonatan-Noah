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
   public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string ImageFileName { get; set; }

        public string Color { get; set; }
        
    }

    public class Shirt : Product
    {
        public string ShirtSize { get; set; }
    }

    public class Trousers : Product
    {
        public string TrouserSize { get; set; }
    }
   public class Shoe : Product
    {
        public string ShoeSize { get; set; }
    }

}
