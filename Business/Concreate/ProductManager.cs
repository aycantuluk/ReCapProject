using Business.Abstract;
using Entities.Concreate;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
  public  class ProductManager:IProductService
    {
        IProductDal ıproductDal;
        public ProductManager(IProductDal productDal)
        {
            ıproductDal = productDal;
        }
        public List<Product> GetAll()
        {
            return ıproductDal.GetAll();
        }

        
    }
}
