using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zaytsev_Demoex
{
    public partial class Admin_Panel : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        //public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=MEPHI3-MSSQL";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public Admin_Panel()
        {
            InitializeComponent();
            sidepan.Height = adm_home_btn.Height;
            sidepan.Top = adm_home_btn.Top;
            adm_maincontrol1.BringToFront();
        }

        private void adm_prod_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height = adm_prod_btn.Height;
            sidepan.Top = adm_prod_btn.Top;
            prodcontrol_adm1.BringToFront();
        }

        private void ord_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height = ord_btn.Height;
            sidepan.Top= ord_btn.Top;
            admord_control1.BringToFront();
        }

        private void adm_home_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height=adm_home_btn.Height;
            sidepan.Top= adm_home_btn.Top;
            adm_maincontrol1.BringToFront();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

            usr_login_lbl.Text = Properties.Settings.Default.User_login;


            sqlConnect.Open();
            SqlCommand usrfullname = new SqlCommand("SELECT Last_name, Name, Patronymic FROM users WHERE login = @login", sqlConnect);
            usrfullname.Parameters.AddWithValue("@login", usr_login_lbl.Text);
            SqlDataReader reader = usrfullname.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string lastName = reader["Last_name"].ToString();
                    string name = reader["Name"].ToString();
                    string patronymic = reader["Patronymic"].ToString();

                    fio_user_lbl.Text += $"{lastName} {name} {patronymic}";
                }
            }
            else
            {
                fio_user_lbl.Text = "No data";
            }
            sqlConnect.Close();

            Properties.Settings.Default.Save();
        }
    }
}
