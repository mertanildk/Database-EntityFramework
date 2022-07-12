using Core.Entities;

namespace Entities.Concrete
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int VehicleTypeId { get; set; }
        public int UnitPrice { get; set; }
        public string VehicleName { get; set; }


    }
}
