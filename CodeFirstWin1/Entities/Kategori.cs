using CodeFirstWin1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Entities
{
    public class Kategori:BaseEntity
    {
        

        [Column("Ad")]
        [StringLength(50)]
        [Required]
        public string KategoriName { get; set; }

        [StringLength(100)]
        public string Acıklama { get; set; }
        public List<Stok> Stoklar { get; set; }
    }
}
