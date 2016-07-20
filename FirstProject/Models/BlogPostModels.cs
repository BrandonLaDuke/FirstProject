using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace FirstProject.Models
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<BlogPostDTO> BlogPostDTOs { get; set; }
    }

    [Table("BlogPosts")]
    public class BlogPostDTO
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int NoteId { get; set; }
        public string BlogPost { get; set; }
        public int UserId { get; set; }
        public string DatePosted { get; set; }
    }

}
