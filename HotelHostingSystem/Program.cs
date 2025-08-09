using System;
using System.Collections.Generic;
using HotelHostingSystem.model;


namespace HotelHostingSystem
{
    
    // Classe Program que contém o método Main para iniciar a aplicação
    // A classe é responsável por criar hóspedes, suítes e reservas
    class Program
    {
        // Método principal que inicia a aplicação  
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hotel Hosting System!");

            //Criando hospedes
            // instanciando objetos da classe  person para representar hóspedes
            Person p1 = new Person("John", "Doe", 123456789, "john.doe@example.com", "11 98451-4587");
            Person p2 = new Person("Jane", "Smith", 987654321, "jane.smith@example.com", "11 98765-4321");
            Person p3 = new Person("Alice", "Johnson", 112233445, "alice.johnson@example.com", "11 12345-6789");
            Person p4 = new Person("Bob", "Brown", 556677889, "bob.brown@example.com", "11 55678-9012");
            Person p5 = new Person("Charlie", "Davis", 998877665, "charlie.davis@example.com", "11 99876-5432");
            Person p6 = new Person("Diana", "Evans", 554433221, "diana.evans@example.com", "11 55432-1098");
            Person p7 = new Person("Ethan", "Garcia", 667788990, "ethan.garcia@example.com", "11 66788-9900");
            Person p8 = new Person("Fiona", "Martinez", 223344556, "fiona.martinez@example.com", "11 22334-4556");
            Person p9 = new Person("George", "Lopez", 334455667, "george.lopez@example.com", "11 33445-5667");
            Person p10 = new Person("Hannah", "Wilson", 445566778, "hannah.wilson@example.com", "11 44556-7788");


            // Criando lista de hóspedes
            List<Person> guests1 = new List<Person>() { p1, p2 }; // Lista de hóspedes para a reserva 1
            List<Person> guests2 = new List<Person>() { p1, p3, p4 }; // Lista de hóspedes para a reserva 2
            List<Person> guests3 = new List<Person>() { p5, p6, p7, p8, p9, p10 }; // Lista de hóspedes para a reserva 3

            // Criando suítes
            // instanciando objetos da classe Suite para representar suítes disponíveis
            Suite simpleSuite = new Suite("Simples", 2, 100.00m); // Suíte simples com capacidade para 2 pessoas e valor diário de R$100,00
            Suite deluxeSuite = new Suite("Deluxe", 3, 200.00m); // Suíte deluxe com capacidade para 3 pessoas e valor diário de R$200,00
            Suite presidentialSuite = new Suite("Presidencial", 4, 500.00m); // Suíte presidencial com capacidade para 4 pessoas e valor diário de R$500,00


            // -- Criando reservas: Reserva de 5 dias na suíte simples sem desconto
            Console.WriteLine("\nCreating reservation 1 for 5 days in a simple suite without discount:");
            Reservation reservation1 = new Reservation(5); // Cria uma nova reserva para 5 dias
            reservation1.RegisterSuite(simpleSuite); // Registra a suíte simples na reserva


            // Tentando registrar hóspedes na reserva
            // Se a quantidade de hóspedes exceder a capacidade da suíte, uma exceção será lançada
            // O bloco try-catch é usado para capturar e tratar essa exceção
            try
            {
                reservation1.RegisterGuests(guests3); // tenta registrar os hóspedes na reserva
                Console.WriteLine($"Suite :{reservation1.Suite.Type}"); // Exibe o tipo da suíte reservada
                Console.WriteLine($"Total guests: {reservation1.GetGuestCount()}"); // Exibe a quantidade de hóspedes na reserva
                Console.WriteLine($"Daily rate: {reservation1.Suite.ValueDaily:C}"); // Exibe o valor diário da suíte formatado como moeda
                Console.WriteLine($"Total value: {reservation1.CalculateTotalValue():C}"); // Exibe o valor total da reserva formatado como moeda


            }
            // Se ocorrer uma exceção ao registrar os hóspedes, exibe uma mensagem de erro
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering guests: {ex.Message}"); // Exibe mensagem de erro caso ocorra uma exceção
            }


            // -- Criando reservas: Reserva de 15 dias na suíte simples sem desconto
            Console.WriteLine("\nCreating reservation 2 for 15 days in a simple suite without discount:");
            Reservation reservation2 = new Reservation(15); // Cria uma nova reserva para 15 dias
            reservation2.RegisterSuite(deluxeSuite); // Registra a suíte deluxe na reserva

            try
            {
                reservation2.RegisterGuests(guests2); // tenta registrar os hóspedes na reserva
                Console.WriteLine($"Suite :{reservation2.Suite.Type}"); // Exibe o tipo da suíte reservada
                Console.WriteLine($"Total guests: {reservation2.GetGuestCount()}"); // Exibe a quantidade de hóspedes na reserva
                Console.WriteLine($"Daily rate: {reservation2.Suite.ValueDaily:C}"); // Exibe o valor diário da suíte formatado como moeda
                Console.WriteLine($"Total value: {reservation2.CalculateTotalValue():C}"); // Exibe o valor total da reserva formatado como moeda


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering guests: {ex.Message}"); // Exibe mensagem de erro caso ocorra uma exceção
            }


            // -- Criando reservas: com excedendo a capacidade da suíte
            Console.WriteLine("\nCreating reservation 3 for 7 days in a presidential suite without discount:");
            Reservation reservation3 = new Reservation(7); // Cria uma nova reserva para 7 dias
            reservation3.RegisterSuite(presidentialSuite); // Registra a suíte presidencial na reserva

            try
            {
                reservation3.RegisterGuests(guests1); // tenta registrar os hóspedes na reserva
                Console.WriteLine($"Suite :{reservation3.Suite.Type}"); // Exibe o tipo da suíte reservada
                Console.WriteLine($"Total guests: {reservation3.GetGuestCount()}"); // Exibe a quantidade de hóspedes na reserva
                Console.WriteLine($"Daily rate: {reservation3.Suite.ValueDaily:C}"); // Exibe o valor diário da suíte formatado como moeda
                Console.WriteLine($"Total value: {reservation3.CalculateTotalValue():C}"); // Exibe o valor total da reserva formatado como moeda


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering guests: {ex.Message}"); // Exibe mensagem de erro caso ocorra uma exceção
            }
        }
    }
}
