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
        public Byte[,,] ConvertToByteTest()
        {
            Image<Bgr, Byte> image = camera.QueryFrame().ToImage<Bgr, Byte>();

            var imgProcessed1 = image.Convert<Gray, byte>();
            /*image.Save("orig.png");
            Image<Gray, Single> img_final = (imgProcessed1.Sobel(1, 0, 5));
            img_final.Save("infFin.png");
            Image<Gray, float> sobel = img_final.Sobel(0, 1, 3).Add(img_final.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
            sobel.Save("geg.png");*/

            /*var min = new Gray(202.111);
            var max = new Gray(255);
            img_final.InRange(max,max);*/

            /*CvMemStorage storage = new CvMemStorage(0);
            CvSeq contours = new CvSeq(new IntPtr(0));*/

            //Emgu.CV.CvInvoke.FindContours(img_final, contours,);
            ////////////////
            //int contoursCont = cvFindContours(bin, storage, &contours, sizeof(CvContour), CV_RETR_LIST, CV_CHAIN_APPROX_SIMPLE, cvPoint(0, 0));

            ///////////////////////
            
            return (byte[,,])image.Mat.GetData();
        }
        

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var temp1 = ConvertToByte();
            var temp2 = Convert.ToBase64String(temp1);
            WebSocketConn.SendPhoto(temp2);
        }
    }
}
