﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Order : BaseEntity
    {
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [MaxLength(15)]
        public string CustomerPhoneNumber { get; set; }

        [MaxLength(80)]
        public string CustomerEmail { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }
        public bool IsRefunded { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string OrderCode { get; set; }
    }
}
