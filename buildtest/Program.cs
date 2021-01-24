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
            Console.WriteLine("Hello World!");

            TcpListener serverSocket = new TcpListener(
                IPAddress.Any, 22);
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
