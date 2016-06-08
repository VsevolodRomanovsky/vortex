using System;

namespace TurnstileServer
{
    internal class Program
    {
        public static void Main()
        {
            Console.Title = "Server";
            Server.SetupServer();
            Console.ReadLine();
        }
    }
}
