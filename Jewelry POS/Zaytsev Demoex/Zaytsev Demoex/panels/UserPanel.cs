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
    public partial class UserPanel : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        //public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=MEPHI3-MSSQL";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public UserPanel()
        {
            InitializeComponent();
            sidepan.Height = home_btn.Height;
            sidepan.Top = home_btn.Top;
            user_home_control1.BringToFront();
        }

        private void prod_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height = prod_btn.Height;
            sidepan.Top = prod_btn.Top;
            user_prod_control1.BringToFront();
        }

        private void user_prod_control1_Load(object sender, EventArgs e)
        {

        }

        private void find_ord_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height = find_ord_btn.Height;
            sidepan.Top  = find_ord_btn.Top;
            usr_order_control1.BringToFront();
        }

        private void UserPanel_Load(object sender, EventArgs e)
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

            sqlConnect.Open();
            SqlCommand usrid = new SqlCommand("SELECT usr_id FROM users WHERE login = @login", sqlConnect);
            usrid.Parameters.AddWithValue("@login", usr_login_lbl.Text);
            object results = usrid.ExecuteScalar();
            if(results != null)
            {
                usr_id_lbl.Text = results.ToString();
            }
            else
            {
                usr_id_lbl.Text = "No data";
            }
            string user_id = usr_id_lbl.Text;

            Properties.Settings.Default.user_id = usr_id_lbl.Text;
            Properties.Settings.Default.Save();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            sidepan.Height = home_btn.Height;
            sidepan.Top = home_btn.Top;
            user_home_control1.BringToFront();
        }
    }
}
