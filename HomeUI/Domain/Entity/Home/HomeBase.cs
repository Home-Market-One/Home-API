using Domain.Entity.EnumType.Regions.District.Toshkent;
using Domain.Entity.EnumType.Regions.Province;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Home
{
    public  class HomeBase
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("price")]
        [Required]
        public double Price { get; set; }
        [Column("information")]
        public string? Information { get; set; }
        [Column("phone_Number")]
        [Phone]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }
        public DistrictEnum DistrictEnum { get; set; }



    }
}
