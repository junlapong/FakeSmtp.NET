using System;
using System.Net;
using System.Threading;

namespace FakeSmtp
{
    public class SMTPServer
    {
        [STAThread] 
        static void Main(string[] args)
        {
            SMTPServer server = new SMTPServer();
            server.RunServer();
        }

        public void RunServer()
        {
            MailListener listener = null;
            int port = 25;

            do
            {
                Console.WriteLine("New MailListener started on port {0}.", port);
                listener = new MailListener(this, IPAddress.Loopback, port);
                listener.OutputToFile = true;
                listener.Start();
                while (listener.IsThreadAlive)
                {
                    Thread.Sleep(500);
                }
            } while (listener != null);

        }
    }
}
