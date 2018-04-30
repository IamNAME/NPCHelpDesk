using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void TrblShoot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Issue tempIssue = new HelpDesk.Issue();
            tempIssue.IssueCategory = comboBox1.Text;
            tempIssue.IssueSpecificType = comboBox2.Text;
            tempIssue.IssueDate = dateTimePicker1.Value;
            tempIssue.IssueDeviceID = textBox2.Text;
            tempIssue.IssueDeviceOS = textBox1.Text;
            if (radioButton1.Checked)
            {
                tempIssue.Priority = 1;
            }
            else if(radioButton2.Checked)
            {
                tempIssue.Priority = 2;
            }
            else if(radioButton3.Checked)
            {
                tempIssue.Priority = 3;
            }
            tempIssue.saveIssueToFile();
        }
    }
}
