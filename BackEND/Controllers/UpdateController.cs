using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data.Query;

namespace BackEND.Controllers
{
    public class UpdateController : Controller
    {
        AddUpdateMethod UpdateM = new AddUpdateMethod();
        InfoMethod InfoM = new InfoMethod();

        public string Index()
        {
            return "temp";
        }

        public string UpdateDrone(int idDrone, string Model, int idtoGroup, int idtoPatern)
        {
            if (idDrone.ToString() == "" || Model == "" || idtoGroup.ToString() == "" || idtoPatern.ToString() == "")
                return "Not OK!";
            try
            {
                InfoM.InfoDroneId(idDrone);
                InfoM.InfoGroupId(idtoGroup);
                InfoM.InfoPaternId(idtoPatern);
                string StatusDrone = "Waiting";
                UpdateM.UpdateDrone(idDrone.ToString(), Model, StatusDrone, idtoGroup.ToString(), idtoPatern.ToString(), "1.1.1");
                return "Ok!";
            }
            catch(Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }

        public string UpdateGroup(int idGroup, string NameGroup, string Desc)
        {
            if (idGroup.ToString() == "" || NameGroup == "" || Desc == "" )
                return "Not OK!";
            try
            {
                InfoM.InfoGroupId(idGroup);
                UpdateM.UpdateGroup(idGroup.ToString(), NameGroup, Desc);
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }

        public string UpdatePatern(int idPatern, string NamePatern, string Desc)
        {
            if (idPatern.ToString() == "" || NamePatern == "" || Desc == "")
                return "Not OK!";
            try
            {
                InfoM.InfoPaternId(idPatern);
                UpdateM.UpdatePatern(idPatern.ToString(), NamePatern, Desc);
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }

        public string UpdateComand(int idComand, string NamePatern, string Desc, int idtoPatern)
        {
            if (idComand.ToString() == "" || NamePatern == "" || Desc == "" || idtoPatern.ToString() == "")
                return "Not OK!";
            try
            {
                InfoM.InfoComandId(idComand);
                InfoM.InfoPaternId(idtoPatern);
                UpdateM.UpdateComand(idComand.ToString(), NamePatern, Desc, idtoPatern.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }

        public string UpdatePoint(int idPoint, string NamePoint, string Desc, int x,int y, int z)
        {
            if (idPoint.ToString() == "" || NamePoint == "" || Desc == "" || x.ToString() == "" || y.ToString() == "" || z.ToString() == "")
                return "Not OK!";
            try
            {
                InfoM.InfoPointId(idPoint);
                UpdateM.UpdatePoint(idPoint.ToString(), NamePoint, Desc, x.ToString(), y.ToString(), z.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK!";
            }
            
        }

        
    }
}
