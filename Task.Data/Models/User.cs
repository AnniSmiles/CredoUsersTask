using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FName { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string LName { get; set; }
        [Range(18,130)]
        public int Age { get; set; }
        public UserStatus Status { get; set; }
        [Required]
        [RegularExpression(@"^(\d{11})$", ErrorMessage = "Wrong Id")]
        //[Index("PersonalIDAndPhoneNumber",1, IsUnique = true)]
        public string PersonalID { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        //[Index("PersonalIDAndPhoneNumber", 2, IsUnique = true)]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "Wrong mobile")]
        
        public string PhoneNumber { get; set; }
    }
}
