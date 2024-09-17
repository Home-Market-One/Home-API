using Domain.Entity.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.HomeService
{
    public  class  HomeRepair : HomeBase
    {
        [Key]
        public int Id { get; set; }
        public string SizeType { get; set; }
    }
}
