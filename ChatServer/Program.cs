using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ChatServer
{
    class Program
    {
        private IPAddress ip;
        private TcpListener tcpList;
        static void Main(string[] args)
        {
            showCommandConsole();
        }
        static void startServer()
        {
            Console.WriteLine("Starting Server...");                                 
        }
        static void stopServer()
        {
            Console.WriteLine("Stopping Server...");
        }
        static void showCommandConsole()
        {
            string command;
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
                    default : Console.Out.WriteLine("Invalid command");
                    break;
                }
            Console.ReadLine();
        }
        
    }
}
