using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, VehicleSellingContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (VehicleSellingContext context = new VehicleSellingContext())
            {

                var result = from r in context.Rentals
                             join v in context.Vehicles on r.VehicleId equals v.Id
                             join c in context.Customers on r.CustomerId equals c.Id
                             select new RentalDetailsDto { VehicleName = v.VehicleName, CustomerName = c.CompanyName };





                return result.ToList();
            }

        }
      
    }
}
