using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVehicleService
    {
        IDataResult<List<Vehicle>> GetAll();
        IDataResult<Vehicle> Get(int id);
        IDataResult<List<Vehicle>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<Vehicle>> GetAllByColorId(int id);
        IDataResult<List<Vehicle>> GetByVehicleId(int id);
        IResult Add(Vehicle vehicle);
        IResult Delete(Vehicle vehicle);
        IResult Update(Vehicle vehicle);


    }
}
