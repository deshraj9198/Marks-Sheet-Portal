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
    public partial class New : Form
    {
        
        public New()
        {
            InitializeComponent();
        }

       

        private void Result_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, n6 ,total;
            n1 = Convert.ToInt32(txtth.Text) + Convert.ToInt32(txtph.Text);
            lblth.Text = n1.ToString();
            n2 = Convert.ToInt32(txtte.Text) + Convert.ToInt32(txtpe.Text);
            lblte.Text = n2.ToString();
            n3 = Convert.ToInt32(txttm.Text) + Convert.ToInt32(txtpm.Text);
            lbltm.Text = n3.ToString();
            n4 = Convert.ToInt32(txttsc.Text) + Convert.ToInt32(txtpsc.Text);
            lbltsc.Text = n4.ToString();
            n5 = Convert.ToInt32(txttss.Text) + Convert.ToInt32(txtpss.Text);
            lbltss.Text = n5.ToString();
            n6 = Convert.ToInt32(txttd.Text) + Convert.ToInt32(txtpd.Text);
            lbltd.Text = n6.ToString();

            total = n1 + n2 + n3 + n4 + n5 + n6;
            lblt.Text = total.ToString();

             int A,B,C,D,E,F;
            A = Convert.ToInt32(lblth.Text);
             if(A  >= 80 && A<=100 )
            { lblgh.Text = "A+"; }
            else if (A <=79 && A>= 70)
            { lblgh.Text = "A"; }
            else if (A <= 69 && A >= 60)
            { lblgh.Text = "B"; }
            else if (A <= 59 && A >= 50)
            { lblgh.Text = "C"; }
            else if (A <= 49 && A >= 40)
            { lblgh.Text = "D"; }
            else if (A <= 39 && A >= 33)
            { lblgh.Text = "Fail"; }
              B = Convert.ToInt32(lblte.Text);
              if (B >= 80 && B <= 100)
            { lblge.Text = "A+"; }
            else if (B <= 79 && B >= 70)
            { lblge.Text = "A"; }
            else if (B <= 69 && B >= 60)
            { lblge.Text = "B"; }
            else if (B <= 59 && B >= 50)
            { lblge.Text = "C"; }
            else if (B <= 49 && B >= 40)
            { lblge.Text = "D"; }
            else if (B <= 39 && B >= 33)
            { lblge.Text = "Fail"; }
             C = Convert.ToInt32(lbltm.Text);
             if (C >= 80 && C <= 100)
            { lblgm.Text = "A+"; }
            else if (C <= 79 && C >= 70)
            { lblgm.Text = "A"; }
            else if (C <= 69 && C>= 60)
            { lblgm.Text = "B"; }
            else if (C <= 59 && C >= 50)
            { lblgm.Text = "C"; }
            else if (C <= 49 && C >= 40)
            { lblgm.Text = "D"; }
            else if (C <= 39 && C >= 33)
            { lblgm.Text = "Fail"; }
            D = Convert.ToInt32(lbltsc.Text);
              if (D >= 80 && D <= 100)
            { lblgsc.Text = "A+"; }
            else if (D <= 79 && D >= 70)
            { lblgsc.Text = "A"; }
            else if (D <= 69 && D >= 60)
            { lblgsc.Text = "B"; }
            else if (D <= 59 && D >= 50)
            { lblgsc.Text = "C"; }
            else if (D <= 49 && D >= 40)
            { lblgsc.Text = "D"; }
            else if (D <= 39 && D >= 33)
            { lblgsc.Text = "Fail"; }
             E = Convert.ToInt32(lbltss.Text);
             if (E >= 80 && E <= 100)
            { lblgss.Text = "A+"; }
            else if (E <= 79 && E >= 70)
            { lblgss.Text = "A"; }
            else if (E <= 69 && E >= 60)
            { lblgss.Text = "B"; }
            else if (E <= 59 && E >= 50)
            { lblgss.Text = "C"; }
            else if (E <= 49 && E >= 40)
            { lblgss.Text = "D"; }
            else if (E <= 39 && E >= 33)
            { lblgss.Text = "Fail"; }
              F = Convert.ToInt32(lbltd.Text);
             if (F >= 80 && F <= 100)
            { lblgd.Text = "A+"; }
            else if (F <= 79 && F >= 70)
            { lblgd.Text = "A"; }
            else if (F <= 69 && F >= 60)
            { lblgd.Text = "B"; }
            else if (F <= 59 && F >= 50)
            { lblgd.Text = "C"; }
            else if (F <= 49 && F >= 40)
            { lblgd.Text = "D"; }
            else if (F <= 39 && F >= 33)
            { lblgss.Text = "Fail"; }

            
       }



        private void Insert_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\dell\onedrive\documents\visual studio 2012\Projects\MarksSheet\MarksSheet\MarksData.mdf;Integrated Security=True");
       
            con.Open();
            
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "INSERT INTO Marks VALUES('" + txtroll.Text + "','" + txtcerti.Text + "','" + txtsn.Text + "','" + txtfn.Text + "','" + txtmn.Text + "','" + dateTime.Text + "','" + txtschool.Text + "'," + lblth.Text + "," + lblte.Text + "," + lbltm.Text + "," + lbltsc.Text + "," + lbltss.Text + "," + lbltd.Text + "," + lblmm.Text + "," + lblt.Text + ")";
                cmd1.ExecuteNonQuery();

            con.Close();
        }
              private void label1_Click(object sender, EventArgs e)
        {

        }
              private void label7_Click(object sender, EventArgs e)
              {

              }

              private void label5_Click(object sender, EventArgs e)
              {

              }

              private void textBox1_TextChanged(object sender, EventArgs e)
              {

              }

              private void button11_Click(object sender, EventArgs e)
              {
                  First ol = new First();
                  ol.Show();
                  this.Hide();
              }
    }
}
