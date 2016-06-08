using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TurnstileServer
{
    public class Server
    {
        private static byte[] _buffer;
        public static List<Socket> ClientSockets { get; }
        private static Socket _serverSocket;


        static Server()
        {
            _buffer = new byte[1024];
            ClientSockets = new List<Socket>();

            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static void SetupServer()
        {
            Console.WriteLine("Setting server...");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(5);
            _serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void AcceptCallback(IAsyncResult ar)
        {
            Socket socket = _serverSocket.EndAccept(ar);
            ClientSockets.Add(socket);
            Console.WriteLine("Client connect");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveCallback, socket);
            _serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            var ts = new TurnstileService.ServiceVisitClient(); //WCF (Authorization service)

            var socket = (Socket)ar.AsyncState;
            var received = socket.EndReceive(ar);
            var dataBuff = new byte[received];
            Array.Copy(_buffer, dataBuff, received);

            var permitId = BitConverter.ToInt32(dataBuff, 0);
            Console.WriteLine($"Text received: {permitId}");

            var random = new Random(); //входит или выходит


            var response = !ts.CheckValidation(permitId, random.Next(1, 2)) ?
                "Invalid Request" : $"Valid request. PermitId: {permitId}";

            var data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, SendCallback, socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, ReceiveCallback, socket);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            var socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }
    }
}
