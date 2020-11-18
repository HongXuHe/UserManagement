namespace UserManagement.Winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnData = new System.Windows.Forms.ToolStripDropDownButton();
            this.newRFIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDevice = new System.Windows.Forms.ToolStripDropDownButton();
            this.deviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIdentity = new System.Windows.Forms.ToolStripDropDownButton();
            this.individualUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolbox = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtWeight = new System.Windows.Forms.ToolStripTextBox();
            this.btnLogoff = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUser = new System.Windows.Forms.ToolStripLabel();
            this.plMain = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBar
            // 
            this.tsBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.tsBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.toolStripSeparator1,
            this.btnData,
            this.toolStripSeparator2,
            this.btnDevice,
            this.toolStripSeparator3,
            this.btnIdentity,
            this.toolStripSeparator4,
            this.btnToolbox,
            this.toolStripSeparator5,
            this.txtWeight,
            this.btnLogoff,
            this.toolStripSeparator6,
            this.txtUser});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsBar.Name = "tsBar";
            this.tsBar.Padding = new System.Windows.Forms.Padding(0);
            this.tsBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBar.Size = new System.Drawing.Size(784, 64);
            this.tsBar.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::UserManagement.Winform.Properties.Resources.home_32x32;
            this.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnHome.Size = new System.Drawing.Size(44, 61);
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // btnData
            // 
            this.btnData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRFIDToolStripMenuItem});
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(45, 61);
            this.btnData.Text = "Data";
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newRFIDToolStripMenuItem
            // 
            this.newRFIDToolStripMenuItem.Name = "newRFIDToolStripMenuItem";
            this.newRFIDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newRFIDToolStripMenuItem.Text = "NewRFID";
            this.newRFIDToolStripMenuItem.Click += new System.EventHandler(this.newRFIDToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // btnDevice
            // 
            this.btnDevice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceListToolStripMenuItem,
            this.newDeviceToolStripMenuItem});
            this.btnDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.Image")));
            this.btnDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(55, 61);
            this.btnDevice.Text = "Device";
            this.btnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // deviceListToolStripMenuItem
            // 
            this.deviceListToolStripMenuItem.Name = "deviceListToolStripMenuItem";
            this.deviceListToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deviceListToolStripMenuItem.Text = "DeviceList";
            this.deviceListToolStripMenuItem.Click += new System.EventHandler(this.deviceListToolStripMenuItem_Click);
            // 
            // newDeviceToolStripMenuItem
            // 
            this.newDeviceToolStripMenuItem.Name = "newDeviceToolStripMenuItem";
            this.newDeviceToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newDeviceToolStripMenuItem.Text = "NewDevice";
            this.newDeviceToolStripMenuItem.Click += new System.EventHandler(this.newDeviceToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // btnIdentity
            // 
            this.btnIdentity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualUsersToolStripMenuItem,
            this.createUserToolStripMenuItem,
            this.userRolesToolStripMenuItem,
            this.newRoleToolStripMenuItem});
            this.btnIdentity.Image = ((System.Drawing.Image)(resources.GetObject("btnIdentity.Image")));
            this.btnIdentity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIdentity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIdentity.Name = "btnIdentity";
            this.btnIdentity.Size = new System.Drawing.Size(60, 61);
            this.btnIdentity.Text = "Identity";
            this.btnIdentity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // individualUsersToolStripMenuItem
            // 
            this.individualUsersToolStripMenuItem.Name = "individualUsersToolStripMenuItem";
            this.individualUsersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.individualUsersToolStripMenuItem.Text = "Users";
            this.individualUsersToolStripMenuItem.Click += new System.EventHandler(this.individualUsersToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.createUserToolStripMenuItem.Text = "New User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // userRolesToolStripMenuItem
            // 
            this.userRolesToolStripMenuItem.Name = "userRolesToolStripMenuItem";
            this.userRolesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.userRolesToolStripMenuItem.Text = "Roles";
            this.userRolesToolStripMenuItem.Click += new System.EventHandler(this.userRolesToolStripMenuItem_Click);
            // 
            // newRoleToolStripMenuItem
            // 
            this.newRoleToolStripMenuItem.Name = "newRoleToolStripMenuItem";
            this.newRoleToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newRoleToolStripMenuItem.Text = "New Role";
            this.newRoleToolStripMenuItem.Click += new System.EventHandler(this.newRoleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 64);
            // 
            // btnToolbox
            // 
            this.btnToolbox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportRecordsToolStripMenuItem,
            this.backUpFrequencyToolStripMenuItem});
            this.btnToolbox.Image = ((System.Drawing.Image)(resources.GetObject("btnToolbox.Image")));
            this.btnToolbox.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolbox.Name = "btnToolbox";
            this.btnToolbox.Size = new System.Drawing.Size(63, 61);
            this.btnToolbox.Text = "Toolbox";
            this.btnToolbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exportRecordsToolStripMenuItem
            // 
            this.exportRecordsToolStripMenuItem.Name = "exportRecordsToolStripMenuItem";
            this.exportRecordsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exportRecordsToolStripMenuItem.Text = "Export Records";
            // 
            // backUpFrequencyToolStripMenuItem
            // 
            this.backUpFrequencyToolStripMenuItem.Name = "backUpFrequencyToolStripMenuItem";
            this.backUpFrequencyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.backUpFrequencyToolStripMenuItem.Text = "BackUp Frequency";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 64);
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(130, 64);
            this.txtWeight.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogoff.ForeColor = System.Drawing.Color.Red;
            this.btnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoff.Image")));
            this.btnLogoff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogoff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(48, 61);
            this.btnLogoff.Text = "LogOff";
            this.btnLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 64);
            // 
            // txtUser
            // 
            this.txtUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtUser.Enabled = false;
            this.txtUser.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtUser.Name = "txtUser";
            this.txtUser.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.txtUser.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.txtUser.Size = new System.Drawing.Size(77, 61);
            this.txtUser.Text = "UserName";
            // 
            // plMain
            // 
            this.plMain.AutoSize = true;
            this.plMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 64);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(784, 498);
            this.plMain.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 542);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(784, 20);
            this.textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.tsBar);
            this.ForeColor = System.Drawing.Color.Blue;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NWI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnDevice;
        private System.Windows.Forms.ToolStripMenuItem deviceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnIdentity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton btnToolbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox txtWeight;
        private System.Windows.Forms.ToolStripLabel txtUser;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.ToolStripMenuItem individualUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpFrequencyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton btnLogoff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRFIDToolStripMenuItem;
    }
}

