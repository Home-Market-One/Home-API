using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Home
{
    public  class Hotel : HomeBase
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }
        /// <summary>
        ///   Day or month time 
        /// </summary>
        
        [Column("day or month")]
        public string DayMonth { get; set; }         
        /// <summary>       
        ///  Bissnes
        ///  Comfortable
        ///  Cheap
        /// </summary>
        [Column("room type")]
        public string RoomType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summary>
        [Column("user type")]
        public string UserType { get; set; }
        
    }
}
