using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatServer
{
    class Program
    {
        private static IPAddress ip;
        private static TcpListener serverSocket;
        private static TcpClient clientSocket;
        static void Main(string[] args)
        {
            ip = IPAddress.Parse("192.168.1.37");
            serverSocket = new  TcpListener(ip,8088);
            clientSocket = default(TcpClient);
            while(true)
            {
            string command;
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Chat Server console.\n\nPlease type command.\n");
            Console.WriteLine("\t[start]\tStart Chat Server\n\t[stop]\tStop Chat Server");
            Console.Write("\nCommand >> ");
            command = Console.ReadLine();
            switch(command)
                {
                    case "start" : startServer();
                    break;
                    case "stop" : stopServer();
                    break;
                    case "exit" : System.Environment.Exit(0);
                    break;
                    default : Console.Out.WriteLine("Invalid command");
                    break;
                }
            }
        }
        static void startServer()
        {
            Console.WriteLine("Starting Server...");   
            try
            {
                serverSocket.Start();
                Console.WriteLine("Server Started.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Server Starting failed.");
            }
        }
        static void stopServer()
        {
            Console.WriteLine("Stopping Server...");
            try{
                serverSocket.Stop();
                clientSocket.Close();
                Console.WriteLine("Server stopped.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Server Stopping failed.");
            }
            
        }
        static void broadcast()
        {

        }

    }
}
