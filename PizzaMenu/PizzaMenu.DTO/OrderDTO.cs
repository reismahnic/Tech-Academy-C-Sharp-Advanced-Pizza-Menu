﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMenu.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderID { get; set; }
        public PizzaMenu.DTO.Enums.SizeType Size { get; set; }
        public PizzaMenu.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public PizzaMenu.DTO.Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }
        public decimal TotalCost { get; set; }
    }
}
