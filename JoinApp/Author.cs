using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinApp
{
    [Table("Authors")]
   public class Author
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("fullName")]
        public string Fullname { get; set; }
        [Column("mainInfo")]
        public string MainInfo { get; set; }
    }
}
