using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;
using Newtonsoft.Json;
using System.IO;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        private JsonConverter[] cProjects;

        public IEnumerable<TopSpot> Get()
        {
            var data = JsonConvert.DeserializeObject<List<TopSpot>>(File.ReadAllText("C:\\cProjects\\dev\\TopSpotsAPI\\TopSpotsAPI\\App_Data\\TopSpots.json"));
            return data;
        }
    }
}
