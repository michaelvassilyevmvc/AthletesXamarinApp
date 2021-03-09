using AthletesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthletesApp.Services
{
    public class MockAthleteDataStore : IDataStore<Athlete>
    {
        public List<Athlete> Athletes { get; set; }
        public List<KindOfSport> KindOfSports { get; set; }

        public MockAthleteDataStore()
        {

            KindOfSports = new List<KindOfSport>
            {
                new KindOfSport{Id=1,Name="Воллейбол"},
                new KindOfSport{Id=2,Name="Бокс"},
                new KindOfSport{Id=3, Name="Хоккей"},
                new KindOfSport{Id=4,Name="Шахматы"}
            };

            Athletes = new List<Athlete>()
            {
                new Athlete { Id = 1, LName = "Иванов", FName = "Иван", KindOfSportId=1 },
                new Athlete { Id = 2, LName = "Петров", FName = "Петр", KindOfSportId=1},
                new Athlete { Id = 3, LName = "Сидаров", FName = "Егор",KindOfSportId=2 },
                new Athlete { Id = 4, LName = "Егоров", FName = "Алексей",KindOfSportId=2 },
                new Athlete { Id = 5, LName = "Смирнов", FName = "Андрей",KindOfSportId=3 },
                new Athlete { Id = 6, LName = "Васильев", FName = "Владимир",KindOfSportId=3 },
                new Athlete { Id = 7, LName = "Герченов", FName = "Михаил",KindOfSportId=4 },
                new Athlete { Id = 8, LName = "Сухов", FName = "Стас",KindOfSportId=4 },
               
            };
        }

        public async Task<bool> AddItemAsync(Athlete Athlete)
        {
            Athletes.Add(Athlete);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Athlete Athlete)
        {
            var oldAthlete = Athletes.Where((Athlete arg) => arg.Id == Athlete.Id).FirstOrDefault();
            Athletes.Remove(oldAthlete);
            Athletes.Add(Athlete);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldAthlete = Athletes.Where((Athlete arg) => arg.Id == id).FirstOrDefault();
            Athletes.Remove(oldAthlete);

            return await Task.FromResult(true);
        }

        public async Task<Athlete> GetItemAsync(int id)
        {
            return await Task.FromResult(Athletes.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Athlete>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(this.Athletes);
        }
    }
}