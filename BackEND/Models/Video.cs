using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Video
    {
        private int IdVideo;
        private string NameVideo;
        private string PathVideo;
        private string DateVideo;
        private int IdtoDrone;
        public int idVideo { get { return IdVideo; } set { IdVideo = value; } }
        public string nameVideo { get { return NameVideo; } set { NameVideo = value; } }
        public string pathVideo { get { return PathVideo; } set { PathVideo = value; } }
        public string dateVideo { get { return DateVideo; } set { DateVideo = value; } }
        public int idtoDrone { get { return IdtoDrone; } set { IdtoDrone = value; } }
    }
}
