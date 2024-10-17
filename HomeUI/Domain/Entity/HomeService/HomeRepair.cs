using Domain.Entity.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.HomeService
{
    public  class  HomeRepair : HomeBase
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        public string SizeType { get; set; }
    }
}
