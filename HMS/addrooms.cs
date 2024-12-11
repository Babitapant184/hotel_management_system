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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        private object ds;
       
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_roomNo.Text != "" && txt_type.Text != "" && txt_bed.Text != "" && txt_price.Text != "")
            {
                String roomno = txt_roomNo.Text;
                string roomnum = @"^\d{10}$";

                // Validate mobile number
                if (!Regex.IsMatch(roomno, roomnum))
                {
                    MessageBox.Show("Please enter a valid number.");
                    return; // Exit the method if the mobile number is invalid
                }

                String type = txt_type.Text;
                String bed = txt_bed.Text;
                Int64 price = Int64.Parse(txt_price.Text);

                query = "insert into H_room(roomNo, roomType, bed, price) values('" + roomno + "', '" + type + "', '" + bed + "', " + price + ")";
                fn.getData(query, "Room Added.");
                MessageBox.Show("Room Added.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                UC_AddRoom_Load(this,null);

            }
            else
            {
                MessageBox.Show("Fill All Fields. ", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void clearAll()
        {
            txt_roomNo.Clear();
            txt_type.SelectedIndex = -1;
            txt_bed.SelectedIndex = -1;
            txt_price.Clear();
        }


        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from H_room";
            DataSet ds = fn.getData(query,"");
            DataGridView1.DataSource = ds.Tables[0];


        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

            
                // Try to parse the text in the txt_price TextBox to a decimal
                if (decimal.TryParse(txt_price.Text, out decimal price))
                {
                    // Check if the price is less than zero
                    if (price < 0)
                    {
                        // Display a message to the user
                        MessageBox.Show("Cannot add negative price value.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Optionally, you can clear the TextBox or set it to a default value
                        txt_price.Text = string.Empty; // Clear the TextBox
                    }
                }
                else
                {
                    // Optionally handle the case where the input is not a valid decimal
                    // For example, you can show a message or clear the TextBox
                    MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
    }
}
