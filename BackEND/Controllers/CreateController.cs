using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data.Query;
using System.Data;

namespace BackEND.Controllers
{
    public class CreateController : Controller
    {
        AddUpdateMethod AddM = new AddUpdateMethod();
        InfoMethod InfoM = new InfoMethod();
        public string Index()
        {
            return "Temp";
        }
        public string Drone(string Model,string statusDrone, int IdtoGroup, int IdtoPatern) 
        {

            if (statusDrone == "") return "Not Ok";
            try
            {
                InfoM.InfoGroupId(IdtoGroup);
                InfoM.InfoPaternId(IdtoPatern);
                AddM.AddDrone(Model, statusDrone, IdtoGroup.ToString(), IdtoPatern.ToString(), "1.1.1");
                return "Ok!";
            } 
            catch(Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
        }

        public string Point(string NamePoint, string Desc, int x, int y, int z)
        {
            if (NamePoint == "" || Desc == "" || x.ToString() =="" || y.ToString() == "" || z.ToString() == "")
                return "Not OK";

            AddM.AddPoint(NamePoint, Desc, x.ToString(), y.ToString(), z.ToString());
            return "Ok!";
        }

        public string Comand(string NameComand, string Desc, int idToPatern)
        {
            if (NameComand == "" || Desc == "" || idToPatern.ToString() == "")
                return "Not OK";
            try
            {
                InfoM.InfoPaternId(idToPatern);
                AddM.AddComand(NameComand, Desc, idToPatern.ToString());
                return "Ok!";
            }
            catch(Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
        }

        public string Group(string NameComand, string Desc)
        {
            if (NameComand == "" || Desc == "")
                return "Not OK";
            
            AddM.AddGroup(NameComand, Desc);
            return "Ok!";
        }

        public string Patern(string NamePatern, string Desc)
        {
            if (NamePatern == "" || Desc == "" )
                return "Not OK";
            
            AddM.AddPatern(NamePatern, Desc);
            return "Ok!";
        }

    }
}
