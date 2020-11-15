namespace UserManagement.Winform.Roles
{
    partial class CreateRole
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
            this.tabControlCreateRole = new System.Windows.Forms.TabControl();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtRoleDesc = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.tabPermissions = new System.Windows.Forms.TabPage();
            this.treeViewPermissions = new System.Windows.Forms.TreeView();
            this.tabControlCreateRole.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.tabPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCreateRole
            // 
            this.tabControlCreateRole.Controls.Add(this.tabRole);
            this.tabControlCreateRole.Controls.Add(this.tabPermissions);
            this.tabControlCreateRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCreateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCreateRole.Location = new System.Drawing.Point(0, 0);
            this.tabControlCreateRole.Name = "tabControlCreateRole";
            this.tabControlCreateRole.SelectedIndex = 0;
            this.tabControlCreateRole.Size = new System.Drawing.Size(800, 450);
            this.tabControlCreateRole.TabIndex = 0;
            // 
            // tabRole
            // 
            this.tabRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabRole.Controls.Add(this.btnCancel);
            this.tabRole.Controls.Add(this.btnSave);
            this.tabRole.Controls.Add(this.lblDescription);
            this.tabRole.Controls.Add(this.txtRoleDesc);
            this.tabRole.Controls.Add(this.lblRoleName);
            this.tabRole.Controls.Add(this.txtRoleName);
            this.tabRole.Location = new System.Drawing.Point(4, 34);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(792, 412);
            this.tabRole.TabIndex = 0;
            this.tabRole.Text = "Role";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 48);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(165, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // txtRoleDesc
            // 
            this.txtRoleDesc.Location = new System.Drawing.Point(278, 117);
            this.txtRoleDesc.Multiline = true;
            this.txtRoleDesc.Name = "txtRoleDesc";
            this.txtRoleDesc.Size = new System.Drawing.Size(338, 120);
            this.txtRoleDesc.TabIndex = 8;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(165, 20);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(118, 25);
            this.lblRoleName.TabIndex = 7;
            this.lblRoleName.Text = "RoleName:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(323, 17);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(224, 31);
            this.txtRoleName.TabIndex = 6;
            // 
            // tabPermissions
            // 
            this.tabPermissions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPermissions.Controls.Add(this.treeViewPermissions);
            this.tabPermissions.Location = new System.Drawing.Point(4, 34);
            this.tabPermissions.Name = "tabPermissions";
            this.tabPermissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermissions.Size = new System.Drawing.Size(792, 412);
            this.tabPermissions.TabIndex = 1;
            this.tabPermissions.Text = "Permissions";
            // 
            // treeViewPermissions
            // 
            this.treeViewPermissions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewPermissions.CheckBoxes = true;
            this.treeViewPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPermissions.Location = new System.Drawing.Point(3, 3);
            this.treeViewPermissions.Name = "treeViewPermissions";
            this.treeViewPermissions.Size = new System.Drawing.Size(786, 406);
            this.treeViewPermissions.TabIndex = 0;
            this.treeViewPermissions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermissions_AfterCheck);
            // 
            // CreateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCreateRole);
            this.Name = "CreateRole";
            this.Text = "CreateRole";
            this.Load += new System.EventHandler(this.CreateRole_Load);
            this.tabControlCreateRole.ResumeLayout(false);
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            this.tabPermissions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCreateRole;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabPermissions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtRoleDesc;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TreeView treeViewPermissions;
    }
}