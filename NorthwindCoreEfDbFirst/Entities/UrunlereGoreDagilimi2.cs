using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindCoreEfDbFirst.Entities
{
    public partial class UrunlereGoreDagilimi2
    {
        public int? Yil { get; set; }
        public string ProductName { get; set; }
        public int? Adet { get; set; }
        public decimal? Ciro { get; set; }
    }
}
