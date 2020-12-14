using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Timers;
using System.Drawing;

namespace BackEND.Socket
{
    public class WebSocketConn
    {

        public static byte[] bytesPhoto;

        public static Func<HttpContext, Func<Task>, Task> WebSocketConnect()
        {
            return async (http, next) =>
            {
                if (http.WebSockets.IsWebSocketRequest && http.Request.Path == "/ws")
                {
                    Program.wb = await http.WebSockets.AcceptWebSocketAsync();
                    await Task.Run(async () =>
                    {
                        while (Program.wb.State == System.Net.WebSockets.WebSocketState.Open)
                        {
                            byte[] bt = new byte[1024];
                            System.Net.WebSockets.WebSocketReceiveResult rc = await Program.wb.ReceiveAsync(bt, CancellationToken.None);
                            //string txt = System.Text.Encoding.UTF8.GetString(bt);
                            //Console.WriteLine(txt);
                            //await Program.wb.SendAsync(System.Text.Encoding.UTF8.GetBytes("АДНРЕЙ"), System.Net.WebSockets.WebSocketMessageType.Text, true, CancellationToken.None);
                            //System.Text.Encoding.UTF8.GetBytes("АДНРЕЙ"),
                        }
                    });
                }
                else
                {
                    await next();
                }
            };
        }

        public async static void SendPhoto(string bytes)
        {
            await Program.wb.SendAsync(System.Text.Encoding.ASCII.GetBytes(bytes), System.Net.WebSockets.WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}
