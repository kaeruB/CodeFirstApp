using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstNewDatabaseSample
{
    public partial class PostsOfSelectedBlog : Form
    {
        public PostsOfSelectedBlog()
        {
            InitializeComponent();
        }

        private void blogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.blogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CodeFirstNewDatabaseSample_BloggingContextDataSet);

        }

        private void PostsOfSelectedBlog_Load(object sender, EventArgs e)
        {
            /*
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
            this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
            this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs' . Możesz go przenieść lub usunąć.
            this.blogsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs);

            */

           
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string blogName = nameTextBox.Text;
            int findBlogId;
            if (blogName == "")
            {
                MessageBox.Show("Please write a name of the blog.");
            }
            else
            {
                using (var bloggingContext = new BloggingContext())
                {
                    //Wykorzystanie method syntax i Eager loading - metoda Include
                    findBlogId = (bloggingContext.Blogs
                        .Include("Posts")
                        .Where(b => b.Name == blogName)
                        .FirstOrDefault<Blog>()).BlogId;

                    //brak takiego blogu
                    if (findBlogId == 0)
                    {
                        MessageBox.Show("There is no such blog.");
                    }
                    else //jesli jest to wyswietlamy posty
                    {
                        List<Post> postList = new List<Post>();

                        postList = (from blogs in bloggingContext.Blogs
                                    where blogs.BlogId == findBlogId
                                    select blogs.Posts).
                                      FirstOrDefault();

                        dataGridPosts.DataSource = postList;
                        dataGridPosts.Update();
                    }
                }
            }
        }
      
        private void dataGridPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string letter = textBox1.Text;
    
            //navigation property - wyciągnięcie z blogów list postów
            using (var bloggingContext = new BloggingContext())
            {
           
                IQueryable<Blog> desiredBlogs = bloggingContext.Blogs
                                                .Where(b => b.Name.StartsWith(letter));                                       
                                            
                    
                if (desiredBlogs == null)
                {
                    MessageBox.Show("There are no such blogs that start on the letter you typed.");
                }
                else
                {
                    List<Post> postList = new List<Post>();
                    List<Post> tmp;
                    foreach (Blog b in desiredBlogs)
                    {
                        tmp = postList.Union(b.Posts).ToList();
                        postList = tmp;
                    }
                    dataGridPosts.DataSource = postList;
                    dataGridPosts.Update();
                }
            }
        }
    }
}
