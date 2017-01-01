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
    public partial class DEL_ORDER : Form
    {
        public DEL_ORDER()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from ORDEER where Order_ID = @orderid", con);
            cmd.Parameters.Add(new SqlParameter("@orderid", textdelid.Text ));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            MessageBox.Show("          DONE          ");
        }

        private void DEL_ORDER_Load(object sender, EventArgs e)
        {

        }

        private void butVorder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Order_ID ,orderdate , bill ,no_items from ORDEER", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable V_order = new DataTable();
            V_order.Columns.Add("Order ID");
            V_order.Columns.Add("OrderDate");
            V_order.Columns.Add("Bill");
            V_order.Columns.Add("No_Items");
            DataRow row;
            while (reader.Read())
            {
                row = V_order.NewRow();
                row["Order ID"] = reader["Order_ID"];
                row["OrderDate"] = reader["orderdate"];
                row["Bill"] = reader["bill"];
                row["No_Items"] = reader["no_items"];
                V_order.Rows.Add(row);

            }
            reader.Close();
            con.Close();
            DGV_delorder.DataSource = V_order;
        }
    }
}
