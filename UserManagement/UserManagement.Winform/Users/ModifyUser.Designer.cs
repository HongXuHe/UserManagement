namespace UserManagement.Winform.Users
{
    partial class ModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
            this.tabUserFrom = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnResetPwd = new System.Windows.Forms.Button();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.dtEffectDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblEffectDate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.chcListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPermission = new System.Windows.Forms.TabPage();
            this.treeViewPermission = new System.Windows.Forms.TreeView();
            this.tabUserFrom.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.tabPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUserFrom
            // 
            this.tabUserFrom.Controls.Add(this.tabUser);
            this.tabUserFrom.Controls.Add(this.tabRole);
            this.tabUserFrom.Controls.Add(this.tabPermission);
            this.tabUserFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUserFrom.Location = new System.Drawing.Point(0, 0);
            this.tabUserFrom.Name = "tabUserFrom";
            this.tabUserFrom.SelectedIndex = 0;
            this.tabUserFrom.Size = new System.Drawing.Size(690, 450);
            this.tabUserFrom.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabUser.Controls.Add(this.btnResetPwd);
            this.tabUser.Controls.Add(this.dtExpireDate);
            this.tabUser.Controls.Add(this.dtEffectDate);
            this.tabUser.Controls.Add(this.btnCancel);
            this.tabUser.Controls.Add(this.btnSave);
            this.tabUser.Controls.Add(this.txtDesc);
            this.tabUser.Controls.Add(this.lblDes);
            this.tabUser.Controls.Add(this.lblExpireDate);
            this.tabUser.Controls.Add(this.lblEffectDate);
            this.tabUser.Controls.Add(this.txtPhone);
            this.tabUser.Controls.Add(this.lblPhone);
            this.tabUser.Controls.Add(this.txtEmail);
            this.tabUser.Controls.Add(this.lblEmail);
            this.tabUser.Controls.Add(this.txtUserName);
            this.tabUser.Controls.Add(this.lblUserName);
            this.tabUser.Location = new System.Drawing.Point(4, 34);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(682, 412);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPwd.Location = new System.Drawing.Point(23, 347);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(151, 40);
            this.btnResetPwd.TabIndex = 18;
            this.btnResetPwd.Text = "ResetPassword";
            this.btnResetPwd.UseVisualStyleBackColor = true;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.CustomFormat = "";
            this.dtExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpireDate.Location = new System.Drawing.Point(502, 86);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(135, 29);
            this.dtExpireDate.TabIndex = 15;
            // 
            // dtEffectDate
            // 
            this.dtEffectDate.CustomFormat = "";
            this.dtEffectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEffectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEffectDate.Location = new System.Drawing.Point(504, 35);
            this.dtEffectDate.Name = "dtEffectDate";
            this.dtEffectDate.Size = new System.Drawing.Size(135, 29);
            this.dtEffectDate.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(476, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(235, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(172, 226);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(351, 96);
            this.txtDesc.TabIndex = 11;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(277, 190);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(109, 24);
            this.lblDes.TabIndex = 10;
            this.lblDes.Text = "Description:";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(376, 88);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(108, 24);
            this.lblExpireDate.TabIndex = 8;
            this.lblExpireDate.Text = "ExpireDate:";
            // 
            // lblEffectDate
            // 
            this.lblEffectDate.AutoSize = true;
            this.lblEffectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectDate.Location = new System.Drawing.Point(376, 33);
            this.lblEffectDate.Name = "lblEffectDate";
            this.lblEffectDate.Size = new System.Drawing.Size(99, 24);
            this.lblEffectDate.TabIndex = 6;
            this.lblEffectDate.Text = "EffectDate:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(181, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 29);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(53, 145);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(181, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(53, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(181, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 29);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(53, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 24);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName:";
            // 
            // tabRole
            // 
            this.tabRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabRole.Controls.Add(this.chcListBox);
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(682, 424);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Roles";
            // 
            // chcListBox
            // 
            this.chcListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chcListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chcListBox.FormattingEnabled = true;
            this.chcListBox.Location = new System.Drawing.Point(3, 3);
            this.chcListBox.Name = "chcListBox";
            this.chcListBox.Size = new System.Drawing.Size(676, 418);
            this.chcListBox.TabIndex = 0;
            // 
            // tabPermission
            // 
            this.tabPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPermission.Controls.Add(this.treeViewPermission);
            this.tabPermission.Location = new System.Drawing.Point(4, 34);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.Size = new System.Drawing.Size(682, 412);
            this.tabPermission.TabIndex = 2;
            this.tabPermission.Text = "Permissions";
            // 
            // treeViewPermission
            // 
            this.treeViewPermission.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewPermission.CheckBoxes = true;
            this.treeViewPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewPermission.Location = new System.Drawing.Point(0, 0);
            this.treeViewPermission.Name = "treeViewPermission";
            this.treeViewPermission.Size = new System.Drawing.Size(682, 412);
            this.treeViewPermission.TabIndex = 0;
            this.treeViewPermission.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermission_AfterCheck);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.tabUserFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.tabUserFrom.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabRole.ResumeLayout(false);
            this.tabPermission.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUserFrom;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabPermission;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblEffectDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtEffectDate;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.CheckedListBox chcListBox;
        private System.Windows.Forms.TreeView treeViewPermission;
        private System.Windows.Forms.Button btnResetPwd;
    }
}