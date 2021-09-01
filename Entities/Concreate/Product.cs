using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int BrandYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
