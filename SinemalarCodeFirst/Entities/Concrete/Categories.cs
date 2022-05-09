using SinemalarCodeFirst.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemalarCodeFirst.Entities.Concrete
{
    public class Categories:BaseEntity
    {
        public List<Movie> FilmId { get; set; }
        public string KategoriAdi { get; set; }
        
    }
}
