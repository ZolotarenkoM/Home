using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domain;
using Session;

namespace Home_expenses
{
    public partial class Login : Form
    {
        /// <summary>
        /// Class for authorization user
        /// </summary>
        public Login()
        {
            InitializeComponent();
            textBox_login2.Text = "";
        }

        Operation op = new Operation();
        Log MyLog = new Log();
        int count = 1;

        /// <summary>
        /// Identification user in database (give 3 attempts)
        /// </summary>
        private void button_sign2_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Mushko_Home_BD.mdf;Integrated Security=True"))
                    {
                        string pass = op.GetHashString(textBox_pass2.Text);
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [User] where UserName='" + textBox_login2.Text + "' and Password='" + pass + "'", cn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Hide();
                            Form1 list = new Form1();
                            Form1.login = textBox_login2.Text;
                            list.MyLog.Write("Sign by \"" + Form1.login + "\"");    //write log
                            list.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(@"Wrong password!", @"Error!!!");
                            count++;
                            textBox_pass2.Clear();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Form1.login = textBox_login2.Text;
                MyLog.Write("Trying logon an unregistered user \"" + Form1.login + "\"");
                MessageBox.Show(@"You have used all attempts. Sorry...", @"Error!!!");
                Close();
            }
        }

        private void button_exit2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Registering user
        /// </summary>
        private void button_signUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_login2.Text))
                {
                    string pass = op.GetHashString(textBox_pass2.Text);
                    Users u = new Users
                    {
                        User = textBox_login2.Text,
                        Passwd = pass
                    };
                    op.SignUp(u);
                    MessageBox.Show(@"User registered successfully");
                    MyLog.Write(string.Format("User \"{0}\" registered successfully ", textBox_login2.Text));
                    textBox_login2.Clear();
                    textBox_pass2.Clear();
                }
                else
                {
                    MessageBox.Show(@"Login can't be empty", @"Error");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Wrong format, please try again", @"Error");
            }
            catch (SqlException)
            {
                MessageBox.Show(@"User already exists", @"Error");
                MyLog.Write(string.Format("User \"{0}\" already exists ", textBox_login2.Text));
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
                MyLog.Write(ob.Message);
            }
        }

        /// <summary>
        /// Clear all users in database
        /// </summary>
        private void button_clear_user_Click(object sender, EventArgs e)
        {
            try
            {
                op.ClearUsers();
            }
            catch (SqlException)
            {
                MessageBox.Show(@"User already exists", @"Error");
            }
            MessageBox.Show(@"All users was cleaned!", @"Info");
        }
    }
}
