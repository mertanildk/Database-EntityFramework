using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental Rental)
        {
            var result = _rentalDal.Get(v => v.Id == Rental.Id);
            if (result==null)
            {
                _rentalDal.Add(Rental);
                
                return new SuccessResult(Messages.AddedEntity);
            }
            return new ErrorResult(Messages.CantAdded);
        }

        public IResult Delete(Rental Rental)
        {

            _rentalDal.Delete(Rental);
            return new SuccessResult(Messages.DeletedEntity);
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll().Where(r => r.CustomerId == id).ToList());
        }

        public IDataResult<List<Rental>> GetByVehicleId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll().Where(r => r.VehicleId == id).ToList());
        }

        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental Rental)
        {

            _rentalDal.Update(Rental);
            return new SuccessResult(Messages.UpdatedEntity);
        }
    }
}
