using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Point
    {
        private int IdPoint;
        private string NamePoint;
        private string DescPoint;
        private int X;
        private int Y;
        private int Z;
        public int idPoint { get { return IdPoint; } set { IdPoint = value; } }
        public string namePoint { get { return NamePoint; } set { NamePoint = value; } }
        public string descPoint { get { return DescPoint; } set { DescPoint = value; } }
        public int x { get { return X; } set { X = value; } }
        public int y { get { return Y; } set { Y = value; } }
        public int z { get { return Z; } set { Z = value; } }
    }
}
