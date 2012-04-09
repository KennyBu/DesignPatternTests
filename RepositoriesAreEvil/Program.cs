using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoriesAreEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new EvilPerson(new DateTime(1980, 01, 01)) {BirthPlace = new BirthPlace {IsSpecial = true}};

            person.CorrectBirthDate(new BirthPlaceRepository(), new DateTime(1973,12,01));


            var message = person.BirthPlace.IsSpecial
                              ? "This evil peron's birth place is special"
                              : "This evil peron's birth place is not special";

            Console.WriteLine(message);


            var newperson = new Person(new DateTime(1980, 01, 01)) { BirthPlace = new BirthPlace { IsSpecial = true } };

            var repo = new BirthPlaceRepository();

            //newperson.CorrectBirthDate(repo.GetForDate(new DateTime(1973, 12, 01)), new DateTime(1973, 12, 01));


            Console.ReadLine();

        }
    }
}
