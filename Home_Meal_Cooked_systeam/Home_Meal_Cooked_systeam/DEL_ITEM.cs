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
    public partial class DEL_ITEM : Form
    {
        public DEL_ITEM()
        {
            InitializeComponent();
        }

        private void DEL_ITEM_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butVITEM_Click(object sender, EventArgs e)
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
            DGVdel.DataSource = V_items;
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from items where name = @NAME", con);
            cmd.Parameters.Add(new SqlParameter("@NAME", textdelname.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            con.Close();
            MessageBox.Show("          DONE          ");
        }
    }
}
