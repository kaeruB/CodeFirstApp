using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                BlogForm bForm = new BlogForm();
                bForm.ShowDialog();
                                   
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();


            }
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    //context represents a session with the database, allowing us to query and save data
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        //Fluent Api - ograniczenie dlugosci zawartosci posta
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("DisplayName");      //powrot do wczesniejszego nazwenictwa

          //  modelBuilder.Entity<Post>().Property(t => t.Content).HasMaxLength(100);
        }
    }

    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }
}