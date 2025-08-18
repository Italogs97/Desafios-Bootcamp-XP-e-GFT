using System.Diagnostics;

namespace CellularSystem.Abstrat
{
    /// Classe abstrata que representa um celular.
    /// abstrata é uma classe que não pode ser instanciada diretamente, mas pode ser herdada por outras classes.
    public abstract class Cellular
    {
        // Propriedades comuns a todos os celulares
        public string Model { get; protected set; }
        public string Brand { get; protected set; }
        public string Number { get; protected set; }
        public int Memory { get; protected set; }
        public string IMEI { get; protected set; }


        /// Construtor da classe Cellular.

        public Cellular(string model, string brand, string number, int memory, string imei)
        {
            Model = model;
            Brand = brand;
            Number = number;
            Memory = memory;
            IMEI = imei;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void MakeCall(string number);
        public abstract void SendMessage(string number, string message);


        /// comportamentos especificos que podem ser implementados por celulares.

        public virtual void TakePhoto()
        {
            Console.WriteLine($"{Brand} {Model} is taking a photo.");
        }

        public virtual void AccessInternet()
        {
            Console.WriteLine($"{Brand} {Model} is accessing the internet.");
        }

        public virtual void PlayMusic()
        {
            Console.WriteLine($"{Brand} {Model} is playing music.");
        }

        public virtual void InstallApp(string appName)
        {
            Console.WriteLine($"{Brand} {Model} is installing the app: {appName}.");
        }
    }
}