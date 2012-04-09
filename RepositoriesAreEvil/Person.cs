using System;

namespace RepositoriesAreEvil
{
    public class Person
    {
        private readonly DateTime _importantDate;
        public BirthPlace BirthPlace { get; set; }

        public Person(DateTime importantDate)
        {
            _importantDate = importantDate;
        }

        public DateTime BirthDate { get; private set; }

        public void CorrectBirthDate(Func<DateTime, BirthPlace> getBirthPlaceFordate, DateTime date)
        {
            if (BirthPlace != null && date < _importantDate && BirthPlace.IsSpecial)
            {
                BirthPlace = getBirthPlaceFordate(date);
            }
        }
    }


    
}

