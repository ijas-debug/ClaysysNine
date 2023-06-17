using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
     interface IChatSystem
    {
        void SendMessage();
        void ReceiveMessage();
    }
    interface IChatSystem2
    {
        void SendMessage2();
        void ReceiveMessage2();
    }

    class Whatsapp : IChatSystem,IChatSystem2 //we can implement multiple interfaces 
    {
        public void SendMessage() 
        {
            Console.WriteLine("Sending Msg via Whatsapp");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Recieving Msg via Whatsapp");
        }

        public void SendMessage2()
        {
            Console.WriteLine("Sending Msg via Whatsapp2");
        }
        public void ReceiveMessage2()
        {
            Console.WriteLine("Recieving Msg via Whatsapp2");
        }
    }

    class Telegram : IChatSystem
    {
        public void SendMessage()
        {
            Console.WriteLine("Sending Msg via Telegram");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Recieving Msg via Telegram");
        }
    }



}
