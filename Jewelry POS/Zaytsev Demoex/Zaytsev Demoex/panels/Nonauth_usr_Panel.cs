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

namespace Zaytsev_Demoex.panels
{
    public partial class Nonauth_usr_Panel : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        //public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=MEPHI3-MSSQL";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        public Nonauth_usr_Panel()
        {
            InitializeComponent();
        }

        private void make_ord_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для совершения заказа вам необходимо быть авторизованным, пользователем.");
        }

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            if (prod_grid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = prod_grid.SelectedRows[0].Clone() as DataGridViewRow;
                foreach (DataGridViewCell cell in prod_grid.SelectedRows[0].Cells)
                {
                    selectedRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }
                var index = cartList.Rows.Add();
                cartList.Rows[index].Cells[0].Value = prod_grid.Rows[0].Cells[0].Value;
                cartList.Rows[index].Cells[1].Value = prod_grid.Rows[0].Cells[3].Value;
                cartList.Rows[index].Cells[2].Value = prod_grid.Rows[0].Cells[4].Value;
                cartList.Rows[index].Cells[3].Value = Convert.ToString(1);
            }
            else
            {
                MessageBox.Show("Выберите товар для добавления в корзину");
            }
            TotalPrice();
        }

        private void TotalPrice()
        {
            double total = 0;
            for (int i = 0; i < cartList.Rows.Count - 1; i++)
            {
                total += double.Parse(cartList.Rows[i].Cells[1].Value.ToString());
            }
            total_price_tb.Text = Convert.ToString(total);
        }

        private void prod_filter_tb_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = prod_grid.DataSource;
            bs.Filter = "ProductName like '%" + prod_filter_tb.Text + "%'";
            prod_grid.DataSource = bs.DataSource;
        }

        private void Nonauth_usr_Panel_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand delivAdr = new SqlCommand("Select DISTINCT Street from place_of_delivery", sqlConnect);
            SqlDataReader adr = delivAdr.ExecuteReader();

            while (adr.Read())
            {
                address_cb.Items.Add(adr.GetString(0));
            }
            address_cb.SelectedIndex = 0;
            sqlConnect.Close();





            SqlCommand logRequest = new SqlCommand();
            logRequest.CommandText = "Select * FROM products";
            logRequest.Connection = sqlConnect;

            SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            sqlConnect.Close();
            prod_grid.DataSource = dataSet.Tables[0];

            cnt_rows = dataSet.Tables[0].Rows.Count;
            label2.Text = cnt_rows.ToString();



            logRequest.CommandText = "Select * FROM Products WHERE current_sale > 1 ";
            logRequest.Connection = sqlConnect;
            prod_grid.DefaultCellStyle.BackColor = Color.FromArgb(127, 55, 0);
        }

        private void sale_filter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sale_filter_cb.SelectedItem == "0-9,99%")
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE current_sale < 10 ";
                logRequest.Connection = sqlConnect;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                sqlConnect.Close();
                prod_grid.DataSource = dataSet.Tables[0];

                cnt_rows = dataSet.Tables[0].Rows.Count;
                label2.Text = cnt_rows.ToString();
            }

            else if (sale_filter_cb.SelectedItem == "10-14,99%")
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE current_sale= 10 AND current_sale< 15";
                logRequest.Connection = sqlConnect;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                sqlConnect.Close();
                prod_grid.DataSource = dataSet.Tables[0];

                cnt_rows = dataSet.Tables[0].Rows.Count;
                label2.Text = cnt_rows.ToString();
            }

            else if (sale_filter_cb.SelectedItem == "15% и более")
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE current_sale= 15 AND current_sale > 15";
                logRequest.Connection = sqlConnect;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                sqlConnect.Close();
                prod_grid.DataSource = dataSet.Tables[0];

                cnt_rows = dataSet.Tables[0].Rows.Count;
                label2.Text = cnt_rows.ToString();
            }
        }

        private void prod_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            desc_lbl.Text = prod_grid.Rows[e.RowIndex].Cells[10].Value.ToString();
            price_lbl.Text = prod_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            sale_qty_lbl.Text = prod_grid.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
