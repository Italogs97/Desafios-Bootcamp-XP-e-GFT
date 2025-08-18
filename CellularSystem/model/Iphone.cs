using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CellularSystem.Abstrat;


namespace CellularSystem.Model;

/// Representa um iPhone.
public class Iphone : Cellular
{

     public Iphone(string model, string number, int memory, string imei)
        : base(model, "Apple", number, memory, imei)
    {
    }

    /// Liga o iPhone.
    public override void TurnOn()
    {
        Console.WriteLine($"Turning on the iPhone {Model}");

    }

    /// Desliga o iPhone.
    public override void TurnOff()
    {
        Console.WriteLine($"Turning off the iPhone {Model}");
    }

    /// Faz uma chamada no iPhone.
    public override void MakeCall(string number)
    {
        Console.WriteLine($"iPhone {Model} is calling {number} via FaceTime.");
    }
    /// Envia uma mensagem no iPhone.
    public override void SendMessage(string number, string message)
    {
        Console.WriteLine($"iPhone {Model} is sending a message to {number} via iMessage: {message}");
    }

    /// Tira uma foto no iPhone.
    public override void TakePhoto()
    {
        Console.WriteLine($"iPhone {Model} is taking a photo.");
    }

    /// Instala um aplicativo no iPhone.
    public override void InstallApp(string appName)
    {
        Console.WriteLine($"iPhone {Model} is installing the app: {appName} from the App Store.");
    }
}
