using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_DataBase.Entities
{
    public class UserProfile
    {
        [Key, ForeignKey("User")]
        public string Id { get; set; }

        [Required, StringLength(75)]
        public string FirstName { get; set; }

        [Required, StringLength(75)]
        public string LastName { get; set; }

        [Required, StringLength(75)]
        public string Height { get; set; }

        [Required, StringLength(75)]
        public string Weight { get; set; }

        [Required, StringLength(75)]
        public DateTime DateOfBirth { get; set; }

        [Required, ForeignKey("Sex")]
        public int SexId { get; set; }

        public virtual Sex Sex { get; set; }

        public virtual DbUser User { get; set; }
    }
}
