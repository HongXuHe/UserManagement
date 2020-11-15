namespace UserManagement.Winform.Roles
{
    partial class ModifyRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyRole));
            this.tabControlModifyRole = new System.Windows.Forms.TabControl();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtRoleDesc = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.tabPermission = new System.Windows.Forms.TabPage();
            this.treeViewPermission = new System.Windows.Forms.TreeView();
            this.tabControlModifyRole.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.tabPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlModifyRole
            // 
            this.tabControlModifyRole.Controls.Add(this.tabRole);
            this.tabControlModifyRole.Controls.Add(this.tabPermission);
            this.tabControlModifyRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlModifyRole.Location = new System.Drawing.Point(0, 0);
            this.tabControlModifyRole.Name = "tabControlModifyRole";
            this.tabControlModifyRole.SelectedIndex = 0;
            this.tabControlModifyRole.Size = new System.Drawing.Size(809, 511);
            this.tabControlModifyRole.TabIndex = 0;
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
            this.tabRole.Size = new System.Drawing.Size(801, 473);
            this.tabRole.TabIndex = 0;
            this.tabRole.Text = "Role";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 48);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(154, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtRoleDesc
            // 
            this.txtRoleDesc.Location = new System.Drawing.Point(267, 153);
            this.txtRoleDesc.Multiline = true;
            this.txtRoleDesc.Name = "txtRoleDesc";
            this.txtRoleDesc.Size = new System.Drawing.Size(338, 120);
            this.txtRoleDesc.TabIndex = 2;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(154, 56);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(118, 25);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "RoleName:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(312, 53);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(224, 31);
            this.txtRoleName.TabIndex = 0;
            // 
            // tabPermission
            // 
            this.tabPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPermission.Controls.Add(this.treeViewPermission);
            this.tabPermission.Location = new System.Drawing.Point(4, 34);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermission.Size = new System.Drawing.Size(801, 473);
            this.tabPermission.TabIndex = 1;
            this.tabPermission.Text = "Permissions";
            // 
            // treeViewPermission
            // 
            this.treeViewPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeViewPermission.CheckBoxes = true;
            this.treeViewPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPermission.Location = new System.Drawing.Point(3, 3);
            this.treeViewPermission.Name = "treeViewPermission";
            this.treeViewPermission.Size = new System.Drawing.Size(795, 467);
            this.treeViewPermission.TabIndex = 0;
            this.treeViewPermission.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermission_AfterCheck);
            // 
            // ModifyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.tabControlModifyRole);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModifyRole";
            this.Text = "ModifyRole";
            this.Load += new System.EventHandler(this.ModifyRole_Load);
            this.tabControlModifyRole.ResumeLayout(false);
            this.tabRole.ResumeLayout(false);
            this.tabRole.PerformLayout();
            this.tabPermission.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlModifyRole;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabPermission;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtRoleDesc;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TreeView treeViewPermission;
    }
}