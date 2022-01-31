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

namespace MarksSheet
{
    public partial class Delete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\dell\onedrive\documents\visual studio 2012\Projects\MarksSheet\MarksSheet\MarksData.mdf;Integrated Security=True");
       
        public Delete()
        {
            
            InitializeComponent();
            display();
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Marks";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            gd3.DataSource = dt1;
            con.Close();
        }
        private void Delete_click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Delete from Marks  Where Roll_No=" + txtroll.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entities has been sucessfully deleted");
            con.Close();
            display();
        }
        

        private void Delete_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            First ol = new First();
            ol.Show();
            this.Hide();
        }
    }
}
