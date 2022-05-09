using SinemalarCodeFirst.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemalarCodeFirst.Entities.Concrete
{
    public class Movie:BaseEntity
    {
        public string FilmAdi { get; set; }
        public List<Categories>  KategoriId { get; set; }
        public string Aciklama { get; set; }
        public string FilmSuresi { get; set; }


    }
}
