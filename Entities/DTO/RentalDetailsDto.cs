using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class RentalDetailsDto:IDto
    {
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public int VehicleKm { get; set; }
        public string Vehicle { get; set; }
        public string CustomerName { get; set; }






    }
}
