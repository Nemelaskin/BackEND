using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Drone
    {
        private int IdDrone;
        private string Model;
        private string DateDrone;
        private string StatusDrone;
        private int IdtoGroup;
        private int IdtoPatern;
        private string InCurrentPoint;
        public int idDrone { get { return IdDrone; } set { IdDrone = value; } }
        public string model { get { return Model; } set { Model = value; } }
        public string dateDrone { get { return DateDrone; } set { DateDrone = value; } }
        public string statusDrone { get { return StatusDrone; } set { StatusDrone = value; } }
        public int idtoGroup { get { return IdtoGroup; } set { IdtoGroup = value; } }
        public int idtoPatern { get { return IdtoPatern; } set { IdtoPatern = value; } }
        public string inCurrentPoint { get { return InCurrentPoint; } set { InCurrentPoint = value; } }
    }
}
