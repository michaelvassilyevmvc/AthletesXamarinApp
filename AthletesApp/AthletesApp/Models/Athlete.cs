using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthletesApp.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int KindOfSportId { get; set; }
        public KindOfSport KindOfSport { get; set; }

    }
}
