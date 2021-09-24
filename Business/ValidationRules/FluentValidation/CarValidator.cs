using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarDailyPrice).NotEmpty();
            RuleFor(c => c.CarDailyPrice).GreaterThan(0);
            RuleFor(c => c.CarModelYear).GreaterThanOrEqualTo(2010);

            RuleFor(c => c.CarDailyPrice).GreaterThanOrEqualTo(20).When(c => c.CarBrandId == 1);

            RuleFor(c => c.CarModelYear).GreaterThanOrEqualTo(2010);
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Cars must start with A letter");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
