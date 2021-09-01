using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
   public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { Id=1,BrandId=2,BrandYear=1975,ColorId=5,DailyPrice=35000,Description="wolksvogen"},
                new Product { Id=2,BrandId=2,BrandYear=1875,ColorId=3,DailyPrice=45000,Description="volvo"},
                new Product { Id=3,BrandId=1,BrandYear=1675,ColorId=4,DailyPrice=45000,Description="honda"},
                new Product { Id=4,BrandId=3,BrandYear=1995,ColorId=34,DailyPrice=15000,Description="toyota"},
                new Product { Id=5,BrandId=4,BrandYear=1973,ColorId=44,DailyPrice=425000,Description="impala"},

             };
        }
        public void All(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productDelete = _products.SingleOrDefault(p=>p.BrandId==product.BrandId);
            _products.Remove(productDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            return _products.Where(p => p.BrandId==id ).ToList();
        }

        public void Update(Product product)
        {
            Product productUpdate = _products.SingleOrDefault(p => p.BrandId == product.BrandId);
            productUpdate.Description = product.Description;
            productUpdate.ColorId = product.ColorId;
        }
    }
}
