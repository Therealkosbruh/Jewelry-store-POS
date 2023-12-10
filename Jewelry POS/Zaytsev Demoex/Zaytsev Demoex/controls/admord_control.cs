using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaytsev_Demoex.controls
{
    public partial class admord_control : UserControl
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        public admord_control()
        {
            InitializeComponent();
        }

        private void admord_control_Load(object sender, EventArgs e)
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


            sqlConnect.Open();
            SqlCommand delivAdr = new SqlCommand("Select status_name from status", sqlConnect);
            SqlDataReader adr = delivAdr.ExecuteReader();

            while (adr.Read())
            {
                new_status_cb.Items.Add(adr.GetString(0));
            }
            new_status_cb.SelectedIndex = 0;
            sqlConnect.Close();
        }

        private void sale_filter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void change_ord_Click(object sender, EventArgs e)
        {
            int newstatus = new_status_cb.SelectedIndex+1;
            sqlConnect.Open();
            if (ord_grid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ord_grid.SelectedRows[0];
                string oi = selectedRow.Cells[0].Value.ToString();
                int ord_id = Convert.ToInt32(oi);
                SqlCommand updatestatus = new SqlCommand();
                updatestatus.CommandText = $"UPDATE orders set status='{newstatus}' WHERE order_number='{ord_id}'";
                updatestatus.Connection = sqlConnect;
                updatestatus.ExecuteNonQuery();
                MessageBox.Show("Статус заказа успешно изменен!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выбирете строку с заказом, статус которого необходимо изменить.");
            }
            sqlConnect.Close();
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
