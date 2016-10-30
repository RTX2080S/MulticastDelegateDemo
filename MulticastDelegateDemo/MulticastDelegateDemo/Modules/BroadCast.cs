using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDemo.Modules
{
    class BroadCast
    {
        public void ViaMessage()
        {
            Console.WriteLine("Message sent to mobile.");
        }

        public void ViaEmail()
        {
            Console.WriteLine("Email sent to mailbox.");
        }

        public void ViaFax()
        {
            Console.WriteLine("Message sent via fax.");
        }
    }
}
