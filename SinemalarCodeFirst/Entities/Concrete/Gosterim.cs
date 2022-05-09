using SinemalarCodeFirst.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemalarCodeFirst.Entities.Concrete
{
    public class Gosterim
    {
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public int HaftaId { get; set; }
        public Week Hafta { get; set; }
        public int SeansId { get; set; }
        public Seans Seans { get; set; }
        public int FilmId { get; set; }
        public Movie Film { get; set; }

    }
}
