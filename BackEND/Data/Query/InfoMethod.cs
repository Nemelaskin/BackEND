using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BackEND.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BackEND.Data.Query
{
    public class InfoMethod
    {
        ConnectBD cnnBD = new ConnectBD();
        private DataSet ApiInfo(string query)
        {
            var result = cnnBD.requery(query);
            return result;
        }

        public string InfoComand()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Comand]");
            DataRow[] rows = result.Tables[0].Select();
            Comand comand = new Comand();
            string json = "";
            for (int i = 0; i < rows.Length; i++)
            {
                string IdComand = rows[i].ItemArray[0].ToString();
                string NameComand = rows[i].ItemArray[1].ToString();
                string DescComand = rows[i].ItemArray[2].ToString();
                string IdtoPatern = rows[i].ItemArray[3].ToString();
                comand = new Comand
                {
                    idComand = Convert.ToInt32(IdComand),
                    nameComand = NameComand,
                    descComand = DescComand,
                    idtoPatern = Convert.ToInt32(IdtoPatern)
                };
                json += JsonSerializer.Serialize(comand);

            }
            return json;
        }

        public string InfoPatern()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Patern]");
            DataRow[] rows = result.Tables[0].Select();
            Patern patern = new Patern();
            string json = "";
            for (int i = 0; i < rows.Length; i++)
            {
                string IdPatern = rows[i].ItemArray[0].ToString();
                string NamePatern = rows[i].ItemArray[1].ToString();
                string DescPatern = rows[i].ItemArray[2].ToString();
                patern = new Patern()
                {
                    idPatern = Convert.ToInt32(IdPatern),
                    namePatern = NamePatern,
                    descPatern = DescPatern
                };
                json += JsonSerializer.Serialize(patern);
            }
            return json;
        }

        public string InfoGroup()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[GroupDrone]");
            DataRow[] rows = result.Tables[0].Select();
            Group group = new Group();
            string json ="";

            for (int i = 0; i < rows.Length; i++)
            {
                string IdGroup = rows[i].ItemArray[0].ToString();
                string NameGroup = rows[i].ItemArray[1].ToString();
                string DescGroup = rows[i].ItemArray[2].ToString();
                group = new Group()
                {
                    idGroup = Convert.ToInt32(IdGroup),
                    nameGroup = NameGroup,
                    descGroup = DescGroup
                };
                json += JsonSerializer.Serialize(group);
            }
            
            return json;
        }

        public string InfoPoint()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Point]");
            DataRow[] rows = result.Tables[0].Select();
            Point point = new Point();
            string json = "";
            for (int i = 0; i < rows.Length; i++)
            {
                string IdPoint = rows[i].ItemArray[0].ToString();
                string NamePoint = rows[i].ItemArray[1].ToString();
                string DescPoint = rows[i].ItemArray[2].ToString();
                string X = rows[i].ItemArray[3].ToString();
                string Y = rows[i].ItemArray[4].ToString();
                string Z = rows[i].ItemArray[5].ToString();
                point = new Point()
                {
                    idPoint = Convert.ToInt32(IdPoint),
                    namePoint = NamePoint,
                    descPoint = DescPoint,
                    x = Convert.ToInt32(X),
                    y = Convert.ToInt32(Y),
                    z = Convert.ToInt32(Z)
                };
                json += JsonSerializer.Serialize(point);
            }
            return json;
        }

        public string InfoVideo()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Video]");
            DataRow[] rows = result.Tables[0].Select();
            Video video = new Video();
            for (int i = 0; i < rows.Length; i++)
            {
                string IdVideo = rows[i].ItemArray[0].ToString();
                string NameVideo = rows[i].ItemArray[1].ToString();
                string PathVideo = rows[i].ItemArray[2].ToString();
                string DateVideo = rows[i].ItemArray[3].ToString();
                string IdtoDrone = rows[i].ItemArray[4].ToString();
                video = new Video()
                {
                    idVideo = Convert.ToInt32(IdVideo),
                    nameVideo = NameVideo,
                    pathVideo = PathVideo,
                    dateVideo = DateVideo,
                    idtoDrone = Convert.ToInt32(IdtoDrone)
                };
            }
            string json;
            json = JsonSerializer.Serialize(video);
            return json;
        }
        
        public string InfoDrone()
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Drone]");
            DataRow[] rows = result.Tables[0].Select();
            Drone drone = new Drone();
            string json = "";
            for (int i = 0; i < rows.Length; i++)
            {
                string IdDrone = rows[i].ItemArray[0].ToString();
                string Model = rows[i].ItemArray[1].ToString();
                string dateDrone = rows[i].ItemArray[2].ToString();
                string statusDrone = rows[i].ItemArray[3].ToString();
                string IdtoGroup = rows[i].ItemArray[4].ToString();
                string IdtoPatern = rows[i].ItemArray[5].ToString();
                string InCurrentPoint = rows[i].ItemArray[6].ToString();
                drone = new Drone
                {
                    idDrone = Convert.ToInt32(IdDrone),
                    model = Model,
                    dateDrone = dateDrone,
                    statusDrone = statusDrone,
                    idtoGroup = Convert.ToInt32(IdtoGroup),
                    idtoPatern = Convert.ToInt32(IdtoPatern),
                    inCurrentPoint = InCurrentPoint
                };
                json += JsonSerializer.Serialize(drone);
            }
            
            //List<Drone> o = JsonConvert.DeserializeObject<List<Drone>>(str);
            return json;
        }

        /////////////////////
        public DataSet InfoDroneId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Drone] WHERE idDrone =" + id.ToString());
            return result;
        }
        public DataSet InfoComandId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Comand] WHERE idComand =" + id.ToString());
            return result;
        }
        public DataSet InfoPaternId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Patern] WHERE idPetern =" + id.ToString());
            return result;
        }
        public DataSet InfoGroupId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[GroupDrone] WHERE idGroup =" + id.ToString());
            return result;
        }
        public DataSet InfoPointId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Point] WHERE idPoint =" + id.ToString());
            return result;
        }
        public DataSet InfoVideoId(int id)
        {
            DataSet result = ApiInfo("SELECT * FROM [SecuritySystem].[dbo].[Video] WHERE idVideo =" + id.ToString());
            return result;
        }
    }
}
