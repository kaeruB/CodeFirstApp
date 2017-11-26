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
    public partial class FindPostForm : Form
    {
        public FindPostForm()
        {
            InitializeComponent();
        }

        private void PostToFindBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string postTitle = PostToFindBox.Text;
            if (String.IsNullOrEmpty(postTitle) == true)
            {
                MessageBox.Show("Enter a title of the post.");
            }
            else
            {
                using (var bloggingContext = new BloggingContext())
                {

                    //Post post = new Post();
                    Post post = (from posts in bloggingContext.Posts
                                where posts.Title == postTitle
                                select posts).FirstOrDefault<Post>();
                    

                    if (post != null)
                        contentBox.Text = post.Content;                     
                    
                    else
                        MessageBox.Show("No such title of the post.");
                }
            }
        }
        

        private void postsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CodeFirstNewDatabaseSample_BloggingContextDataSet);

        }

        private void FindPostForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli '_CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts' . Możesz go przenieść lub usunąć.
            this.postsTableAdapter.Fill(this._CodeFirstNewDatabaseSample_BloggingContextDataSet.Posts);

        }
/*
        private void postsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 * */

        private void contentBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
