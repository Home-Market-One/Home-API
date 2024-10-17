using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Home
{
    public  class HomeRent : HomeBase
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("homeowner")]
        /// <summary>
        ///  With a host or without a host 
        /// </summary>
        public bool HomeOwner { get; set; }
        [Column("day or month")]
        public string DayMonth { get; set; }
        /// <summary>
        ///  Day or month type 
        /// </summary>
        [Column("price")]
        [Required]
        public string UserType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summar
    }
}
