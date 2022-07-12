using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }//vehicle
        public int VehicleTypeId { get; set; }//vehicletype
        public int CustomerId { get; set; }//customer
        public string RentDate { get; set; }//this
        public string ReturnDate { get; set; }



    }
}
