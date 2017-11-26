namespace CodeFirstNewDatabaseSample
{
    partial class PostsOfSelectedBlog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label label1;
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSet();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter();
            this.tableAdapterManager = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager();
            this.postsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter();
            this.blogsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridPosts = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(23, 37);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(67, 13);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Blog\'s name:";
            // 
            // _CodeFirstNewDatabaseSample_BloggingContextDataSet
            // 
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet.DataSetName = "_CodeFirstNewDatabaseSample_BloggingContextDataSet";
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // blogsTableAdapter
            // 
            this.blogsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BlogsTableAdapter = this.blogsTableAdapter;
            this.tableAdapterManager.PostsTableAdapter = this.postsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // blogsBindingNavigator
            // 
            this.blogsBindingNavigator.AddNewItem = null;
            this.blogsBindingNavigator.BindingSource = this.blogsBindingSource;
            this.blogsBindingNavigator.CountItem = null;
            this.blogsBindingNavigator.DeleteItem = null;
            this.blogsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.blogsBindingNavigator.MoveFirstItem = null;
            this.blogsBindingNavigator.MoveLastItem = null;
            this.blogsBindingNavigator.MoveNextItem = null;
            this.blogsBindingNavigator.MovePreviousItem = null;
            this.blogsBindingNavigator.Name = "blogsBindingNavigator";
            this.blogsBindingNavigator.PositionItem = null;
            this.blogsBindingNavigator.Size = new System.Drawing.Size(652, 25);
            this.blogsBindingNavigator.TabIndex = 0;
            this.blogsBindingNavigator.Text = "bindingNavigator1";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blogsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(172, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridPosts
            // 
            this.dataGridPosts.AutoGenerateColumns = false;
            this.dataGridPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridPosts.DataSource = this.postsBindingSource;
            this.dataGridPosts.Location = new System.Drawing.Point(26, 124);
            this.dataGridPosts.Name = "dataGridPosts";
            this.dataGridPosts.Size = new System.Drawing.Size(602, 179);
            this.dataGridPosts.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 13);
            label1.TabIndex = 11;
            label1.Text = "First letter of the blog\'s name:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PostId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PostId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn3.HeaderText = "Content";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BlogId";
            this.dataGridViewTextBoxColumn4.HeaderText = "BlogId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // PostsOfSelectedBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 331);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridPosts);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.blogsBindingNavigator);
            this.Name = "PostsOfSelectedBlog";
            this.Text = "PostsOfSelectedBlog";
            this.Load += new System.EventHandler(this.PostsOfSelectedBlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CodeFirstNewDatabaseSample_BloggingContextDataSet _CodeFirstNewDatabaseSample_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter blogsTableAdapter;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator blogsBindingNavigator;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridPosts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}