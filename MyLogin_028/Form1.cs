using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TEST GITHUB

namespace MyLogin_028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.username == txtUsername.Text select s).First();
            if (user.password == txtPassword.Text)
            {
                this.Hide();
                Form2 a = new Form2();
                a.Show();
            }
            else
            {
                MessageBox.Show("Password Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}