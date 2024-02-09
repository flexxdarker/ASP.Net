﻿using DataAccess.Model.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
        public decimal OrderSumm { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
