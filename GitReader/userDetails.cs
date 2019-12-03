using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitReader
{
    public partial class Details : Form
    {
        private string text;

        public Details(string username, string commitcount, string uncommited, string unpushed, string lasttime, string lastmessage, string log)
        {
            InitializeComponent();

            usernameBox.Text = username;
            totalCommitBox.Text = commitcount;
            uncommitedBox.Text = uncommited;
            unpushedBox.Text = unpushed;
            lastcommitBox.Text = lasttime;
            lastmessageBox.Text = lastmessage;
            logBox.Text = log;
        }
    }
}
