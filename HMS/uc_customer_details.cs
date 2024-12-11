using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace H_M.All_User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        

        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,H_room.roomNo,H_room.roomType,H_room.bed,H_room.price from customer inner join H_room on customer.roomid=H_room.roomid";
                DataSet ds = fn.getData(query, "");
                DataGridView.DataSource = ds.Tables[0];
            }
            else if (txtSearch.SelectedIndex == 1) 
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,H_room.roomNo,H_room.roomType,H_room.bed,H_room.price from customer inner join H_room on customer.roomid=H_room.roomid where checkout is null";
                DataSet ds = fn.getData(query, "");
                DataGridView.DataSource = ds.Tables[0];
            }
            else if (txtSearch.SelectedIndex == 2)
            {
                query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.addres,customer.checkin,H_room.roomNo,H_room.roomType,H_room.bed,H_room.price from customer inner join H_room on customer.roomid=H_room.roomid where checkout is not null";
                DataSet ds = fn.getData(query, "");
                DataGridView.DataSource = ds.Tables[0];
            }
        }
    }
}
