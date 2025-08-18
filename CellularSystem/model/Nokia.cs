using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CellularSystem.Abstrat;


namespace CellularSystem.Model
    
{
    public class Nokia : Cellular
    {
        public Nokia(string model, string number, int memory, string imei)
            : base(model, "Nokia", number, memory, imei)
        {
        }

        /// Liga o Nokia.
        public override void TurnOn()
        {
            Console.WriteLine($"Turning on the Nokia {Model}");
        }

        /// Desliga o Nokia.
        public override void TurnOff()
        {
            Console.WriteLine($"Turning off the Nokia {Model}");
        }

        /// Faz uma chamada no Nokia.
        public override void MakeCall(string number)
        {
            Console.WriteLine($"Nokia {Model} is calling {number} via WhatsApp.");
        }

        /// Envia uma mensagem no Nokia.
        public override void SendMessage(string number, string message)
        {
            Console.WriteLine($"Nokia {Model} is sending a message to {number} via Nokia Messaging: {message}");
        }

        /// Tira uma foto no Nokia.
        public override void TakePhoto()
        {
            Console.WriteLine($"Nokia {Model} is taking a photo.");
        }

        /// Instala um aplicativo no Nokia.
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Nokia {Model} is installing the app: {appName} from the Nokia Store.");
        }
    }
}