using System;

namespace InterfaceEx { 

class MainClass
    {
        public static void Main(string[] args) 
        {
            Whatsapp wc = new Whatsapp();
            wc.SendMessage();
            wc.ReceiveMessage();
            wc.ReceiveMessage2();

            Telegram tl=new Telegram();
            tl.SendMessage();
            tl.ReceiveMessage();
        }
    }
}

