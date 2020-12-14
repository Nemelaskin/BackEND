using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEND.Socket;
using BackEND.Data.Query;
using System.Data;

namespace BackEND.Data
{
    public class EmergencyComands
    {
        InfoMethod InfoM = new InfoMethod();
        //CreateSocketToDrone ToDrone = new CreateSocketToDrone();
        private const string _coordinatsBase = "123.222,211.11,0.322";
        public void BackToBase(int idDrone)
        {
            InfoM.InfoDroneId(idDrone);
            //ToDrone.SendMessageToDrone(idDrone, Encoding.UTF8.GetBytes(_coordinatsBase));
        }
        public void GoToPoint(int idDrone, int ipPoint)
        {
            DataSet tablePoint = InfoM.InfoPointId(ipPoint);
            DataRow[] Pointrows = tablePoint.Tables[0].Select();
            string point = "To." + Pointrows[0].ItemArray[4].ToString();
            point += "." + Pointrows[0].ItemArray[5].ToString();
            point += "." + Pointrows[0].ItemArray[6].ToString();
            //ToDrone.SendMessageToDrone(idDrone, Encoding.UTF8.GetBytes(point));
        }
    }
}
