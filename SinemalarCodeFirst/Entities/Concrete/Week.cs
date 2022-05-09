using SinemalarCodeFirst.Entities.Abstract;
using System;

namespace SinemalarCodeFirst.Entities.Concrete
{
    public class Week:BaseEntity
    {
        public int Hafta { get; set; }
        public DateTime Baslama { get; set; }
        public DateTime Bitis { get; set; }

    }
}