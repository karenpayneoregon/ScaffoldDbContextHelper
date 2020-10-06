﻿using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? Identifier { get; set; }
        public string CustomerIdOld { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual Customers CustomerIdOldNavigation { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
