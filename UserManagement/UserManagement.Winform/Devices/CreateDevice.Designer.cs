namespace UserManagement.Winform.Devices
{
    partial class CreateDevice
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
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBaudRate = new System.Windows.Forms.NumericUpDown();
            this.txtDataBits = new System.Windows.Forms.NumericUpDown();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCom
            // 
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(401, 121);
            this.cboCom.Margin = new System.Windows.Forms.Padding(6);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(233, 33);
            this.cboCom.TabIndex = 0;
            this.cboCom.Click += new System.EventHandler(this.cboCom_Click);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(207, 129);
            this.lblCom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(67, 25);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "COM:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(207, 204);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(140, 25);
            this.lblDevice.TabIndex = 2;
            this.lblDevice.Text = "DeviceName:";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(401, 199);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(233, 31);
            this.txtDevice.TabIndex = 3;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(207, 279);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(113, 25);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "BaudRate:";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(207, 354);
            this.lblParity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(73, 25);
            this.lblParity.TabIndex = 6;
            this.lblParity.Text = "Parity:";
            // 
            // cboParity
            // 
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(401, 351);
            this.cboParity.Margin = new System.Windows.Forms.Padding(6);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(233, 33);
            this.cboParity.TabIndex = 7;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(207, 429);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(99, 25);
            this.lblDataBits.TabIndex = 8;
            this.lblDataBits.Text = "DataBits:";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(207, 504);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(98, 25);
            this.lblStopBits.TabIndex = 10;
            this.lblStopBits.Text = "StopBits:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(767, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(449, 321);
            this.txtDescription.TabIndex = 13;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(762, 119);
            this.lblDes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(126, 25);
            this.lblDes.TabIndex = 12;
            this.lblDes.Text = "Description:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(438, 627);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 57);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(832, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 57);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(401, 279);
            this.txtBaudRate.Maximum = new decimal(new int[] {
            115230,
            0,
            0,
            0});
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(233, 31);
            this.txtBaudRate.TabIndex = 16;
            this.txtBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(401, 429);
            this.txtDataBits.Maximum = new decimal(new int[] {
            115230,
            0,
            0,
            0});
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(233, 31);
            this.txtDataBits.TabIndex = 17;
            this.txtDataBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cboStopBits
            // 
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(401, 504);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(6);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(233, 33);
            this.cboStopBits.TabIndex = 18;
            // 
            // CreateDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateDevice";
            this.Text = "CreateDevice";
            this.Load += new System.EventHandler(this.CreateDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown txtBaudRate;
        private System.Windows.Forms.NumericUpDown txtDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
    }
}