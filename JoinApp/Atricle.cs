using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinApp
{
    [Table("Articles")]
    public class Article
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("theme")]
        public string Theme { get; set; }
        [Column("text")]
        public string Text { get; set; }
        [Column("authorInfo")]
        public string AuthorInfo { get; set; }
        [Column("publishedDate")]
        public DateTime PublishedDate { get; set; }

    }
}
