namespace GitReader
{
    partial class Details
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCommitBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uncommitedBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unpushedBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lastcommitBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastmessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 35);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(285, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total commits";
            // 
            // totalCommitBox
            // 
            this.totalCommitBox.Location = new System.Drawing.Point(12, 84);
            this.totalCommitBox.Name = "totalCommitBox";
            this.totalCommitBox.ReadOnly = true;
            this.totalCommitBox.Size = new System.Drawing.Size(285, 20);
            this.totalCommitBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Has uncomitted changes";
            // 
            // uncommitedBox
            // 
            this.uncommitedBox.Location = new System.Drawing.Point(12, 136);
            this.uncommitedBox.Name = "uncommitedBox";
            this.uncommitedBox.ReadOnly = true;
            this.uncommitedBox.Size = new System.Drawing.Size(285, 20);
            this.uncommitedBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Has unpushed changes";
            // 
            // unpushedBox
            // 
            this.unpushedBox.Location = new System.Drawing.Point(12, 187);
            this.unpushedBox.Name = "unpushedBox";
            this.unpushedBox.ReadOnly = true;
            this.unpushedBox.Size = new System.Drawing.Size(285, 20);
            this.unpushedBox.TabIndex = 6;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(323, 35);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(465, 403);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log (All commits)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last commit time";
            // 
            // lastcommitBox
            // 
            this.lastcommitBox.Location = new System.Drawing.Point(12, 237);
            this.lastcommitBox.Name = "lastcommitBox";
            this.lastcommitBox.ReadOnly = true;
            this.lastcommitBox.Size = new System.Drawing.Size(285, 20);
            this.lastcommitBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last commit message";
            // 
            // lastmessageBox
            // 
            this.lastmessageBox.Location = new System.Drawing.Point(12, 290);
            this.lastmessageBox.Name = "lastmessageBox";
            this.lastmessageBox.ReadOnly = true;
            this.lastmessageBox.Size = new System.Drawing.Size(285, 20);
            this.lastmessageBox.TabIndex = 12;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastmessageBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastcommitBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unpushedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uncommitedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalCommitBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Details";
            this.Text = "userDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalCommitBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uncommitedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unpushedBox;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastcommitBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastmessageBox;
    }
}