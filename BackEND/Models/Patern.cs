using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Patern
    {
        private int IdPatern;
        private string NamePatern;
        private string DescPatern;
        public int idPatern { get { return IdPatern; } set { IdPatern = value; } }
        public string namePatern { get { return NamePatern; } set { NamePatern = value; } }
        public string descPatern { get { return DescPatern; } set { DescPatern = value; } }
    }
}
