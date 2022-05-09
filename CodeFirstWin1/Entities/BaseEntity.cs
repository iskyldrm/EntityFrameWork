using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin1.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateFate { get; set; }
        public DateTime UpdateDate { get; set; }
        

    }
}
