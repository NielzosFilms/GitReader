using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace GitReader
{
    public partial class Form1 : Form
    {
        public string textFilePath;
        List<String> usernames = new List<String>();
        List<User> users = new List<User>();
        public string repositoryName;
        private ProgressBarForm pgbf;
        private int progressValue = 0;

        public Form1()
        {
            InitializeComponent();
            /*backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);*/
        }

        private void OpenFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if(dlg.FileName != "")
            {
                textBox1.Text = dlg.FileName;
                this.textFilePath = dlg.FileName;
            }
        }

        private void PullDataBTN_Click(object sender, EventArgs e)
        {
            
            //backgroundWorker1.RunWorkerAsync();
            if (textFilePath != null && textBox2.Text != null)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string saveLocation = fbd.SelectedPath;
                        GetNamesOfTextFile(this.textFilePath);
                        this.repositoryName = textBox2.Text;
                        GitCloneCMD(saveLocation);
                    }
                }
            }
            //backgroundWorker1.CancelAsync();
            //pgbf.Close();
        }

        private void GetNamesOfTextFile(string fileLocation)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);
            while ((line = file.ReadLine()) != null)
            {
                usernames.Add(line);
            }
        }

        private void GitCloneCMD(string download)
        {
            int percent_per_user = Convert.ToInt32(100/usernames.Count());
            
            for (int i = 0; i < usernames.Count(); i++)
            {
                string username = usernames[i];
                Console.WriteLine(username);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                if (!Directory.Exists(download + @"\" + username))
                {
                    DirectoryInfo di = Directory.CreateDirectory(download + @"\" + username);
                }
                else if (Directory.Exists(download + @"\" + username + @"\" + repositoryName))
                {
                    DirectoryInfo di1 = new DirectoryInfo(download + @"\" + username + @"\" + repositoryName);
                    setAttributesNormal(di1);
                    Directory.Delete(download + @"\" + username + @"\" + repositoryName, true);

                }
                progressValue = 100;

                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.WorkingDirectory = download + @"\" + username;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C git clone https://github.com/"+username+"/"+repositoryName;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                RepositoryInformation repoInfo = RepositoryInformation.GetRepositoryInformationForPath(download + @"\" + username + @"\" + repositoryName);
                string tot_log = "";
                for (int j = 0; j < repoInfo.Log.Count(); j++)
                {
                    string commit = repoInfo.Log.ElementAt(j);
                    tot_log += commit + System.Environment.NewLine + System.Environment.NewLine;
                }
                User user = new User(username, repoInfo.Log.Count(), repoInfo.Log, repoInfo.HasUncommittedChanges, repoInfo.HasUnpushedCommits, tot_log);
                for (int j = 0; j < repoInfo.Log.Count(); j++)
                {
                    string commit = repoInfo.Log.ElementAt(j);
                    user.addCommitDateTime(GetCommitDateTime(commit));
                    user.addCommitMessage(GetCommitMessage(commit));
                }
                users.Add(user);
                dataGridView1.Rows.Add(new String[] { user.username, Convert.ToString(user.commitCount), Convert.ToString(user.hasUncommitedChanges), Convert.ToString(user.hasUnpushedCommits), user.commit_date_times[0], user.commit_messages[0]});
            }
            SaveExcelSheet(download);
        }

        private string GetCommitDateTime(string commit)
        {
            int index = commit.IndexOf("Date:")+8;
            int index_end = commit.IndexOf("+")-1;
            string time2 = String.Concat(commit.Skip(index).Take(index_end-index));
            return time2;
        }

        private string GetCommitMessage(string commit)
        {
            int index = commit.IndexOf("+")+11;
            string message = commit.Substring(index);
            return message;
        }

        private void SaveExcelSheet(string path)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Initialize Application
                IApplication application = excelEngine.Excel;

                //Set the default application version as Excel 2016
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Create a new workbook
                IWorkbook workbook = application.Workbooks.Create(1);

                //Access first worksheet from the workbook instance
                IWorksheet worksheet = workbook.Worksheets[0];

                //Exporting DataTable to worksheet
                DataGridView dataTable = (dataGridView1);
                worksheet.ImportDataGridView(dataTable, 1, 1, true, false);
                worksheet.UsedRange.AutofitColumns();

                //Save the workbook to disk in xlsx format
                workbook.SaveAs(path + @"\Saved_Table_"+repositoryName+".xlsx");
            }
        }

        private void setAttributesNormal(DirectoryInfo dir)
        {
            foreach (var subDir in dir.GetDirectories())
                setAttributesNormal(subDir);
            foreach (var file in dir.GetFiles())
            {
                file.Attributes = FileAttributes.Normal;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            this.pgbf = new ProgressBarForm();
            pgbf.Show();
            pgbf.setProgress(progressValue);
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dataValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                foreach(User user in users)
                {
                    if(user.username == dataValue)
                    {
                        Details details = new Details(user.username, Convert.ToString(user.commitCount), Convert.ToString(user.hasUncommitedChanges), Convert.ToString(user.hasUnpushedCommits), Convert.ToString(user.commit_date_times.ElementAt(0)), Convert.ToString(user.commit_messages.ElementAt(0)), user.tot_log);
                        details.Show();
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
            
        }
    }
}
