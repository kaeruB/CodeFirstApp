namespace CodeFirstNewDatabaseSample
{
    partial class PostForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label contentLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostForm));
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSet();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter();
            this.tableAdapterManager = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager();
            this.blogsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            titleLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).BeginInit();
            this.postsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(262, 67);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(18, 122);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(47, 13);
            contentLabel.TabIndex = 3;
            contentLabel.Text = "Content:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Blog name:";
            nameLabel.Click += new System.EventHandler(this.BlogNameLabel_Click);
            // 
            // _CodeFirstNewDatabaseSample_BloggingContextDataSet
            // 
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet.DataSetName = "_CodeFirstNewDatabaseSample_BloggingContextDataSet";
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
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
            // blogsTableAdapter
            // 
            this.blogsTableAdapter.ClearBeforeFill = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(307, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(149, 20);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // contentTextBox
            // 
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(83, 115);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(373, 20);
            this.contentTextBox.TabIndex = 4;
            this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this._CodeFirstNewDatabaseSample_BloggingContextDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.blogsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(83, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // postsBindingNavigatorSaveItem
            // 
            this.postsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postsBindingNavigatorSaveItem.Image")));
            this.postsBindingNavigatorSaveItem.Name = "postsBindingNavigatorSaveItem";
            this.postsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.postsBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.postsBindingNavigatorSaveItem.Click += new System.EventHandler(this.postsBindingNavigatorSaveItem_Click);
            // 
            // postsBindingNavigator
            // 
            this.postsBindingNavigator.AddNewItem = null;
            this.postsBindingNavigator.BindingSource = this.postsBindingSource;
            this.postsBindingNavigator.CountItem = null;
            this.postsBindingNavigator.DeleteItem = null;
            this.postsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.postsBindingNavigatorSaveItem});
            this.postsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postsBindingNavigator.MoveFirstItem = null;
            this.postsBindingNavigator.MoveLastItem = null;
            this.postsBindingNavigator.MoveNextItem = null;
            this.postsBindingNavigator.MovePreviousItem = null;
            this.postsBindingNavigator.Name = "postsBindingNavigator";
            this.postsBindingNavigator.PositionItem = null;
            this.postsBindingNavigator.Size = new System.Drawing.Size(495, 25);
            this.postsBindingNavigator.TabIndex = 0;
            this.postsBindingNavigator.Text = "bindingNavigator1";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 182);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(contentLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.postsBindingNavigator);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).EndInit();
            this.postsBindingNavigator.ResumeLayout(false);
            this.postsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _CodeFirstNewDatabaseSample_BloggingContextDataSet _CodeFirstNewDatabaseSample_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.BlogsTableAdapter blogsTableAdapter;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton postsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator postsBindingNavigator;
    }
}