namespace CodeFirstNewDatabaseSample
{
    partial class BlogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogForm));
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSet();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter();
            this.tableAdapterManager = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager();
            this.postsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter();
            this.usersTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.UsersTableAdapter();
            this.blogsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.blogsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.blogsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayPosts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.refbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingNavigator)).BeginInit();
            this.blogsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // blogsBindingNavigator
            // 
            this.blogsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.blogsBindingNavigator.BindingSource = this.blogsBindingSource;
            this.blogsBindingNavigator.CountItem = null;
            this.blogsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.blogsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.blogsBindingNavigatorSaveItem});
            this.blogsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.blogsBindingNavigator.MoveFirstItem = null;
            this.blogsBindingNavigator.MoveLastItem = null;
            this.blogsBindingNavigator.MoveNextItem = null;
            this.blogsBindingNavigator.MovePreviousItem = null;
            this.blogsBindingNavigator.Name = "blogsBindingNavigator";
            this.blogsBindingNavigator.PositionItem = null;
            this.blogsBindingNavigator.Size = new System.Drawing.Size(660, 25);
            this.blogsBindingNavigator.TabIndex = 0;
            this.blogsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewPost_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // blogsBindingNavigatorSaveItem
            // 
            this.blogsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blogsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("blogsBindingNavigatorSaveItem.Image")));
            this.blogsBindingNavigatorSaveItem.Name = "blogsBindingNavigatorSaveItem";
            this.blogsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.blogsBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.blogsBindingNavigatorSaveItem.Click += new System.EventHandler(this.blogsBindingNavigatorSaveItem_Click);
            // 
            // blogsDataGridView
            // 
            this.blogsDataGridView.AutoGenerateColumns = false;
            this.blogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.blogsDataGridView.DataSource = this.blogsBindingSource;
            this.blogsDataGridView.Location = new System.Drawing.Point(268, 55);
            this.blogsDataGridView.Name = "blogsDataGridView";
            this.blogsDataGridView.Size = new System.Drawing.Size(245, 248);
            this.blogsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BlogId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BlogId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Url";
            this.dataGridViewTextBoxColumn3.HeaderText = "Url";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.AutoGenerateColumns = false;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.postsDataGridView.DataSource = this.postsBindingSource;
            this.postsDataGridView.Location = new System.Drawing.Point(12, 55);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.Size = new System.Drawing.Size(247, 248);
            this.postsDataGridView.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PostId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PostId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn6.HeaderText = "Content";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BlogId";
            this.dataGridViewTextBoxColumn7.HeaderText = "BlogId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // DisplayPosts
            // 
            this.DisplayPosts.Location = new System.Drawing.Point(528, 55);
            this.DisplayPosts.Name = "DisplayPosts";
            this.DisplayPosts.Size = new System.Drawing.Size(125, 28);
            this.DisplayPosts.TabIndex = 4;
            this.DisplayPosts.Text = "Display posts";
            this.DisplayPosts.UseVisualStyleBackColor = true;
            this.DisplayPosts.Click += new System.EventHandler(this.DisplayPosts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find a post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refbutton
            // 
            this.refbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refbutton.Location = new System.Drawing.Point(528, 121);
            this.refbutton.Name = "refbutton";
            this.refbutton.Size = new System.Drawing.Size(125, 26);
            this.refbutton.TabIndex = 6;
            this.refbutton.Text = "Refresh";
            this.refbutton.UseVisualStyleBackColor = true;
            this.refbutton.Click += new System.EventHandler(this.refbutton_Click);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 310);
            this.Controls.Add(this.refbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayPosts);
            this.Controls.Add(this.postsDataGridView);
            this.Controls.Add(this.blogsDataGridView);
            this.Controls.Add(this.blogsBindingNavigator);
            this.Name = "BlogForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingNavigator)).EndInit();
            this.blogsBindingNavigator.ResumeLayout(false);
            this.blogsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blogsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CodeFirstNewDatabaseSample_BloggingContextDataSet _CodeFirstNewDatabaseSample_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter blogsTableAdapter;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator blogsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton blogsBindingNavigatorSaveItem;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridView blogsDataGridView;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button DisplayPosts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refbutton;
    }
}