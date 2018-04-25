using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    class Issue
    {
        private int issueID;
        private DateTime issueDate;
        private string issueCategory;
        private string issueSpecificType;
        private bool highPriority;
        private string issueDeviceID;
        private string issueDeviceOS;
        private string issueDescription;

        public int IssueID
        {
            get
            {
                return issueID;
            }

            set
            {
                issueID = value;
            }
        }

        public DateTime IssueDate
        {
            get
            {
                return issueDate;
            }

            set
            {
                issueDate = value;
            }
        }

        public string IssueCategory
        {
            get
            {
                return issueCategory;
            }

            set
            {
                issueCategory = value;
            }
        }

        public string IssueSpecificType
        {
            get
            {
                return issueSpecificType;
            }

            set
            {
                issueSpecificType = value;
            }
        }

        public bool HighPriority
        {
            get
            {
                return highPriority;
            }

            set
            {
                highPriority = value;
            }
        }

        public string IssueDeviceID
        {
            get
            {
                return issueDeviceID;
            }

            set
            {
                issueDeviceID = value;
            }
        }

        public string IssueDeviceOS
        {
            get
            {
                return issueDeviceOS;
            }

            set
            {
                issueDeviceOS = value;
            }
        }

        public string IssueDescription
        {
            get
            {
                return issueDescription;
            }

            set
            {
                issueDescription = value;
            }
        }
    }
}
