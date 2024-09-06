using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Home
{
    public class Home : HomeBase
    {

        public string Area { get; set; }
        public int RoomNumber { get; set; }
        public string? PathImage { get; set; }
        public string? YearOfConstruction { get; set; }
       

    }
}
