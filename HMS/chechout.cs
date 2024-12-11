using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_M.All_User_Control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        

        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,H_room.roomNo,H_room.roomType,H_room.bed,H_room.price from customer inner join H_room on customer.roomid=H_room.roomid where chekout='NO'" ;
            DataSet ds=fn.getData(query,"");
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,H_room.roomNo,H_room.roomType,H_room.bed,H_room.price from customer inner join H_room on customer.roomid=H_room.roomid where cname like  '"+txtName.Text+"%'and chekout='NO'  ";
            DataSet ds = fn.getData(query,query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Cname.Text =guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_roomNo.Text =guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txt_Cname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_roomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_Cname.Text != "")
            {
                if(MessageBox.Show("Are you Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK) 
                {
                    String cDate=txt_Checkout.Text;
                    query = "update customer set chekout='YES',checkout='" + cDate + "' where cid = " + id + " update H_room set booked='NO' where roomNo='" + txt_roomNo + "'";
                    fn.getData(query,"Check Out Successfully");
                    MessageBox.Show("Check Out Successfully", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_CheckOut_Load(this,null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txt_Cname.Clear();
            txtName.Clear();
            txt_roomNo.Clear();
            txt_Checkout.ResetText();
                
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txt_Checkout_ValueChanged(object sender, EventArgs e)
        {
            //// Assuming txt_Checkin and txt_Checkout are DateTimePicker controls
            //DateTime checkinDate = dtpCheckin.Value;
            //DateTime checkoutDate = txt_Checkout.Value;

            //// Check if the checkout date is before or the same as the check-in date
            //if (checkoutDate <= checkinDate)
            //{
            //    // Display a message to the user
            //    MessageBox.Show("Invalid date: Checkout date must be after the Check-in date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    // Optionally, you can reset the checkout date to a default value or clear the field
            //    txt_Checkout.Value = checkinDate.AddDays(1); // Set to one day after check-in
            }
        }
    }

