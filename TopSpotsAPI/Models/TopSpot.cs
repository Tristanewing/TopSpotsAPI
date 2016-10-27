using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSpotsAPI.Models
{
    public class TopSpot
    {
        //Primary key
        public string name{ get;set; }
        public string Description { get; set; }
        public double[] Location{ get; set; }
       
    }
}