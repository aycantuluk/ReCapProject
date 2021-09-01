﻿using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //GetById, GetAll, Add, Update, Delete 
        void All(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetById(int id);
        List<Product> GetAll();
    }
}
