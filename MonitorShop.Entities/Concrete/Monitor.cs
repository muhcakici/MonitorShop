using MonitorShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonitorShop.Entities.Concrete
{
    public class Monitor : IEntity
    {
        [Key]
        public int MonitiorId { get; set; }
        public string Model { get; set; }
        public int Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public Monitor()
        {

        }
        public Monitor(string model, int stock, decimal unitPrice)
        {
            Model = model;
            Stock = stock;
            UnitPrice = unitPrice;
        }
        public override string ToString()
        {
            return $"{MonitiorId,-5} {Model,-30} {Stock,-20} {UnitPrice,-20}";
        }
    }
}
