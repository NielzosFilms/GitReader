namespace GitReader
{
    partial class Form1
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
            this.openFileBTN = new System.Windows.Forms.Button();
            this.pullDataBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasUncommitedChanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasUnpushedCommits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCommitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCommitMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileBTN
            // 
            this.openFileBTN.Location = new System.Drawing.Point(779, 33);
            this.openFileBTN.Name = "openFileBTN";
            this.openFileBTN.Size = new System.Drawing.Size(75, 20);
            this.openFileBTN.TabIndex = 0;
            this.openFileBTN.Text = "...";
            this.openFileBTN.UseVisualStyleBackColor = true;
            this.openFileBTN.Click += new System.EventHandler(this.OpenFileBTN_Click);
            // 
            // pullDataBTN
            // 
            this.pullDataBTN.Location = new System.Drawing.Point(779, 86);
            this.pullDataBTN.Name = "pullDataBTN";
            this.pullDataBTN.Size = new System.Drawing.Size(75, 20);
            this.pullDataBTN.TabIndex = 1;
            this.pullDataBTN.Text = "Pull Data";
            this.pullDataBTN.UseVisualStyleBackColor = true;
            this.pullDataBTN.Click += new System.EventHandler(this.PullDataBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(761, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repository Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text file with GitHub usernames";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.CommitCount,
            this.HasUncommitedChanges,
            this.HasUnpushedCommits,
            this.LastCommitTime,
            this.LastCommitMessage});
            this.dataGridView1.Location = new System.Drawing.Point(13, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 237);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CommitCount
            // 
            this.CommitCount.HeaderText = "CommitCount";
            this.CommitCount.Name = "CommitCount";
            this.CommitCount.ReadOnly = true;
            this.CommitCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CommitCount.Width = 80;
            // 
            // HasUncommitedChanges
            // 
            this.HasUncommitedChanges.HeaderText = "HasUncommitedChanges";
            this.HasUncommitedChanges.Name = "HasUncommitedChanges";
            this.HasUncommitedChanges.ReadOnly = true;
            this.HasUncommitedChanges.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HasUncommitedChanges.Width = 140;
            // 
            // HasUnpushedCommits
            // 
            this.HasUnpushedCommits.HeaderText = "HasUnpushedCommits";
            this.HasUnpushedCommits.Name = "HasUnpushedCommits";
            this.HasUnpushedCommits.ReadOnly = true;
            this.HasUnpushedCommits.Width = 140;
            // 
            // LastCommitTime
            // 
            this.LastCommitTime.HeaderText = "LastCommitTime";
            this.LastCommitTime.Name = "LastCommitTime";
            this.LastCommitTime.ReadOnly = true;
            this.LastCommitTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LastCommitTime.Width = 140;
            // 
            // LastCommitMessage
            // 
            this.LastCommitMessage.HeaderText = "LastCommitMessage";
            this.LastCommitMessage.Name = "LastCommitMessage";
            this.LastCommitMessage.ReadOnly = true;
            this.LastCommitMessage.Width = 198;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(GitReader.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pullDataBTN);
            this.Controls.Add(this.openFileBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "GitReader | NielzosFilms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileBTN;
        private System.Windows.Forms.Button pullDataBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasUncommitedChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasUnpushedCommits;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCommitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCommitMessage;
    }
}

