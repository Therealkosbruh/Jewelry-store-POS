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

namespace Zaytsev_Demoex.controls
{
    public partial class usr_order_control : UserControl
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        public usr_order_control()
        {
            InitializeComponent();
        }

        private void usr_order_control_Load(object sender, EventArgs e)
        {
            SqlCommand logRequest = new SqlCommand();
            logRequest.CommandText = "Select * FROM orders";
            logRequest.Connection = sqlConnect;

            SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            sqlConnect.Close();
            ord_grid.DataSource = dataSet.Tables[0];

            cnt_rows = dataSet.Tables[0].Rows.Count;
            label2.Text = cnt_rows.ToString();

            logRequest.CommandText = "Select * FROM orders where quanty>3";
            logRequest.Connection = sqlConnect;
            ord_grid.DefaultCellStyle.BackColor = Color.FromArgb(32, 178, 170);


            logRequest.CommandText = "Select * FROM orders where quanty<1";
            logRequest.Connection = sqlConnect;
            ord_grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 0);
        }

        private void find_ord_tb_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ord_grid.DataSource;
            bs.Filter = "Convert(order_number, 'System.String') like '%" + find_ord_tb.Text + "%'";
            ord_grid.DataSource = bs.DataSource;
        }
    }
}
