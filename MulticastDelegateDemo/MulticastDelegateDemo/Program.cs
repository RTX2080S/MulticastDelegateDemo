using MulticastDelegateDemo.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDemo
{
    class Program
    {
        delegate void SendMessage();

        static void Main(string[] args)
        {
            BroadCast broadCast = new BroadCast();

            SendMessage sendMessage = broadCast.ViaEmail;
            sendMessage += broadCast.ViaFax;
            sendMessage += broadCast.ViaMessage;

            Console.WriteLine("Enter anything: ");
            var result = Console.ReadLine();
            if (result.Equals("Pass"))
            {
                Console.WriteLine("Trasaction successful!");
            }
            else
            {
                Console.WriteLine("Transaction failed!");
                sendMessage.Invoke();
            }
            Console.ReadLine();
        }
    }
}
