using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int id);
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetAllByCustomerId(int id);
        IDataResult<List<Rental>> GetByVehicleId(int id);
        IResult Add(Rental Rental);
        IResult Delete(Rental Rental);
        IResult Update(Rental Rental);


    }
}
