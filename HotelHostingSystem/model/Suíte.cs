using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelHostingSystem.model
{
    public class Suite
    {
        public string Type { get; set; } // Tipo da suíte (e.g., Standard, Deluxe, Premium)
        public int Capacity { get; set; } // Capacidade máxima de hóspedes na suíte
        public decimal ValueDaily { get; set; } // Valor diário da suíte


        public Suite(string type, int capacity, decimal valueDaily)
        {
            Type = type; // Define o tipo da suíte
            Capacity = capacity; // Define a capacidade máxima de hóspedes
            ValueDaily = valueDaily; // Define o valor diário da suíte
        }
    }
}