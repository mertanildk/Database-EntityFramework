using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace FinalProjeBayram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental1 = new Rental() { Id=14 };


            //Console.WriteLine(rentalManager.Add(rental1).Message);

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //var result= colorManager.GetAll();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.ColorName);
            //}



            //BrandManager  brandManager = new BrandManager(new EfBrandDal());

            //foreach (var item in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            //rentalmanager rentalmanager = new rentalmanager(new efrentaldal());
            //var result = rentalmanager.getrentaldetails();
            //vehiclemanager vehiclemanager = new vehiclemanager(new efvehicledal());
            //var i = 0;
            //foreach (var rental in result.data)
            //{
                
            //    console.writeline("{0}. car details----", ++i);
            //    console.writeline("color name  : " + rental.colorname);
            //    console.writeline("brand name  :" + rental.brandname);
            //    console.writeline("vehicle type: " + rental.vehicletype);
            //    console.writeline();
            //}

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            foreach (var rental in result.Data)
            {
                Console.WriteLine("Vehicle Name  : " + rental.VehicleName);
                Console.WriteLine("Customer Name  :" + rental.CustomerName);
                Console.WriteLine();

            }


        }
    }
}
