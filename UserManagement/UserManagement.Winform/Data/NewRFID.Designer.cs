namespace UserManagement.Winform.Data
{
    partial class NewRFID
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
            this.txtDeviceNo = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDeviceNo
            // 
            this.txtDeviceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceNo.Location = new System.Drawing.Point(232, 185);
            this.txtDeviceNo.Name = "txtDeviceNo";
            this.txtDeviceNo.Size = new System.Drawing.Size(260, 29);
            this.txtDeviceNo.TabIndex = 0;
            // 
            // cboDevice
            // 
            this.cboDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(232, 112);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(233, 32);
            this.cboDevice.TabIndex = 1;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // NewRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.txtDeviceNo);
            this.Name = "NewRFID";
            this.Text = "NewRFID";
            this.Load += new System.EventHandler(this.NewRFID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeviceNo;
        private System.Windows.Forms.ComboBox cboDevice;
    }
}