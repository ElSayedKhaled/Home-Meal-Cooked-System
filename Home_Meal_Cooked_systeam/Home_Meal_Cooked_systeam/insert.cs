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
using System.Web;
using System.Net;
using System.IO;
namespace Home_Meal_Cooked_systeam
{
    public partial class insert : Form
    {public string fName ;
        public insert()
        {
           
            InitializeComponent();
        }
        private void add_itens_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SAYEDSQLEXPRESS;Initial Catalog=Home_Cooked_Meal_System;Integrated Security=True");
            con.Open();
          SqlCommand cmd=new SqlCommand( "insert into items (name ,picture, timee , typee ,ingredients ,price ) values ( @NAME , @TIMEE , @TYPEE ,@INGREDIENTS ,@PRICE) " , con );
          cmd.Parameters.Add(new SqlParameter("@NAME", textname.Text));
            
          cmd.Parameters.Add(new SqlParameter("@TIMEE", texttime.Text));
          cmd.Parameters.Add(new SqlParameter("@TYPEE", texttype.Text ));
          cmd.Parameters.Add(new SqlParameter("@INGREDIENTS", textingr.Text));
          cmd.Parameters.Add(new SqlParameter("@PRICE", textprice.Text ));
          SqlDataReader reader = cmd.ExecuteReader();
   
          reader.Close();
          con.Close();
          MessageBox.Show("          DONE          ");
        }

        private void insert_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            DGV_Items.DataSource = V_items;
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
