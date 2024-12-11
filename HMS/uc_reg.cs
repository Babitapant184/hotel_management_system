using Microsoft.VisualBasic;
using NPOI.OpenXmlFormats.Dml.Diagram;
using NPOI.OpenXmlFormats.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_M.All_User_Control
{
    public partial class UC_CustomerReg : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerReg()
        {
            InitializeComponent();
        }
        public void setComboBox(String query,ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            { 
            for(int i=0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));  
                }
            
            }
            sdr.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from H_room where bed='" + cmbBed.Text + "'and roomType='" + cmbType.Text + "'and booked='NO'";
            setComboBox(query,cmbNo);
        }

        private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = -1;
            cmbNo.Items.Clear();
            txtPrice.Clear();
        }
        int rid;
        private void cmbNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from H_room where roomNo='"+cmbNo.Text+"'";
            DataSet ds = fn.getData(query,"");
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtNation.Text != "" && cmbGender.Text != ""&& txtAddress.Text != "" && dtpDOB.Text != ""&& dtpCheckin.Text != "" && txtID.Text != ""&&txtPrice.Text!=""  )
            {
                String name= txtName.Text;
               

                // Regex pattern for validating a name with only alphabetic characters and spaces
                string namePattern = @"^[a-zA-Z\s]+$";

                // Validate name
                if (!Regex.IsMatch(name, namePattern))
                {
                    MessageBox.Show("Name is incorrect. Please enter a valid name containing only letters.");
                    return; // Exit the method if the name is invalid
                }

                Int64 mobile=Int64.Parse(txtMobile.Text);
                string mobileNumber = txtMobile.Text; // Assuming txt_mobile is the input field for mobile number

                // Regex pattern for validating a 10-digit mobile number
                string mobilePattern = @"^\d{10}$";

                // Validate mobile number
                if (!Regex.IsMatch(mobileNumber, mobilePattern))
                {
                    MessageBox.Show( "Mobile number is incorrect. Please enter a valid 10-digit mobile number.");
                    return; // Exit the method if the mobile number is invalid
                }

                String nationality =txtNation.Text;
               

                // Regex pattern for validating a name with only alphabetic characters and spaces
                string nation = @"^[a-zA-Z\s]+$";

                // Validate name
                if (!Regex.IsMatch(nationality, nation))
                {
                    MessageBox.Show("Name is incorrect. Please enter a valid name containing only letters.");
                    return; // Exit the method if the name is invalid
                }
                String gender=cmbGender.Text;
                String DOB =dtpDOB.Text;
                String CheckIn=dtpCheckin.Text;
                String Address=txtAddress.Text;
                

                // Regex pattern for validating a name with only alphabetic characters and spaces
                string address = @"^[a-zA-Z\s]+$";

                // Validate name
                if (!Regex.IsMatch(Address, address))
                {
                    MessageBox.Show("Name is incorrect. Please enter a valid name containing only letters.");
                    return; // Exit the method if the name is invalid
                }
                String ID=txtID.Text;
                

                // Regex pattern for validating a name with only alphabetic characters and spaces
                string id = @"^[a-zA-Z\s]+$";

                // Validate name
                if (!Regex.IsMatch(ID, id))
                {
                    MessageBox.Show("Name is incorrect. Please enter a valid name containing only letters.");
                    return; // Exit the method if the name is invalid
                }

                query = "insert into customer(cname,mobile,nationality,gender,dob,idproof,addres,checkin,roomid) values ('"+name+ "','"+mobile+"','"+gender+"','"+nationality+"','"+DOB+"','"+Address+ "','"+ID+ "','"+CheckIn+"','"+rid+"') update H_room set booked='YES' where roomNo ='"+cmbNo.Text+"'";
                fn.getData(query,"Room No"+cmbNo.Text+"Allocation Successfull.");
                MessageBox.Show("Allocation Successfull.","Information!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                clearAll();
            }
            else
            {
                MessageBox.Show("All Fields are Mandatory","Information!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
       public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtNation.Clear();
            txtAddress.Clear();
            txtID.Clear();
            cmbGender.SelectedIndex = -1;
            cmbNo.Items.Clear();
            txtPrice.Clear();
            dtpDOB.ResetText();
            dtpCheckin.ResetText();
            cmbType.SelectedIndex = -1;
            cmbBed.SelectedIndex = -1;
        }

        private void UC_CustomerReg_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerReg_Load(object sender, EventArgs e)
        {

        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
