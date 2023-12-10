using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaytsev_Demoex.panels;

namespace Zaytsev_Demoex
{
    public partial class Autorizform : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        //public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=MEPHI3-MSSQL";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        static int counter = 0;
        public Autorizform()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (rmmbr_chb.Checked == true)
            {
                Properties.Settings.Default.User_login = login_tb.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.User_login = "";
                Properties.Settings.Default.Save();
            }



            sqlConnect.Open();
            SqlCommand logRequsest = new SqlCommand();
            logRequsest.CommandType = CommandType.StoredProcedure;
            logRequsest.CommandText = "Login";
            logRequsest.Parameters.AddWithValue("@login", login_tb.Text);
            logRequsest.Parameters.AddWithValue("@password", pass_tb.Text);
            logRequsest.Connection = sqlConnect;


            counter++;
            using (SqlDataReader sqlReader = logRequsest.ExecuteReader())
            {
                if (sqlReader.Read())
                {

                    string userId = Convert.ToString(sqlReader["login"]);


                    sqlReader.Close();


                    SqlCommand roleRequest = new SqlCommand();
                    roleRequest.CommandType = CommandType.Text;
                    roleRequest.CommandText = "SELECT role FROM users WHERE login = @login";
                    roleRequest.Parameters.AddWithValue("@login", userId);
                    roleRequest.Connection = sqlConnect;

                    counter++;
                    using (SqlDataReader roleReader = roleRequest.ExecuteReader())
                    {
                        if (roleReader.Read())
                        {
                            int roleId = Convert.ToInt32(roleReader["role"]);


                            if (roleId == 1)
                            {

                                this.Hide();
                                UserPanel upan = new UserPanel();
                                upan.Show();
                            }
                            else if (roleId == 2)
                            {

                                this.Hide();

                                Manager_Panel mpan = new Manager_Panel();
                                mpan.Show();
                            }
                            else if (roleId == 3)
                            {

                                this.Hide();

                                Admin_Panel apan = new Admin_Panel();
                                apan.Show();
                            }
                            sqlConnect.Close();
                        }
                        else if (counter == 2)
                        {
                            InputBlocker();
                        }
                        else if (counter == 3)
                        {
                            this.Hide();
                            Captcha cpth = new Captcha();
                            cpth.Show();
                        }
                    }
                }
            }
        }
        private async void InputBlocker()
        {
            BlockForm();
            await Task.Delay(5000);
            UnblockForm();
        }

        private void BlockForm()
        {
            this.Enabled = false;
        }

        private void UnblockForm()
        {
            this.Enabled = true;
        }

        private void Autorizform_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.User_login != String.Empty)
            {
                login_tb.Text = Properties.Settings.Default.User_login;
            }
        }

        private void guestlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Nonauth_usr_Panel nup = new Nonauth_usr_Panel();
            nup.Show();
        }
    }
}
