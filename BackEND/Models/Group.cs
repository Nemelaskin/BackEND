using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Group
    {
        private int IdGroup;
        private string NameGroup;
        private string DescGroup;
        public int idGroup { get { return IdGroup; } set { IdGroup = value; } }
        public string nameGroup { get { return NameGroup; } set { NameGroup = value; } }
        public string descGroup { get { return DescGroup; } set { DescGroup = value; } }
    }
}
