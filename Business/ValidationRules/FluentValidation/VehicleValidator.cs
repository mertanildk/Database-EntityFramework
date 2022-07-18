using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class VehicleValidator :AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(p => p.VehicleName).NotEmpty();
            RuleFor(p => p.VehicleName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.VehicleTypeId == 1);
            //RuleFor(p => p.VehicleName).Must(StartWithA).WithMessage("Vehicles have to start with 'A'");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
