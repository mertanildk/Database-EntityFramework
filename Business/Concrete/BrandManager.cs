using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand Brand)
        {
            _brandDal.Add(Brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand Brand)
        {
            _brandDal.Delete(Brand);
            return new SuccessResult();
        }

        public IDataResult<Brand> Get(int id)
        {
           return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.Id==id));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        public IResult Update(Brand Brand)
        {
            _brandDal.Update(Brand);
            return new SuccessResult(Messages.UpdatedEntity);
        }
    
    }
}
