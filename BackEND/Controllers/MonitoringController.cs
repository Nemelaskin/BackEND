using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data.Query;
using System.Data;
using BackEND.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BackEND.Controllers
{
    public class MonitoringController : Controller
    {
        InfoMethod InfoM = new InfoMethod();
        
        public string Index()
        {
            
            return "Temp";
        }

        public string Drones()
        {
            var json = InfoM.InfoDrone();
            return json;
        }
        public string Points()
        {
            var json = InfoM.InfoPoint();
            return json;
        }
        public string Comands()
        {
            var json = InfoM.InfoComand();
            return json;
        }
        public string Paterns()
        {
            var json = InfoM.InfoPatern();
            return json;
        }
        public string Groups()
        {
            var json = InfoM.InfoGroup();
            return json;
        }
    }
}
