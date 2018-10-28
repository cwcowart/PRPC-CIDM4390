using System;
using SMTPLib;

namespace SMTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SendGrid SMTP = new SendGrid();
            Console.WriteLine("Hello World!");
        }
    }
}
