namespace _2025ArtofBeautyFestival.Forms
{
    partial class RegistrationForm


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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbAttendanceDays = new System.Windows.Forms.ComboBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.grpVendor = new System.Windows.Forms.GroupBox();
            this.lblBoothSize = new System.Windows.Forms.Label();
            this.cmbBoothSize = new System.Windows.Forms.ComboBox();
            this.chkElectricity = new System.Windows.Forms.CheckBox();
            this.chkCornerBooth = new System.Windows.Forms.CheckBox();
            this.cmbPerformanceType = new System.Windows.Forms.ComboBox();
            this.lblPerformanceType = new System.Windows.Forms.Label();
            this.grpPerformer = new System.Windows.Forms.GroupBox();
            this.lblStageName = new System.Windows.Forms.Label();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumberofPerformers = new System.Windows.Forms.Label();
            this.grpBeautyArtist = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkEquipment = new System.Windows.Forms.CheckBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblFeeLabel = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFeeAmount = new System.Windows.Forms.Label();
            this.grpVendor.SuspendLayout();
            this.grpPerformer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpBeautyArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1224, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Registration form";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged = new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 140);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(130, 137);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(292, 30);
            this.txtFirstName.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(568, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 30);
            this.textBox3.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(445, 142);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(918, 140);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(130, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(46, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(445, 224);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 25);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            this.cmbRole.Items.AddRange(new object[] {
            "Attendee",
            "Beauty Artist $100",
            "Performer $50",
            "Vendor"});
            this.cmbRole.Location = new System.Drawing.Point(529, 216);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(308, 33);
            this.cmbRole.TabIndex = 10;
            // 
            // cmbAttendanceDays
            // 
            this.cmbAttendanceDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAttendanceDays.FormattingEnabled = true;
            this.cmbAttendanceDays.Items.AddRange(new object[] {
            "Day 1 - $25",
            "Day 2- $25",
            "Both - $40"});
            this.cmbAttendanceDays.Location = new System.Drawing.Point(1027, 216);
            this.cmbAttendanceDays.Name = "cmbAttendanceDays";
            this.cmbAttendanceDays.Size = new System.Drawing.Size(170, 33);
            this.cmbAttendanceDays.TabIndex = 12;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(879, 216);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(112, 25);
            this.lblAttendance.TabIndex = 11;
            this.lblAttendance.Text = "Attendance";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(1089, 135);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 30);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // grpVendor
            // 
            this.grpVendor.Controls.Add(this.chkCornerBooth);
            this.grpVendor.Controls.Add(this.chkElectricity);
            this.grpVendor.Controls.Add(this.cmbBoothSize);
            this.grpVendor.Controls.Add(this.lblBoothSize);
            this.grpVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVendor.Location = new System.Drawing.Point(33, 304);
            this.grpVendor.Name = "grpVendor";
            this.grpVendor.Size = new System.Drawing.Size(536, 164);
            this.grpVendor.TabIndex = 14;
            this.grpVendor.TabStop = false;
            this.grpVendor.Text = "Vendor Info";
            this.grpVendor.Visible = true;
            // 
            // lblBoothSize
            // 
            this.lblBoothSize.AutoSize = true;
            this.lblBoothSize.Location = new System.Drawing.Point(6, 46);
            this.lblBoothSize.Name = "lblBoothSize";
            this.lblBoothSize.Size = new System.Drawing.Size(107, 25);
            this.lblBoothSize.TabIndex = 0;
            this.lblBoothSize.Text = "Booth Size";
            // 
            // cmbBoothSize
            // 
            this.cmbBoothSize.FormattingEnabled = true;
            this.cmbBoothSize.Items.AddRange(new object[] {
            "Small - $150",
            "Medium - $250",
            "Large - $400"});
            this.cmbBoothSize.Location = new System.Drawing.Point(129, 43);
            this.cmbBoothSize.Name = "cmbBoothSize";
            this.cmbBoothSize.Size = new System.Drawing.Size(213, 33);
            this.cmbBoothSize.TabIndex = 1;
            // 
            // chkElectricity
            // 
            this.chkElectricity.AutoSize = true;
            this.chkElectricity.Location = new System.Drawing.Point(17, 94);
            this.chkElectricity.Name = "chkElectricity";
            this.chkElectricity.Size = new System.Drawing.Size(285, 36);
            this.chkElectricity.TabIndex = 2;
            this.chkElectricity.Text = "Needs Electricity - $50";
            this.chkElectricity.UseVisualStyleBackColor = true;
            // 
            // chkCornerBooth
            // 
            this.chkCornerBooth.AutoSize = true;
            this.chkCornerBooth.Location = new System.Drawing.Point(270, 94);
            this.chkCornerBooth.Name = "chkCornerBooth";
            this.chkCornerBooth.Size = new System.Drawing.Size(250, 36);
            this.chkCornerBooth.TabIndex = 3;
            this.chkCornerBooth.Text = "Corner Booth - $75";
            this.chkCornerBooth.UseVisualStyleBackColor = true;
            // 
            // cmbPerformanceType
            // 
            this.cmbPerformanceType.FormattingEnabled = true;
            this.cmbPerformanceType.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbPerformanceType.Location = new System.Drawing.Point(220, 81);
            this.cmbPerformanceType.Name = "cmbPerformanceType";
            this.cmbPerformanceType.Size = new System.Drawing.Size(233, 33);
            this.cmbPerformanceType.TabIndex = 5;
            // 
            // lblPerformanceType
            // 
            this.lblPerformanceType.AutoSize = true;
            this.lblPerformanceType.Location = new System.Drawing.Point(11, 84);
            this.lblPerformanceType.Name = "lblPerformanceType";
            this.lblPerformanceType.Size = new System.Drawing.Size(173, 25);
            this.lblPerformanceType.TabIndex = 4;
            this.lblPerformanceType.Text = "Performance Type";
            // 
            // grpPerformer
            // 
            this.grpPerformer.Controls.Add(this.lblNumberofPerformers);
            this.grpPerformer.Controls.Add(this.numericUpDown1);
            this.grpPerformer.Controls.Add(this.txtStageName);
            this.grpPerformer.Controls.Add(this.lblStageName);
            this.grpPerformer.Controls.Add(this.cmbPerformanceType);
            this.grpPerformer.Controls.Add(this.lblPerformanceType);
            this.grpPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerformer.Location = new System.Drawing.Point(626, 306);
            this.grpPerformer.Name = "grpPerformer";
            this.grpPerformer.Size = new System.Drawing.Size(588, 162);
            this.grpPerformer.TabIndex = 15;
            this.grpPerformer.TabStop = false;
            this.grpPerformer.Text = "Performer Info";
            this.grpPerformer.Visible = true;
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Location = new System.Drawing.Point(13, 34);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(151, 31);
            this.lblStageName.TabIndex = 6;
            this.lblStageName.Text = "Stage Name";
            // 
            // txtStageName
            // 
            this.txtStageName.Location = new System.Drawing.Point(161, 32);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(410, 30);
            this.txtStageName.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(315, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 30);
            this.numericUpDown1.TabIndex = 8;
            // 
            // lblNumberofPerformers
            // 
            this.lblNumberofPerformers.AutoSize = true;
            this.lblNumberofPerformers.Location = new System.Drawing.Point(13, 124);
            this.lblNumberofPerformers.Name = "lblNumberofPerformers";
            this.lblNumberofPerformers.Size = new System.Drawing.Size(202, 25);
            this.lblNumberofPerformers.TabIndex = 9;
            this.lblNumberofPerformers.Text = "Number of Performers";
            // 
            // grpBeautyArtist
            // 
            this.grpBeautyArtist.Controls.Add(this.checkBox1);
            this.grpBeautyArtist.Controls.Add(this.chkEquipment);
            this.grpBeautyArtist.Controls.Add(this.cmbServiceType);
            this.grpBeautyArtist.Controls.Add(this.lblServiceType);
            this.grpBeautyArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeautyArtist.Location = new System.Drawing.Point(33, 500);
            this.grpBeautyArtist.Name = "grpBeautyArtist";
            this.grpBeautyArtist.Size = new System.Drawing.Size(536, 157);
            this.grpBeautyArtist.TabIndex = 16;
            this.grpBeautyArtist.TabStop = false;
            this.grpBeautyArtist.Text = "Beauty Artist Info";
            this.grpBeautyArtist.Visible = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(270, 94);
            this.checkBox1.Name = "chkElectricity";
            this.checkBox1.Size = new System.Drawing.Size(178, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Needs Electricity";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkEquipment
            // 
            this.chkEquipment.AutoSize = true;
            this.chkEquipment.Location = new System.Drawing.Point(17, 94);
            this.chkEquipment.Name = "chkEquipment";
            this.chkEquipment.Size = new System.Drawing.Size(203, 29);
            this.chkEquipment.TabIndex = 2;
            this.chkEquipment.Text = "Bringing Equipment";
            this.chkEquipment.UseVisualStyleBackColor = true;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Hair",
            "Nail ",
            "Makeup"});
            this.cmbServiceType.Location = new System.Drawing.Point(156, 43);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(213, 33);
            this.cmbServiceType.TabIndex = 1;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(6, 46);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(160, 31);
            this.lblServiceType.TabIndex = 0;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblFeeLabel
            // 
            this.lblFeeLabel.AutoSize = true;
            this.lblFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeLabel.Location = new System.Drawing.Point(59, 740);
            this.lblFeeLabel.Name = "lblFeeLabel";
            this.lblFeeLabel.Size = new System.Drawing.Size(197, 29);
            this.lblFeeLabel.TabIndex = 17;
            this.lblFeeLabel.Text = "Registration Fee:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(830, 838);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(258, 48);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister.Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(884, 941);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click;
            // 
            // lblFeeAmount
            // 
            this.lblFeeAmount.AutoSize = true;
            this.lblFeeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeAmount.Location = new System.Drawing.Point(328, 731);
            this.lblFeeAmount.Name = "lblFeeAmount";
            this.lblFeeAmount.Size = new System.Drawing.Size(96, 36);
            this.lblFeeAmount.TabIndex = 20;
            this.lblFeeAmount.Text = "$0.00";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 1112);
            this.Controls.Add(this.lblFeeAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblFeeLabel);
            this.Controls.Add(this.grpBeautyArtist);
            this.Controls.Add(this.grpPerformer);
            this.Controls.Add(this.grpVendor);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.cmbAttendanceDays);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.textBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.grpVendor.ResumeLayout(true);
            this.grpVendor.PerformLayout();
            this.grpPerformer.ResumeLayout(false);
            this.grpPerformer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpBeautyArtist.ResumeLayout(false);
            this.grpBeautyArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbAttendanceDays;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox grpVendor;
        private System.Windows.Forms.Label lblBoothSize;
        private System.Windows.Forms.CheckBox chkCornerBooth;
        private System.Windows.Forms.CheckBox chkElectricity;
        private System.Windows.Forms.ComboBox cmbBoothSize;
        private System.Windows.Forms.ComboBox cmbPerformanceType;
        private System.Windows.Forms.Label lblPerformanceType;
        private System.Windows.Forms.GroupBox grpPerformer;
        private System.Windows.Forms.Label lblNumberofPerformers;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.GroupBox grpBeautyArtist;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkEquipment;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblFeeLabel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFeeAmount;
    }
}