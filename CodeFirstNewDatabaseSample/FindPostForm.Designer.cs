namespace CodeFirstNewDatabaseSample
{
    partial class FindPostForm
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
            this.PostToFindBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._CodeFirstNewDatabaseSample_BloggingContextDataSet = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSet();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter();
            this.tableAdapterManager = new CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager();
            this.postsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.contentBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // PostToFindBox
            // 
            this.PostToFindBox.Location = new System.Drawing.Point(12, 53);
            this.PostToFindBox.Name = "PostToFindBox";
            this.PostToFindBox.Size = new System.Drawing.Size(100, 20);
            this.PostToFindBox.TabIndex = 0;
            this.PostToFindBox.Text = "Title of the post";
            this.PostToFindBox.TextChanged += new System.EventHandler(this.PostToFindBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.BlogsTableAdapter = null;
            this.tableAdapterManager.PostsTableAdapter = this.postsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CodeFirstNewDatabaseSample._CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // postsBindingNavigator
            // 
            this.postsBindingNavigator.AddNewItem = null;
            this.postsBindingNavigator.BindingSource = this.postsBindingSource;
            this.postsBindingNavigator.CountItem = null;
            this.postsBindingNavigator.DeleteItem = null;
            this.postsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postsBindingNavigator.MoveFirstItem = null;
            this.postsBindingNavigator.MoveLastItem = null;
            this.postsBindingNavigator.MoveNextItem = null;
            this.postsBindingNavigator.MovePreviousItem = null;
            this.postsBindingNavigator.Name = "postsBindingNavigator";
            this.postsBindingNavigator.PositionItem = null;
            this.postsBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.postsBindingNavigator.TabIndex = 2;
            this.postsBindingNavigator.Text = "bindingNavigator1";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(12, 133);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(448, 20);
            this.contentBox.TabIndex = 3;
            this.contentBox.Text = "Content";
            this.contentBox.TextChanged += new System.EventHandler(this.contentBox_TextChanged);
            // 
            // FindPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 171);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.postsBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PostToFindBox);
            this.Name = "FindPostForm";
            this.Text = "FindPostForm";
            this.Load += new System.EventHandler(this.FindPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CodeFirstNewDatabaseSample_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingNavigator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PostToFindBox;
        private System.Windows.Forms.Button button1;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSet _CodeFirstNewDatabaseSample_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private _CodeFirstNewDatabaseSample_BloggingContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postsBindingNavigator;
        private System.Windows.Forms.TextBox contentBox;
    }
}