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
using System.IO;

namespace Zaytsev_Demoex.forms
{
    public partial class Add_Product_Form : Form
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=zaytsev-isp401;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public Add_Product_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_prod_btn_Click(object sender, EventArgs e)
        {
            if (sqlConnect.State == ConnectionState.Open)
                sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand logRequest = new SqlCommand();
            logRequest.CommandType = CommandType.StoredProcedure;
            logRequest.CommandText = "newProd";
            logRequest.Connection = sqlConnect;

            logRequest.Parameters.AddWithValue("@ProductArticleNumber",article_tb.Text);
            logRequest.Parameters.AddWithValue("@ProductName", prod_name_tb.Text);
            logRequest.Parameters.AddWithValue("@prod_price", price_tb.Text);
            logRequest.Parameters.AddWithValue("@max_sale", max_sale_tb.Text);
            logRequest.Parameters.AddWithValue("@ProductManufacturer", manufact_cb.SelectedItem);
            logRequest.Parameters.AddWithValue("@Supplier", suppl_cb.SelectedItem);
            logRequest.Parameters.AddWithValue("@Category", cat_cb.SelectedItem);
            logRequest.Parameters.AddWithValue("@Current_sale", cur_sale_tb.Text);
            logRequest.Parameters.AddWithValue("@ProductQuantityInStock", qty_onstock_tb.Text);
            logRequest.Parameters.AddWithValue("@Descr", descr_tb.Text);
            logRequest.Parameters.AddWithValue("@ProductPhoto", price_tb.Text);

            try
            {
                logRequest.ExecuteNonQuery();

                MessageBox.Show("Товар успешно добавлен в базу!");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                sqlConnect.Close();


            }
            this.Hide();

            {
                Application.OpenForms["Admin_Panel"].Show();
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            {
                Application.OpenForms["Admin_Panel"].Show();
            }
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand manuf = new SqlCommand("SELECT DISTINCT ProductManufacturer FROM products", sqlConnect);
            SqlDataReader manufReader = manuf.ExecuteReader();

            while (manufReader.Read())
            {

                if (!manufReader.IsDBNull(0))
                {
                    manufact_cb.Items.Add(manufReader[0].ToString());
                }
            }
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand supl = new SqlCommand("SELECT DISTINCT Supplier FROM products", sqlConnect);
            SqlDataReader suplReader = supl.ExecuteReader();

            while (suplReader.Read())
            {

                if (!suplReader.IsDBNull(0))
                {
                    suppl_cb.Items.Add(suplReader[0].ToString());
                }
            }
            sqlConnect.Close();


            sqlConnect.Open();
            SqlCommand cat = new SqlCommand("SELECT DISTINCT Category FROM products", sqlConnect);
            SqlDataReader catReader = cat.ExecuteReader();

            while (catReader.Read())
            {

                if (!catReader.IsDBNull(0))
                {
                    cat_cb.Items.Add(catReader[0].ToString());
                }
            }
            sqlConnect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

