using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertAPI.Models
{
    public class AdvertDbModel
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public AdvertStatus Status { get; set; }
    }
}
