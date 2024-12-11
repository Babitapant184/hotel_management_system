using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_M
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            query = "select username,pass from employee where username='"+txt_user.Text+"' and pass='"+txt_pass.Text+"' ";
            DataSet ds = fn.getData(query, "");


            if (ds.Tables[0].Rows.Count !=0)
            {
                label_error.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                label_error.Visible = true;
                txt_pass.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
