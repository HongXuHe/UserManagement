namespace UserManagement.Winform.Devices
{
    partial class ModifyDevice
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
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.txtDataBits = new System.Windows.Forms.NumericUpDown();
            this.txtBaudRate = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.cboCom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStopBits
            // 
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(415, 493);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(6);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(233, 33);
            this.cboStopBits.TabIndex = 34;
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(415, 418);
            this.txtDataBits.Maximum = new decimal(new int[] {
            115230,
            0,
            0,
            0});
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(233, 31);
            this.txtDataBits.TabIndex = 33;
            this.txtDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(415, 268);
            this.txtBaudRate.Maximum = new decimal(new int[] {
            115230,
            0,
            0,
            0});
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(233, 31);
            this.txtBaudRate.TabIndex = 32;
            this.txtBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(846, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 57);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(452, 616);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 57);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(781, 176);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(449, 321);
            this.txtDescription.TabIndex = 29;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(776, 108);
            this.lblDes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(126, 25);
            this.lblDes.TabIndex = 28;
            this.lblDes.Text = "Description:";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(221, 493);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(98, 25);
            this.lblStopBits.TabIndex = 27;
            this.lblStopBits.Text = "StopBits:";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(221, 418);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(99, 25);
            this.lblDataBits.TabIndex = 26;
            this.lblDataBits.Text = "DataBits:";
            // 
            // cboParity
            // 
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(415, 340);
            this.cboParity.Margin = new System.Windows.Forms.Padding(6);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(233, 33);
            this.cboParity.TabIndex = 25;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(221, 343);
            this.lblParity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(73, 25);
            this.lblParity.TabIndex = 24;
            this.lblParity.Text = "Parity:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(221, 268);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(113, 25);
            this.lblBaudRate.TabIndex = 23;
            this.lblBaudRate.Text = "BaudRate:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(415, 188);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(233, 31);
            this.txtDevice.TabIndex = 22;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(221, 193);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(140, 25);
            this.lblDevice.TabIndex = 21;
            this.lblDevice.Text = "DeviceName:";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(221, 118);
            this.lblCom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(67, 25);
            this.lblCom.TabIndex = 20;
            this.lblCom.Text = "COM:";
            // 
            // cboCom
            // 
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(415, 110);
            this.cboCom.Margin = new System.Windows.Forms.Padding(6);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(233, 33);
            this.cboCom.TabIndex = 19;
            // 
            // ModifyDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1412, 730);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblStopBits);
            this.Controls.Add(this.lblDataBits);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.lblParity);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.cboCom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ModifyDevice";
            this.Text = "ModifyDevice";
            this.Load += new System.EventHandler(this.ModifyDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.NumericUpDown txtDataBits;
        private System.Windows.Forms.NumericUpDown txtBaudRate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ComboBox cboCom;
    }
}