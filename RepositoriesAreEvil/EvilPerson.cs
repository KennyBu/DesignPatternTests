using System;

namespace RepositoriesAreEvil
{
    public class EvilPerson
    {
        private readonly DateTime _importantDate;
        public BirthPlace BirthPlace { get; set; }

        public EvilPerson(DateTime importantDate)
        {
            _importantDate = importantDate;
        }

        public DateTime BirthDate { get; private set; }

        public void CorrectBirthDate(IRepository<BirthPlace> birthPlaces, DateTime date)
        {
            if (BirthPlace != null && date < _importantDate && BirthPlace.IsSpecial)
            {
                BirthPlace = birthPlaces.GetForDate(date);
            }
        }
    }

    public interface IRepository<T>
    {
        T GetForDate(DateTime date);
    }

    public class BirthPlaceRepository : IRepository<BirthPlace>
    {
        public BirthPlace GetForDate(DateTime date)
        {
            return date < DateTime.Now ? new BirthPlace { IsSpecial = true } : new BirthPlace { IsSpecial = false };
        }
    }

    public class BirthPlace
    {
        public bool IsSpecial { get; set;}
    }


}