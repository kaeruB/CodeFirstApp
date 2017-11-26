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
    public partial class PostForm : Form
    {
       // BloggingContext bContext;
        public PostForm()
        {
            InitializeComponent();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs' . Możesz go przenieść lub usunąć.
           // this.blogsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
           // this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);



        }

        private void postsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string blogName = nameTextBox.Text;
            string postTitle = titleTextBox.Text;
            string content = contentTextBox.Text;
            int findBlogId;

            if(blogName == "")
            {
                MessageBox.Show("Enter the name of the blog where you would like to put a post.");
            }
            if (postTitle == "")
            {
                MessageBox.Show("Enter a title of a new post.");
            }
            if (content == "")
            {
                MessageBox.Show("Please write something as a content of the post.");
            }

            //sprawdzanie, czy taki blog istnieje z wykożystaniem query syntax
            //dodatkowo otrzymujemy id bloga, do ktorego chcemy dodac post
            //deffered execution, wykonanie zapytania dopiero przy "if ==..."
            using (var bloggingContext = new BloggingContext())
            {
                if (blogName == null)
                {
                    MessageBox.Show("Enter a name of the blog."); 
                }
                else 
                {
                    findBlogId = (from b in bloggingContext.Blogs
                                  where b.Name == blogName
                                  select b.BlogId).FirstOrDefault();

                    if (findBlogId == 0)
                    {
                        MessageBox.Show("There is no such blog.");                 
                    }
                    else
                    {
                        var postToAdd = new Post();
                        postToAdd.Title = postTitle;
                        postToAdd.BlogId = findBlogId;
                        postToAdd.Content = content;
                        bloggingContext.Posts.Add(postToAdd);
                        bloggingContext.SaveChanges();
                        MessageBox.Show("Dodano post.");
                    }
                }
            }         
            
            this.Validate();
            this.postsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CodeFirstNewDatabaseSample_BloggingContextDataSet);

        }

        private void BlogNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void contentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
