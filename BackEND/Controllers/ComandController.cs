using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Data;
using BackEND.Data.Query;

namespace BackEND.Controllers
{
    public class ComandController : Controller
    {
        EmergencyComands EmergCom = new EmergencyComands();
        InfoMethod InfoM = new InfoMethod();
        public string Index()
        {
            return "Temp";
        }
        public string EmergencyCommand(int Codecomand, int idDrone)
        {
            try
            {
                InfoM.InfoDroneId(idDrone);
                if (Codecomand == 101) //back to base
                {
                    EmergCom.BackToBase(idDrone);
                }
                return "Ok";
            }
            catch
            {
                return "Not ok";
            }
            
        }
        public string EmergencyCommand(int Codecomand, int idDrone, int idPoint)
        {
            try
            {
                InfoM.InfoDroneId(idDrone);
                InfoM.InfoPointId(idPoint);

                if (Codecomand == 102) //back to base
                {
                    EmergCom.GoToPoint(idDrone,idPoint);
                }
                return "Ok";
            }
            catch
            {
                return "Not ok";
            }
        }
    }
}
