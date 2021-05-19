﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class OrderDetail
    {
        [Key]
        [ForeignKey("OrderHeader")]
        public int OrderId { get; set; }
        public OrderHeader OrderHeader { get; set; }

        [Key]
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }

        public int ExtPrice { get; set; }

    }
}
