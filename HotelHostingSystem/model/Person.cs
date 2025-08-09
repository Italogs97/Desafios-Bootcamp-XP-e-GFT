using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelHostingSystem.model
{

    // Classe que representa uma pessoa no sistema de hospedagem
    public class Person
    {
        public string Name { get; set; } // Nome da pessoa 

        public string LastName { get; set; } // Sobrenome da pessoa

        public int Cpf { get; set; } // CPF da pessoa
        public string Email { get; set; } // Email da pessoa
        public string Telephone { get; set; } // Telefone da pessoa


        /// Inicializa uma nova instância da classe Person
        public Person(string firstName, string lastName, int cpf, string email, string telephone)
        {
            Name = firstName;
            LastName = lastName;
            Cpf = cpf;
            Email = email;
            Telephone = telephone;
        }



    }
}