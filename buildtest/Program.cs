using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace buildtest
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverIP = "194.146.38.90";
            int port = 4444;


            if (false)
            {
                TcpClient clientSocket = new TcpClient();
                clientSocket.Connect(serverIP, port);
            }
            else
            {
                Console.WriteLine("Hello World!");

                TcpListener serverSocket = new TcpListener(
                    IPAddress.Any, port);
                serverSocket.Start();

                Console.WriteLine("ApiRequestListener Started");

                while ((true))
                {
                    var clientSocket = serverSocket.AcceptTcpClient();
                    Console.WriteLine("someone connected");
                }

                serverSocket.Stop();
                Console.WriteLine("Exiting...");
                Console.ReadLine();
            }
        }
    }
}
