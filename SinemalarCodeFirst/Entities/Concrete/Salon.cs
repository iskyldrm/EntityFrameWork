using SinemalarCodeFirst.Entities.Abstract;

namespace SinemalarCodeFirst.Entities.Concrete
{
    public class Salon : BaseEntity
    {
        public string SalonNo { get; set; }
        public char Kapasite { get; set; }

    }
}