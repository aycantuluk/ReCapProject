using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
   public class InMemoryProductDal : ICarDal
    {
        List<Car> _products;
        public InMemoryProductDal()
        {
            _products = new List<Car> {
                new Car { Id=1,BrandId=2,ModelYear=1975,ColorId=5,DailyPrice=35000,Description="wolksvogen"},
                new Car { Id=2,BrandId=2,ModelYear=1875,ColorId=3,DailyPrice=45000,Description="volvo"},
                new Car { Id=3,BrandId=1,ModelYear=1675,ColorId=4,DailyPrice=45000,Description="honda"},
                new Car { Id=4,BrandId=3,ModelYear=1995,ColorId=34,DailyPrice=15000,Description="toyota"},
                new Car { Id=5,BrandId=4,ModelYear=1973,ColorId=44,DailyPrice=425000,Description="impala"},

             };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void All(Car product)
        {
            _products.Add(product);
        }

        public void Delete(Car product)
        {
            Car productDelete = _products.SingleOrDefault(p=>p.BrandId==product.BrandId);
            _products.Remove(productDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _products;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(object p)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _products.Where(p => p.BrandId==id ).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car product)
        {
            Car productUpdate = _products.SingleOrDefault(p => p.BrandId == product.BrandId);
            productUpdate.Description = product.Description;
            productUpdate.ColorId = product.ColorId;
        }
    }
}
