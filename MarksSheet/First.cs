using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksSheet
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }
         

        private void button3_Click(object sender, EventArgs e)
        {
            View obj = new View();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete jk = new Delete();
            jk.Show();
            this.Hide();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Create_New(object sender, EventArgs e)
        {
            New ob = new New();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update lk = new Update();
            lk.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
