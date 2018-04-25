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
        private int priority;
        private string issueDeviceID;
        private string issueDeviceOS;
        private string issueDescription;
        private bool issueCompleted;
        private string issueWorkedBy;
        private DateTime issueWorkedDate;
        private string issueResolution;

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

        public bool Priority
        {
            get
            {
                return Priority;
            }

            set
            {
                Priority = value;
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

        public bool IssueCompleted
        {
            get
            {
                return issueCompleted;
            }

            set
            {
                issueCompleted = value;
            }
        }

        public string IssueResolution
        {
            get
            {
                return issueResolution;
            }

            set
            {
                issueResolution = value;
            }
        }
    }
}
