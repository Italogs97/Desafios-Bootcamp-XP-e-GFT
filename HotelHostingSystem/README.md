
# Hotel Hosting System  🛎️🧳🏨

Este projeto é um sistema de gerenciamento de reservas de hotel desenvolvido em C#. Ele permite a criação de hóspedes, suítes e reservas, com validações para garantir que o número de hóspedes não exceda a capacidade da suíte e que descontos sejam aplicados para reservas de longa duração.

## Estrutura do Projeto

O projeto é composto por quatro classes principais:

- **Program.cs**: Contém o ponto de entrada da aplicação (método `Main`) e demonstra o uso das demais classes para criar e gerenciar reservas.
- **model/Person.cs**: Representa um hóspede com informações como nome, sobrenome, CPF, e-mail e telefone.
- **model/Suite.cs**: Representa uma suíte do hotel, com tipo, capacidade e valor da diária.
- **model/Reservation.cs**: Gerencia as reservas, incluindo a lista de hóspedes, a suíte reservada, a duração da reserva e o cálculo do valor total com descontos.

## Detalhamento das Classes

### Person.cs

Define as propriedades de um hóspede:
- **Name** (string): Nome do hóspede.
- **LastName** (string): Sobrenome do hóspede.
- **Cpf** (int): CPF do hóspede.
- **Email** (string): E-mail do hóspede.
- **Telephone** (string): Telefone do hóspede.

O construtor da classe inicializa todas essas propriedades.

### Suite.cs

Define as características de uma suíte:
- **Type** (string): Tipo da suíte (ex: "Simples", "Deluxe", "Presidencial").
- **Capacity** (int): Capacidade máxima de hóspedes.
- **ValueDaily** (decimal): Valor da diária.

O construtor inicializa o tipo, capacidade e valor da diária da suíte.

### Reservation.cs

Responsável por gerenciar as reservas e conter a lógica principal:
- **Guests** (`List<Person>`): Lista de hóspedes da reserva.
- **Suite** (`Suite`): Suíte reservada.
- **ReservationDays** (int): Quantidade de dias da reserva.

**Principais métodos:**
- `Reservation(int reservationDays)`: Construtor que inicializa uma nova reserva.
- `RegisterGuests(List<Person> guests)`: Registra a lista de hóspedes, validando se excede a capacidade da suíte (lança exceção se exceder).
- `RegisterSuite(Suite suite)`: Associa uma suíte à reserva.
- `GetGuestCount()`: Retorna o número total de hóspedes.
- `CalculateTotalValue()`: Calcula o valor total da reserva, aplicando 10% de desconto para reservas de 10 dias ou mais.

### Program.cs

Classe principal que demonstra o uso das classes acima para simular o processo de reserva de hotel. O método `Main` realiza as seguintes operações:

1. **Criação de hóspedes:** Instancia vários objetos `Person` com dados fictícios.
2. **Criação de listas de hóspedes:** Agrupa hóspedes em listas para diferentes cenários de reserva.
3. **Criação de suítes:** Instancia diferentes tipos de suítes com suas capacidades e valores.
4. **Criação de reservas:** Demonstra a criação de várias reservas, incluindo:
   - Reserva de 5 dias em suíte simples.
   - Reserva de 15 dias em suíte deluxe (com desconto).
   - Reserva de 7 dias em suíte presidencial, com cenário de excesso de hóspedes para demonstrar o tratamento de exceções.

Cada tentativa de reserva utiliza um bloco try-catch para tratar a exceção `"Número de hóspedes excede a capacidade da suíte."` caso a validação falhe. O programa exibe informações detalhadas sobre cada reserva, como tipo da suíte, número de hóspedes, valor da diária e valor total.

-----------------------------------------------------------------------

Versão inglês

# Hotel Hosting System 🛎️🧳🏨

This project is a hotel reservation management system developed in C#. It allows the creation of guests, suites, and reservations, with validations to ensure that the number of guests does not exceed the suite's capacity and that discounts are applied for long-term bookings.

## Project Structure

The project consists of four main classes:

- **Program.cs**: Contains the application's entry point (`Main` method) and demonstrates how to use the other classes to create and manage reservations.
- **model/Person.cs**: Represents a guest with information such as first name, last name, CPF (Brazilian taxpayer ID), email, and phone number.
- **model/Suite.cs**: Represents a hotel suite, including its type, capacity, and daily rate.
- **model/Reservation.cs**: Manages reservations, including the guest list, reserved suite, reservation duration, and calculation of the total value with discounts.

## Class Details

### Person.cs

Defines the properties of a guest:
- **Name** (string): Guest's first name.
- **LastName** (string): Guest's last name.
- **Cpf** (int): Guest's CPF (Brazilian taxpayer ID).
- **Email** (string): Guest's email address.
- **Telephone** (string): Guest's phone number.

The constructor initializes all these properties.

### Suite.cs

Defines the characteristics of a hotel suite:
- **Type** (string): Suite type (e.g., "Simple", "Deluxe", "Presidential").
- **Capacity** (int): Maximum number of guests allowed.
- **ValueDaily** (decimal): Daily rate for the suite.

The constructor initializes the suite's type, capacity, and daily rate.

### Reservation.cs

Responsible for managing reservations and containing the main business logic:
- **Guests** (`List<Person>`): List of guests for the reservation.
- **Suite** (`Suite`): The reserved suite.
- **ReservationDays** (int): Number of days for the reservation.

**Main methods:**
- `Reservation(int reservationDays)`: Constructor that initializes a new reservation.
- `RegisterGuests(List<Person> guests)`: Registers a list of guests for the reservation. Validates if the number of guests exceeds the suite's capacity (throws an exception if it does).
- `RegisterSuite(Suite suite)`: Associates a suite with the reservation.
- `GetGuestCount()`: Returns the total number of guests.
- `CalculateTotalValue()`: Calculates the total reservation value. If the reservation is for 10 days or more, a 10% discount is applied.

### Program.cs

This is the main class that demonstrates how to use the `Person`, `Suite`, and `Reservation` classes to simulate the hotel reservation process. The `Main` method performs the following operations:

1. **Guest Creation:** Instantiates several `Person` objects with sample data.
2. **Guest List Creation:** Groups guests into lists for different reservation scenarios.
3. **Suite Creation:** Instantiates different types of suites ("Simple", "Deluxe", "Presidential") with their respective capacities and daily rates.
4. **Reservation Creation:** Demonstrates the creation of several reservations, including:
   - A 5-day reservation in a simple suite.
   - A 15-day reservation in a deluxe suite (demonstrating the discount).
   - A 7-day reservation in a presidential suite, with a scenario where the number of guests exceeds the suite's capacity to demonstrate exception handling.

Each reservation attempt uses a try-catch block to handle the exception "Number of guests exceeds suite capacity" if validation fails. The program displays detailed information about each reservation, such as suite type, number of guests, daily rate, and total value.

---
