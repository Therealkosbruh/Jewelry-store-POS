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
using Zaytsev_Demoex.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zaytsev_Demoex.controls
{
    public partial class prodcontrol_adm : UserControl
    {
        //public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=MEPHI3-MSSQL";
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        int cnt_rows;
        int prod_article;
        string prodft;
        public prodcontrol_adm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prodcontrol_adm_Load(object sender, EventArgs e)
        {
            SqlCommand logRequest = new SqlCommand();
            logRequest.CommandText = "Select * FROM Products";
            logRequest.Connection = sqlConnect;

            SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            sqlConnect.Close();
            prod_grid.DataSource = dataSet.Tables[0];

            cnt_rows = dataSet.Tables[0].Rows.Count;
            label2.Text = cnt_rows.ToString();



            logRequest.CommandText = "Select * FROM Products WHERE sale > 1 ";
            logRequest.Connection = sqlConnect;
            prod_grid.DefaultCellStyle.BackColor = Color.FromArgb(127, 55, 0);
        }

        private void add_prod_trans_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (Application.OpenForms["Add_Product_Form"] == null)

            {

                Add_Product_Form apf = new Add_Product_Form();

                apf.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить товар из базы?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (prod_article != 0){
                    sqlConnect.Open();

                    SqlCommand logRequest = new SqlCommand();

                    logRequest.CommandType = CommandType.StoredProcedure;

                    logRequest.CommandText = "delProd";

                    logRequest.Parameters.AddWithValue("@article", prod_article);

                    logRequest.Connection = sqlConnect;

                    logRequest.Connection = sqlConnect;

                    try

                    {

                        logRequest.ExecuteNonQuery();

                        MessageBox.Show("Товар удален!");

                    }

                    catch (Exception ex)

                    {

                        MessageBox.Show($"Error: {ex.Message}");

                    }

                    finally

                    {

                        sqlConnect.Close();

                    }

                }

            }
            else
            {
                return;
            }
        }

        private void sale_filter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(sale_filter_cb.SelectedItem == "0-9,99%")
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE sale < 10 ";
                logRequest.Connection = sqlConnect;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                sqlConnect.Close();
                prod_grid.DataSource = dataSet.Tables[0];

                cnt_rows = dataSet.Tables[0].Rows.Count;
                label2.Text = cnt_rows.ToString();
            }

            else if(sale_filter_cb.SelectedItem == "10-14,99%")
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE sale = 10 AND sale < 15";
                logRequest.Connection = sqlConnect;
                SqlDataAdapter adapter = new SqlDataAdapter(logRequest);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                sqlConnect.Close();
                prod_grid.DataSource = dataSet.Tables[0];

                cnt_rows = dataSet.Tables[0].Rows.Count;
                label2.Text = cnt_rows.ToString();
            }

            else if(sale_filter_cb.SelectedItem == "15% и более") 
            {
                SqlCommand logRequest = new SqlCommand();
                logRequest.CommandText = "Select * FROM Products WHERE sale = 15 AND sale > 15";
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
            sale_price_lbl.Text = (Convert.ToInt32(price_lbl.Text)-(Convert.ToInt32(price_lbl.Text) / 100 * Convert.ToInt32(sale_qty_lbl.Text))).ToString();
        }

        private void find_prod_btn_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = prod_grid.DataSource;
            bs.Filter = "ProductName like '%" + prod_filter_tb.Text + "%'";
            prod_grid.DataSource = bs.DataSource;
        }

        private void prod_filter_tb_TextChanged(object sender, EventArgs e)
        {
            // (prod_grid.DataSource as DataTable).DefaultView.RowFilter = $"ProductName LIKE {prod_filter_tb.Text}";
            BindingSource bs = new BindingSource();
            bs.DataSource = prod_grid.DataSource;
            bs.Filter = "Convert(order_number, 'System.String') like '%" + prod_grid.Text + "%'";
            prod_grid.DataSource = bs.DataSource;
        }
    }
}

