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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            moving_panel.Left=btn_reg.Left+18;
            uC_CustomerReg1.Visible = true;

            uC_CustomerReg1.BringToFront();

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
            moving_panel.Left = btn_details.Left+18;
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            moving_panel.Left=btn_add.Left+18;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            uC_CheckOut1.Visible= true;
            uC_CheckOut1.BringToFront();
            moving_panel.Left =btn_checkout.Left+18;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            moving_panel.Left=btn_emp.Left+18;
            uC_Employee1.Visible= true;
            uC_Employee1.BringToFront();
               
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            btn_add.PerformClick();
           uC_CustomerReg1.Visible=false;    
            uC_Employee1.Visible = false;

        }

        private void uC_CustomerReg1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerReg1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
