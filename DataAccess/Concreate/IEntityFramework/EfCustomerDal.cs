using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.IEntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
    }
}
