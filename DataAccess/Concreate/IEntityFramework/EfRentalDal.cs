
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.IEntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetProductDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CardId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 RentalId = rental.Id,
                                 Carname = brand.Name,
                                 Customername = user.FirstName + " " + user.LastName,
                                 Rentdate = rental.RentDate,
                                 Returndate = rental.ReturnDate
                             };

                return result.ToList();
            }
        }

    }
}

