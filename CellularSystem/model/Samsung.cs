using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CellularSystem.Abstrat;



namespace CellularSystem.Model
{
    /// Representa um Samsung.
    public class Samsung : Cellular
    {

        /// Cria um novo Samsung.
        public Samsung(string model, string number, int memory, string imei)
            : base(model, "Samsung", number, memory, imei)
        {
        }

        /// Liga o Samsung.
        public override void TurnOn()
        {
            Console.WriteLine($"Turning on the Samsung {Model}");
        }
        /// Desliga o Samsung.
        public override void TurnOff()
        {
            Console.WriteLine($"Turning off the Samsung {Model}");
        }

        /// Faz uma chamada no Samsung.
        public override void MakeCall(string number)
        {
            Console.WriteLine($"Samsung {Model} is calling {number} via FaceTime.");
        }

        /// Envia uma mensagem no Samsung.
        public override void SendMessage(string number, string message)
        {
            Console.WriteLine($"Samsung {Model} is sending a message to {number} via Samsung Messages: {message}");
        }

        /// Tira uma foto no Samsung.
        public override void TakePhoto()
        {
            Console.WriteLine($"Samsung {Model} is taking a photo.");
        }

        /// Instala um aplicativo no Samsung.
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Samsung {Model} is installing the app: {appName} from the Galaxy Store.");
        }
    }
}
