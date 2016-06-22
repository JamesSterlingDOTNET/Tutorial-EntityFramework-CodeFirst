using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_EntityFrameworkDb.Models;

namespace Tutorial_EntityFrameworkDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Card card = new Card();
            Customer customer = new Customer();

            bank.Id = Guid.NewGuid();
            bank.Name = "Bank of America";
            bank.City = "Washington D.C.";

            card.Id = Guid.NewGuid();
            card.Pin = 1234;
            card.BankId = bank.Id;
            card.Bank = bank;

            customer.Name = "Phill Donkey";
            customer.Card = card;
            customer.Id = card.Id;

            card.Customer = customer;

            BankContext context = new BankContext();
            context.Bank.Add(bank);
            context.Card.Add(card);
            context.Customer.Add(customer);

            context.SaveChanges();
        }
    }
}
