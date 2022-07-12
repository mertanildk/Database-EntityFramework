using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;

        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public IResult Add(Vehicle vehicle)
        {

            if (vehicle.UnitPrice > 500)
            {
                return new ErrorResult(Messages.ChechVehicleName);

            }
            _vehicleDal.Add(vehicle);
            return new SuccessResult(Messages.AddedEntity);
        }

        public IResult Delete(Vehicle vehicle)
        {
            _vehicleDal.Delete(vehicle);
            return new SuccessResult(Messages.DeletedEntity);
        }

        public IDataResult<Vehicle> Get(int id)
        {
            return new SuccessDataResult<Vehicle>(_vehicleDal.Get(v => v.Id == id));
        }

        public IDataResult<List<Vehicle>> GetAll()
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll());
        }

        public IDataResult<List<Vehicle>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll(v => v.Id == id));
        }

        public IDataResult<List<Vehicle>> GetByVehicleId(int id)
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll(v => v.Id == id));
        }

        public IDataResult<List<Vehicle>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll(v => v.UnitPrice < max && v.UnitPrice > min));
        }

        public IResult Update(Vehicle vehicle)
        {
            _vehicleDal.Update(vehicle);
            return new SuccessResult(Messages.UpdatedEntity);
        }
    }
}
