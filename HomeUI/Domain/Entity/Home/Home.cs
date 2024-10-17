﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Home
{
    public class Home : HomeBase
    {

        [Key]
        public int Id { get; set; }
        public string Discription { get; set; }
        public int YearBuilt { get; set; }
        public string HomeType { get; set; }


    }
}
