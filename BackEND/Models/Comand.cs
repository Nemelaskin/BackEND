using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Comand
    {
        private int IdComand;
        private string NameComand;
        private string DescComand;
        private int IdtoPatern;
        public int idComand { get { return IdComand; } set { IdComand = value; } }
        public string nameComand { get { return NameComand; } set { NameComand = value; } }
        public string descComand { get { return DescComand; } set { DescComand = value; } }
        public int idtoPatern { get { return IdtoPatern; } set { IdtoPatern = value; } }
    }
}
