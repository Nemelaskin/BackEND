using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using BackEND.Socket;
using Emgu.CV.Util;


namespace BackEND
{
    public class VideoSocketManager
    {
        Timer timer;
        VideoCapture camera;
        public VideoSocketManager()
        {
            timer = new Timer(80);
            camera = new VideoCapture();
            
            timer.Elapsed += Timer_Elapsed;
            camera.Start();
            timer.Start();
        }
        public Byte[] ConvertToByte()
        {
            Image<Bgr, Byte> image = camera.QueryFrame().ToImage<Bgr, Byte>();
            var imgProcessed1 = image.Convert<Gray, byte>();

            return image.ToJpegData();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var temp1 = ConvertToByte();
            var temp2 = Convert.ToBase64String(temp1);
            WebSocketConn.SendPhoto(temp2);
        }
    }
}
