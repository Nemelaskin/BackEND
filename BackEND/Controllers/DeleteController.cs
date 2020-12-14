using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data.Query;

namespace BackEND.Controllers
{
    public class DeleteController : Controller
    {
        InfoMethod InfoM = new InfoMethod();
        DeleteMethod DelM = new DeleteMethod();

        public string Index()
        {
            return "Temp";
        }

        public string Drone(int idDrone)
        {
            try
            {
                InfoM.InfoDroneId(idDrone);
                DelM.DeleteDrone(idDrone.ToString());
                return "Ok!";
            }
            catch(Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
        }
        public string Point(int idPoint)
        {
            try
            {
                InfoM.InfoPointId(idPoint);
                DelM.DeletePoint(idPoint.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }
        public string Comand(int idComand)
        {
            try
            {
                InfoM.InfoComandId(idComand);
                DelM.DeleteComand(idComand.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }
        public string Group(int idGroup)
        {
            try
            {
                InfoM.InfoGroupId(idGroup);
                DelM.DeleteGroup(idGroup.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }
        public string Patern(int idPatern)
        {
            try
            {
                InfoM.InfoPaternId(idPatern);
                DelM.DeletePatern(idPatern.ToString());
                return "Ok!";
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
                return "Not OK";
            }
            
        }
        
    }
}
