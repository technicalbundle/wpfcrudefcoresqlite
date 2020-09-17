using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppDemoCRUD.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Unit { get; set; }
    }
}
