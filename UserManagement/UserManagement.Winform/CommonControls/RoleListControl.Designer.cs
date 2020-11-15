namespace UserManagement.Winform.CommonControls
{
    partial class RoleListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRoleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.AllowUserToAddRows = false;
            this.dgvRoleList.AllowUserToDeleteRows = false;
            this.dgvRoleList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoleList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoleList.Location = new System.Drawing.Point(0, 0);
            this.dgvRoleList.MultiSelect = false;
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.ReadOnly = true;
            this.dgvRoleList.RowHeadersVisible = false;
            this.dgvRoleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleList.Size = new System.Drawing.Size(926, 605);
            this.dgvRoleList.TabIndex = 0;
            this.dgvRoleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleList_CellContentClick);
            this.dgvRoleList.VisibleChanged += new System.EventHandler(this.dgvRoleList_VisibleChanged);
            // 
            // RoleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgvRoleList);
            this.Name = "RoleListControl";
            this.Size = new System.Drawing.Size(926, 605);
            this.Load += new System.EventHandler(this.RoleListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoleList;
    }
}
