using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SpearmanLib;

namespace TCPServer
{
    class Server
    {
        static void Main(string[] args)
        {
  
            IPAddress ipAddr = IPAddress.Any;
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8080);
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);

                Console.WriteLine("Server started!");

                while (true)
                {

                    Socket handler = sListener.Accept();
                    string data = null;

                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);

                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                    string[] Res = data.Split("|");

                    Console.Write("Data from client: X:" + Res[0] + "; Y:" + Res[1] + "\n\n");

                    int[] arrX = Array.ConvertAll(Res[0].Split(","), int.Parse);
                    int[] arrY = Array.ConvertAll(Res[1].Split(","), int.Parse);

                    double rho = arrX.SpearmansCoeff(arrY);

                    string reply = rho.ToString();

                    Console.Write("Reply to client: " + reply + "\n\n");

                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
