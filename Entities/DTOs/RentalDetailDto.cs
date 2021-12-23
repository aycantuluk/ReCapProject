using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentalId { get; set; }
        public string Carname { get; set; }
        public string Customername { get; set; }
        public DateTime Rentdate { get; set; }
        public DateTime Returndate { get; set; }
    }
}
