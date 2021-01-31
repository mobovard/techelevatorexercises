using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.CRM;

namespace PetElevator.Shared
{
    public class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>() { };

        public Customer (string firstName, string lastName, string phoneNumber)
            : base (firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }

        public Customer(string firstName, string lastName)
            : base(firstName, lastName)
        {
            PhoneNumber = "";
        }

    }
}
