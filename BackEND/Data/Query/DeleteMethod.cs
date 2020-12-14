using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Data.Query
{
    public class DeleteMethod
    {
        ConnectBD cnnBD = new ConnectBD();
        private void ApiDelete(string query)
        {
            var temp = cnnBD.requery(query);
        }

        public void DeleteComand(string id)
        {
            ApiDelete("DELETE FROM [dbo].[Comand] WHERE idComand =" + id);
        }
        public void DeletePoint(string id)
        {
            ApiDelete("DELETE FROM [dbo].[Point] WHERE idPoint =" + id);
        }
        public void DeletePatern(string id)
        {
            ApiDelete("DELETE FROM [dbo].[Patern] WHERE idPatern =" + id);
        }
        public void DeleteGroup(string id)
        {
            ApiDelete("DELETE FROM [dbo].[GroupDrone] WHERE idGroup =" + id);
        }
        public void DeleteDrone(string id)
        {
            ApiDelete("DELETE FROM [dbo].[Drone] WHERE idDrone =" + id);
        }
        public void DeleteVideo(string id)
        {
            ApiDelete("DELETE FROM [dbo].[Video] WHERE idVideo =" + id);
        }
    }
}
