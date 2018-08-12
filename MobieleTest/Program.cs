using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobieleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Currency Test
            CurrencyRepository currencyRepo = new CurrencyRepository();
            Currency EUR = currencyRepo.GetCurrencyWithName("EUR");



            //Trip Test
            PersonRepository repo = new PersonRepository();
            repo.AddPerson("Pieter");
            repo.AddPerson("Margaux");
            Person Pieter = repo.GetPerson(0);
            Person Margaux = repo.GetPerson(1);

            TripRepository tripRepo = new TripRepository();
            tripRepo.AddTrip("Parijs", EUR);
            Trip Parijs = tripRepo.GetTrip(0);
            Parijs.AddPersonToTrip(Pieter);
            Parijs.AddPersonToTrip(Margaux);

            // "m" == decimal number
            Expense Resto = new Expense(Pieter, Parijs, EUR);
            Resto.AddItem("Pasta", 8.05m, Pieter);
            Resto.AddItem("Pasta", 8.05m, Margaux);
            Resto.AddItem("Wine", 8.05m, Margaux);
            Resto.AddItem("Ice cream", 5.00m, Margaux);
            Parijs.AddExpenseToTrip(Resto);

            Expense Museum = new Expense(Margaux, Parijs, EUR);
            Museum.AddItem("Entry", 12m, Pieter);
            Museum.AddItem("Entry", 12m, Margaux);
            Parijs.AddExpenseToTrip(Museum);

            Pieter.AddTransaction(Margaux, 2);

            var owes = Pieter.GetOwesPersonInCurrency(currencyRepo.GetCurrencyWithName("EUR"));

            Console.WriteLine("");
            
        }
    }
}
