using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitReader
{
    class User
    {
        public string username;
        public int commitCount;
        public IEnumerable<string> log;
        public string tot_log;
        public List<String> commit_date_times = new List<String>();
        public List<String> commit_messages = new List<String>();
        public bool hasUncommitedChanges;
        public bool hasUnpushedCommits;

        public User(string username, int commitCount, IEnumerable<string> log, bool hasUncommitedChanges, bool hasUnpushedCommits, string tot_log)
        {
            this.username = username;
            this.commitCount = commitCount;
            this.log = log;
            this.hasUncommitedChanges = hasUncommitedChanges;
            this.hasUnpushedCommits = hasUnpushedCommits;
            this.tot_log = tot_log;
        }

        public void addCommitDateTime(string commit_date_time)
        {
            this.commit_date_times.Add(commit_date_time);
        }
        public void addCommitMessage(string commit_message)
        {
            this.commit_messages.Add(commit_message);
        }

    }
}
