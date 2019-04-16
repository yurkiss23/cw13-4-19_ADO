using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entites
{
    [Table("CRUD_Users")]
    public class User
    {
        [Key]
        public int Id{ get; set; }
        [Required, StringLength(maximumLength:75)]
        public string FirstName { get; set; }
        [Required, StringLength(maximumLength: 75)]
        public string LastName { get; set; }
        [Required, StringLength(maximumLength: 75)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 75)]
        public string Password { get; set; }
    }
}
