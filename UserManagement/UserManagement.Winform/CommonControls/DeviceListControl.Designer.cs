namespace UserManagement.Winform.CommonControls
{
    partial class DeviceListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AllowUserToDeleteRows = false;
            this.dgvDeviceList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeviceList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceList.Location = new System.Drawing.Point(0, 0);
            this.dgvDeviceList.MultiSelect = false;
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.ReadOnly = true;
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceList.Size = new System.Drawing.Size(858, 456);
            this.dgvDeviceList.TabIndex = 0;
            this.dgvDeviceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeviceList_CellContentClick);
            this.dgvDeviceList.VisibleChanged += new System.EventHandler(this.dgvDeviceList_VisibleChanged);
            // 
            // DeviceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgvDeviceList);
            this.Name = "DeviceListControl";
            this.Size = new System.Drawing.Size(858, 456);
            this.Load += new System.EventHandler(this.DeviceListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeviceList;
    }
}
