using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace HotelHostingSystem.model
{

    // Classe que representa uma reserva no sistema de hospedagem
    public class Reservation

    {
        public List<Person> Guests { get; set; } // Lista de hóspedes na reserva
        public Suite Suite { get; set; } // Tipo de suíte reservada

        public int ReservationDays { get; set; } // Duração da reserva em dias


        /// Inicializa uma nova instância da classe Reservation
        public Reservation(int reservationDays)
        {
            ReservationDays = reservationDays; // Define a duração da reserva
            Guests = new List<Person>(); // Inicializa a lista de hóspedes vazia
        }



        /// cadastrando o número de hospedes na reserva, verificando se a quantidade não excede a capacidade da suíte
        public void RegisterGuests(List<Person> guests)
        {
            /// Verificando se a quantidade de hospedes 'menor ou igual' a capacidade da suíte
            if (guests.Count <= Suite.Capacity)
            {
                Guests = guests; // Atribui a lista de hóspedes à reserva
            }
            else
            {

                // Lançando uma exceção caso a quantidade de hóspedes exceda a capacidade da suíte
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
        }


        // Cadastra a suíte para a reserva
        public void RegisterSuite(Suite suite)
        {
            Suite = suite; // Atribui a suíte à reserva
        }


        // obter quantidade de hospedes na reserva
        public int GetGuestCount()
        {
            return Guests.Count; // Retorna a quantidade de hóspedes na reserva
        }

        // Calcula o valor total da reserva, aplicando desconto se a duração for igual ou superior a 10 dias
        public decimal CalculateTotalValue() // Calcula o valor total da reserva
        {
            decimal dailyRate = Suite.ValueDaily; // Obtém o valor diário da suíte
            decimal totalValue = dailyRate * ReservationDays; // Calcula o valor total sem desconto

            // Aplica desconto de 10% se a reserva for de 10 dias ou mais
            if (ReservationDays >= 10)
            {
                totalValue *= 0.9m; // Aplica 10% de desconto
            }

            return totalValue;
        }

    }
}