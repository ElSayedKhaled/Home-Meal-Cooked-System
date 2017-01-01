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
using System.Threading;

namespace Home_Meal_Cooked_systeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("name_price", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", textnaprice.Text));
      
            SqlParameter output = new SqlParameter("@@Price", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(output);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Item Price is : " +output.Value.ToString());
            //SqlConnection con = new SqlConnection("Data Source=SAYED\SQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select name , price from items", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable view_items = new DataTable();
            //view_items.Columns.Add("Items_Name");
            //view_items.Columns.Add("Items_Price");
            //DataRow row;
            //while (reader.Read())
            //{
            //    row = view_items.NewRow();
            //    row["Items_Name"] = reader["name"];
            //    row["Items_Price"] = reader["price"];
            //    view_items.Rows.Add(row);
            
            //}
            //reader.Close();
            //con.Close();
            //DGV.DataSource = view_items;
        }

        private void but_search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("GetLadies", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Area", textSearch.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Lady_tab = new DataTable();
            Lady_tab.Columns.Add("NickName");
            Lady_tab.Columns.Add("Phone Number");
            DataRow row;
            while (reader.Read())
            {
                row = Lady_tab.NewRow();
                row["NickName"] = reader["Nicknam"];
                row["Phone Number"] = reader["phone_number"];
                Lady_tab.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            DGV.DataSource = Lady_tab;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            insert sistema = new insert();
            sistema.ShowDialog();
            //this.Hide();
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // this.Hide();
            AD_order sistema = new AD_order();
            sistema.ShowDialog();
           // this.Close();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            UP_ITEM sistema = new UP_ITEM();
            sistema.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DEL_ITEM sistema = new DEL_ITEM();
            sistema.ShowDialog();
            this.Close();
        }

        private void butdelorder_Click(object sender, EventArgs e)
        {
            DEL_ORDER sistema = new DEL_ORDER();
            sistema.ShowDialog();
            this.Close();
        }

        private void textnaprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
