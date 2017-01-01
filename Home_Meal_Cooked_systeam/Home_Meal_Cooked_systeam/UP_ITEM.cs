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
    public partial class UP_ITEM : Form
    {
        public UP_ITEM()
        {
            InitializeComponent();
        }

        private void UP_ITEM_Load(object sender, EventArgs e)
        {

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("update items set price = @PR , timee=@tm , typee=@ty , ingredients =@in   where name = @NA", cn);
            cm.Parameters.Add(new SqlParameter("@NA", textitname.Text));
            cm.Parameters.Add(new SqlParameter("@PR", textnewprice.Text));
            cm.Parameters.Add(new SqlParameter("@tm", texttime.Text));
            cm.Parameters.Add(new SqlParameter("@ty", texttype.Text));
            cm.Parameters.Add(new SqlParameter("@in", textinger.Text));
            SqlDataReader rd = cm.ExecuteReader();
            rd.Close();
            cn.Close();
            MessageBox.Show("          DONE          ");
        }

        private void butview_Click(object sender, EventArgs e)
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
            DGView.DataSource = V_items;
        }

        private void textitname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnewprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
