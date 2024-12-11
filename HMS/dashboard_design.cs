namespace H_M
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.moving_panel = new System.Windows.Forms.Panel();
            this.btn_emp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_details = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reg = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_CustomerReg1 = new H_M.All_User_Control.UC_CustomerReg();
            this.uC_AddRoom1 = new H_M.All_User_Control.UC_AddRoom();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CheckOut1 = new H_M.All_User_Control.UC_CheckOut();
            this.uC_CustomerDetails1 = new H_M.All_User_Control.UC_CustomerDetails();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new H_M.All_User_Control.UC_Employee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.moving_panel);
            this.panel1.Controls.Add(this.btn_emp);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_checkout);
            this.panel1.Controls.Add(this.btn_details);
            this.panel1.Controls.Add(this.btn_reg);
            this.panel1.Location = new System.Drawing.Point(85, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1861, 200);
            this.panel1.TabIndex = 0;
            // 
            // moving_panel
            // 
            this.moving_panel.BackColor = System.Drawing.Color.Aqua;
            this.moving_panel.Location = new System.Drawing.Point(42, 162);
            this.moving_panel.Name = "moving_panel";
            this.moving_panel.Size = new System.Drawing.Size(292, 5);
            this.moving_panel.TabIndex = 0;
            // 
            // btn_emp
            // 
            this.btn_emp.BorderRadius = 26;
            this.btn_emp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_emp.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_emp.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_emp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_emp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp.ForeColor = System.Drawing.Color.White;
            this.btn_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp.Image")));
            this.btn_emp.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_emp.Location = new System.Drawing.Point(1497, 28);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(333, 138);
            this.btn_emp.TabIndex = 2;
            this.btn_emp.Text = "Employee";
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 26;
            this.btn_add.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_add.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_add.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_add.Location = new System.Drawing.Point(28, 29);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(333, 138);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Room";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BorderRadius = 26;
            this.btn_checkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_checkout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_checkout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkout.Image")));
            this.btn_checkout.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_checkout.Location = new System.Drawing.Point(1130, 29);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(333, 138);
            this.btn_checkout.TabIndex = 1;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_details
            // 
            this.btn_details.BorderRadius = 26;
            this.btn_details.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_details.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_details.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_details.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_details.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_details.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.ForeColor = System.Drawing.Color.White;
            this.btn_details.Image = ((System.Drawing.Image)(resources.GetObject("btn_details.Image")));
            this.btn_details.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_details.Location = new System.Drawing.Point(763, 29);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(333, 138);
            this.btn_details.TabIndex = 3;
            this.btn_details.Text = "Customer Details";
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.BorderRadius = 26;
            this.btn_reg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_reg.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_reg.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_reg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btn_reg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Image = ((System.Drawing.Image)(resources.GetObject("btn_reg.Image")));
            this.btn_reg.ImageSize = new System.Drawing.Size(45, 45);
            this.btn_reg.Location = new System.Drawing.Point(396, 29);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(333, 138);
            this.btn_reg.TabIndex = 4;
            this.btn_reg.Text = "Customer Registration";
            this.btn_reg.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerReg1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(85, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1845, 817);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_CustomerReg1
            // 
            this.uC_CustomerReg1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerReg1.ForeColor = System.Drawing.Color.Black;
            this.uC_CustomerReg1.Location = new System.Drawing.Point(4, 3);
            this.uC_CustomerReg1.Name = "uC_CustomerReg1";
            this.uC_CustomerReg1.Size = new System.Drawing.Size(1754, 784);
            this.uC_CustomerReg1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1755, 784);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Empty;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(38, 38);
            this.btn_Exit.Location = new System.Drawing.Point(25, 41);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Exit.Size = new System.Drawing.Size(45, 45);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.FillColor = System.Drawing.Color.Empty;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageSize = new System.Drawing.Size(38, 38);
            this.btn_minimize.Location = new System.Drawing.Point(25, 92);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_minimize.Size = new System.Drawing.Size(45, 45);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1758, 787);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(3, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1755, 787);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1758, 787);
            this.uC_Employee1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1942, 1063);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_reg;
        private Guna.UI2.WinForms.Guna2Button btn_details;
        private Guna.UI2.WinForms.Guna2Button btn_emp;
        private Guna.UI2.WinForms.Guna2Button btn_checkout;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2CircleButton btn_minimize;
        private System.Windows.Forms.Panel moving_panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomerReg uC_CustomerReg1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_CheckOut uC_CheckOut1;
        private All_User_Control.UC_CustomerDetails uC_CustomerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}