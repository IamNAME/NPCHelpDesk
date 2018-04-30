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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.ShowDialog(); // Shows Form2
            /*try

            {

                if (!(usertxt.Text == string.Empty))

                {

                    if (!(passtxt.Text == string.Empty))

                    {

                        String str = "server=MUNESH-PC;database=windowapp;UID=sa;password=123";

                        String query = "select * from data where username = '" + usertxt.Text + "'and password = '" + this.passtxt.Text + "'";

                        SqlConnection con = new SqlConnection(str);

                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader dbr;

                        con.Open();

                        dbr = cmd.ExecuteReader();

                        int count = 0;

                        while (dbr.Read())

                        {

                            count = count + 1;

                        }

                        if (count == 1)

                        {

                            this.hide();

                            IssueForm f2 = new form2(); //this is the change, code for redirect

                            f2.ShowDialog();

                        }

                        else if (count > 1)

                        {

                            MessageBox.Show("Duplicate username and password", "login page");

                        }

                        else

                        {

                            MessageBox.Show(" username and password incorrect", "login page");

                        }

                    }

                    else

                    {

                        MessageBox.Show(" password empty", "login page");

                    }

                }

                else

                {

                    MessageBox.Show(" username empty", "login page");

                }

                // con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);
            }*/
      }
   }
}
