using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using NPOI.OpenXmlFormats.Dml;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;







namespace H_M.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
           getMaxID(); 

        }


        private void tab_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_emp.SelectedIndex == 1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query, "");
                DataGridView.DataSource = ds.Tables[0];

            }
            else if (tab_emp.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query, "");
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }



        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ;
                }

                {
                    query = "delete from employee where eid='" + txt_id.Text + "'";
                    fn.getData(query, "Record Deleted");

                    MessageBox.Show("Record Deleted", "Information...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tab_emp_SelectedIndexChanged(this, null);
                }
            }
        }


        //           ================================Required ===============================================
        public void getMaxID()
        {
            query = "Select max(eid) from employee";
            DataSet ds = fn.getData(query, "");

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num +1).ToString();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txt_name.Text!=""&& txt_mobile.Text!=""&& txt_Gender.Text!="" && txt_mail.Text!="" && txt_uname.Text!="" && txt_uname.Text!="" && txt_pass.Text!="")
            {
                String name=txt_name.Text;
                Int64 mobile=Int64.Parse(txt_mobile.Text);
                string mobilePattern = @"^\d{10}$"; // Regex for 10 digit mobile number

                if (!Regex.IsMatch(txt_mobile.Text, mobilePattern))
                {
                    MessageBox.Show( "Mobile number is incorrect. Please enter a 10-digit mobile number.");
                    return; // Exit the method if mobile number is invalid
                }
                String gender =txt_Gender.Text;
                String mail =txt_mail.Text;
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email regex pattern

                if (!Regex.IsMatch(txt_mail.Text, emailPattern))
                {
                    MessageBox.Show ( "Invalid email address. Please enter a valid email.");
                    return; // Exit the method if email is invalid
                }

                String username =txt_uname.Text;
                String pass =txt_pass.Text;

                query = "insert into employee(ename,mobile,gender,emailid,username,pass) values('" + name + "'," + mobile + ",'" + gender + "','" + mail + "','" + username + "','" + pass + "')";
                fn.getData(query,"Employee Registered");
                MessageBox.Show("Employee Registered", "Information...!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill All Fields.","Warning...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        
            

            }

        public void clearAll()
        {
            txt_name.Clear();
            txt_mobile.Clear();
            txt_Gender.SelectedIndex = -1;
            txt_mail.Clear();   
            txt_uname.Clear();
            txt_pass.Clear();   
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void labelToSet_Click(object sender, EventArgs e)
        {

        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
