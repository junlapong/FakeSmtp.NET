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

            do
            {
                Console.WriteLine("New MailListener started");
                listener = new MailListener(this, IPAddress.Loopback, 25);
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
