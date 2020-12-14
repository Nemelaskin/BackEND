using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Data.Query
{
    public class AddUpdateMethod
    {
        ConnectBD cnnBD = new ConnectBD();
        private void ApiAdd(string query)
        {
            var temp = cnnBD.requery(query);
        }

        //add
        public void AddPoint(string name, string desc, string x, string y, string z)
        {
            ApiAdd("INSERT INTO[dbo].[Point]([namePoint],[descPoint],[X],[Y],[Z],[extra])" +
                " VALUES('" + name + "','" + desc + "','" + x + "','" + y + "','" + z + "','extra')");
        }

        public void AddComand(string name, string desc, string idtoPatern)
        {
            ApiAdd("INSERT INTO[dbo].[Comand]([nameComand],[descComand],[idtoPatern],[extra])" +
                " VALUES('" + name + "','" + desc + "','" + idtoPatern + "','extra')");
        }

        public void AddPatern(string name, string desc)
        {
            ApiAdd("INSERT INTO[dbo].[Patern] ([namePatern],[descPatern],[extra]) " +
                "VALUES('" + name + "','" + desc + "','extra')");
        }

        public void AddDrone(string model, string statusDrone, string idtoGroup, string idtoPatern, string inCurrentPoint)
        {
            ApiAdd("INSERT INTO[dbo].[Drone] ([model],[statusDrone],[idtoGroup]," +
                "[idtoPatern],[inCurrentPoint],[extra])" +
                " VALUES('" + model + "','" + statusDrone + "','" + idtoGroup + "','" + idtoPatern + "','" + inCurrentPoint + "','extra')");
        }

        public void AddGroup(string name, string desc)
        {
            ApiAdd("INSERT INTO[dbo].[GroupDrone] ([nameGroup],[descGroup],[extra])" +
                " VALUES('" + name + "','" + desc + "','extra')");
        }

        public void AddVideo(string name, string path, string idtoDrone)
        {
            ApiAdd("INSERT INTO[dbo].[Video] ([nameVideo],[pathVideo],[idtoDrone],[extra]) " +
                "VALUES('" + name + "','" + path + "','" + idtoDrone + "','extra')");
        }

        //updates
        public void UpdatePoint(string id, string name, string desc, string x, string y, string z)
        {
            ApiAdd("UPDATE[dbo].[Point]SET[namePoint] = '" + name + "'," +
                "[descPoint] = '" + desc + "',[X] = '" + x + "',[Y] = '" + y + "',[Z] = '" + z + "',[extra] = 'extra' WHERE idPoint =" + id);
        }

        public void UpdateGroup(string id, string name, string desc)
        {
            ApiAdd("UPDATE[dbo].[GroupDrone] SET[nameGroup] = '" + name + "',[descGroup] = '" + desc + "',[extra] = 'extra' WHERE idGroup =" + id);
        }

        public void UpdateDrone(string id, string model, string statusDrone, string idtoGroup, string idtoPatern, string inCurrentPoint)
        {
            ApiAdd("UPDATE[dbo].[Drone] " +
                "SET[model] = '" + model + "',[statusDrone] = '" + statusDrone + "',[idtoGroup] = '" + idtoGroup + "'," +
                "[idtoPatern] = '" + idtoPatern + "'," +
                "[inCurrentPoint] = '" + inCurrentPoint + "',[extra] = 'extra' WHERE idDrone =" + id);
        }

        public void UpdateComand(string id, string name, string desc, string idtoPatern)
        {
            ApiAdd("UPDATE[dbo].[Comand] SET[nameComand] = '" + name + "'," +
                "[descComand] = '" + desc + "',[idtoPatern] = '" + idtoPatern + "',[extra] = 'extra' WHERE idComand =" + id);
        }

        public void UpdatePatern(string id, string name, string desc)
        {
            ApiAdd("UPDATE[dbo].[Patern] SET[namePatern] = '" + name + "'," +
                "[descPatern] = '" + desc + "',[extra] = 'extra' WHERE idPatern =" + id);
        }
    }
}
