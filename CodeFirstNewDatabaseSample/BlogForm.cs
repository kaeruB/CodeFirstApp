using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    public partial class BlogForm : Form
    {
        BloggingContext bContext;
        public BlogForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Users);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
            this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs' . Możesz go przenieść lub usunąć.
            this.blogsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs);

            bContext = new BloggingContext();
            bContext.Blogs.Load();
            blogsBindingSource.DataSource = bContext.Blogs.Local.ToBindingList();

            bContext.Posts.Load();
            postsBindingSource.DataSource = bContext.Posts.Local.ToBindingList();
        }

        private void blogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.blogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CodeFirstNewDatabaseSample_BloggingContextDataSet);

            this.bContext.SaveChanges();
            this.blogsDataGridView.Refresh();
            this.postsDataGridView.Refresh();
          //  this.usersDataGridView.Refresh();
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.bContext.Dispose();
        }

        //dodawanie nowego postu - wywolanie nowego okienka
        private void bindingNavigatorAddNewPost_Click(object sender, EventArgs e)
        {
            PostForm post_form = new PostForm();
            post_form.ShowDialog();
         }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
 
        }

        private void addPostButton_Click(object sender, EventArgs e)
        {
            


        }

        private void DisplayPosts_Click(object sender, EventArgs e)
        {
            PostsOfSelectedBlog _form = new PostsOfSelectedBlog();
            _form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindPostForm _form = new FindPostForm();
            _form.ShowDialog();
        }

        private void refbutton_Click(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Users);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
            this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs' . Możesz go przenieść lub usunąć.
            this.blogsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Blogs);

            bContext = new BloggingContext();
            bContext.Blogs.Load();
            blogsBindingSource.DataSource = bContext.Blogs.Local.ToBindingList();

            bContext.Posts.Load();
            postsBindingSource.DataSource = bContext.Posts.Local.ToBindingList();
        }
    }
}
