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

namespace Home_Meal_Cooked_systeam
{
    public partial class AD_order : Form
    {
        public double res;
        public AD_order()
        {
            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void add_order_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            co.Open();
            SqlCommand cmd1 = new SqlCommand("name_price", co);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("@Name", textname.Text));

            SqlParameter output = new SqlParameter("@@Price", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            cmd1.Parameters.Add(output);
            cmd1.ExecuteNonQuery();

            double s = double.Parse(output.Value.ToString());
           
          
          
           
            co.Close();
       
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ORDEER ( no_items, name ,bill) values ( @NUMBER_ITEMS ,@na , @hh) ", con);
            double d = double.Parse(cmd.Parameters.Add(new SqlParameter("@NUMBER_ITEMS", textnum.Text)).Value.ToString());
        
           
            cmd.Parameters.Add(new SqlParameter("@na", textname.Text));
            res = s * d;
            textBox1.Text = res.ToString();
            cmd.Parameters.Add(new SqlParameter("@hh", textBox1.Text));
          
            SqlDataReader reader = cmd.ExecuteReader();
            
           
            reader.Close();
            con.Close();
            MessageBox.Show("          DONE          ");
           
        }

        private void textdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VIEWORDER_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Order_ID ,name ,no_items , bill from ORDEER", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable V_order = new DataTable();
            V_order.Columns.Add("Order ID");
            V_order.Columns.Add("Name");
            V_order.Columns.Add("No_Items");
            V_order.Columns.Add("BILL");
            DataRow row;
            while (reader.Read())
            {
                row = V_order.NewRow();
                row["Order ID"] = reader["Order_ID"];
                row["Name"] = reader["name"];
                row["No_Items"] = reader["no_items"];
                row["BILL"] = reader["bill"];
                V_order.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            DGV_OR.DataSource = V_order;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select name ,typee , timee ,ingredients, price from items", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable V_items = new DataTable();
            V_items.Columns.Add("Items_Name");
            V_items.Columns.Add("Items_Type");
            V_items.Columns.Add("Items_Time");
            V_items.Columns.Add("Items_Ingredients");
            V_items.Columns.Add("Items_Price");
            DataRow row;
            while (reader.Read())
            {
                row = V_items.NewRow();
                row["Items_Name"] = reader["name"];
                row["Items_Type"] = reader["typee"];
                row["Items_Time"] = reader["timee"];
                row["Items_Ingredients"] = reader["ingredients"];
                row["Items_Price"] = reader["price"];
                V_items.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            DGV_OR.DataSource = V_items;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
