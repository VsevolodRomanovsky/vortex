using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TurnstileClient
{
    class Program
    {
        private static Socket _clientSocket = new Socket
                                             (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            Console.Title = "Visitor";
            LoopConnect();
            SendLoop();
            Console.ReadLine();
        }

        private static void SendLoop()
        {
            //просто перечислил все ID таблеток которые есть в БД
            int[] permitIds = { 100, 150, 110, 10, 120, 160, 180, 1 };

            while(true)
            {
                Thread.Sleep(5000);
                var rnd = new Random();
                Console.Write("Enter a request: ");
                //string req = Console.ReadLine();
                var buffer = BitConverter.GetBytes(permitIds[rnd.Next(0, 7)]);
                _clientSocket.Send(buffer);

                var receifedBuffer = new byte[1024];
                var rec = _clientSocket.Receive(receifedBuffer);
                var data = new byte[rec];

                Array.Copy(receifedBuffer, data, rec);
                Console.WriteLine(string.Format("Received: {0}", Encoding.ASCII.GetString(data)));
            }
        }

        private static void LoopConnect()
        {
            var attempts = 0;

            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("Connection attempts: {0}", attempts));
                }
            }
            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
