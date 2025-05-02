using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 2025ArtofBeautyFestival.Forms;

namespace 2025ArtofBeautyFestival.Forms
{
    public partial class RegistrationForm : Form
    {
        private DataTable participantTable;
        private string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "participants.xml");


        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private MaskedTextBox mtxtPhoneNumber;
        private Label lblRole;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblAttendance;
        private GroupBox grpVendor;
        private ComboBox cmbBoothSize;
        private Label lblBoothSize;
        private CheckBox chkCornerBooth;
        private CheckBox chkElectricity;
        private Label lblFeeLabel;
        private Label lblFeeAmount;
        private Button btnRegister;
        private Button btnCancel;
        private GroupBox grpPerformer;
        private TextBox txtTechnicalRequirements;
        private Label lblTechnicalRequirements;
        private Label lblDuration;
        private TextBox txtStageName;
        private Label lblStageName;
        private NumericUpDown numPerformers;
        private Label lblNumPerformers;
        private ComboBox cmbPerformanceType;
        private Label lblPerformanceType;
        private CheckBox chkAvailableForRehearsals;
        private ComboBox cmbDuration;
        private TextBox textBox1;
        private Label lblCulturalBackground;
        private GroupBox grpBeautyArtist;
        private ComboBox cmbServiceType;
        private Label lblServiceType;
        private CheckBox chkLicensedProfessional;
        private CheckBox chkBringingEquipment;
        private Label txtBusinessName;
        private TextBox textBox2;
        private Label cmbProductType;
        private ComboBox comboBox3;
        private TextBox textBox4;
        private Label lblPriceRange;
        private Label lblProductDescription;
        private TextBox txtProductDescription;
        private GroupBox grpFoodVendor;
        private Label lblFoodCategory;
        private Label lblFoodHandlerCert;
        private Label lblMenuDescription;
        private ComboBox cmbFoodCategory;
        private TextBox txtMenuDescription;
        private CheckBox chkVeganOptions;
        private TextBox txtFoodHandlerCert;
        private Label lblRegistrationFormTitle;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = participantTable.NewRow();

                // Collect common participant info
                row["FirstName"] = txtFirstName.Text;
                row["LastName"] = txtLastName.Text;
                row["Email"] = txtEmail.Text;
                row["Phone"] = txtPhoneNumber.Text;
                row["Role"] = cmbRole.SelectedItem?.ToString();
                row["Attendance"] = cmbAttendanceDays.SelectedItem?.ToString();
                row["Fee"] = CalculateFee();
                row["FestivalYear"] = DateTime.Now.Year;

                // Example: Vendor details
                if (cmbRole.SelectedItem?.ToString() == "Vendor")
                {
                    row["BusinessName"] = txtBusinessName.Text;
                    row["ProductType"] = cmbProductType.SelectedItem?.ToString();
                    row["ProductDescription"] = txtProductDescription.Text;
                    row["PriceRange"] = txtPriceRange.Text;
                    row["BoothSize"] = cmbBoothSize.SelectedItem?.ToString();
                    row["Electricity"] = chkElectricity.Checked;
                    row["CornerBooth"] = chkCornerBooth.Checked;
                }

                // Example: Performer details
                if (cmbRole.SelectedItem?.ToString() == "Performer")
                {
                    row["StageName"] = txtStageName.Text;
                    row["PerformanceType"] = cmbPerformanceType.SelectedItem?.ToString();
                    row["NumPerformers"] = (int)numPerformers.Value;
                    row["TechnicalRequirements"] = txtTechnicalRequirements.Text;
                    row["PerformanceDuration"] = txtDuration.Text;
                    row["CulturalBackground"] = txtCulturalBackground.Text;
                    row["AvailableForRehearsals"] = chkAvailableForRehearsals.Checked;
                }

                // Example: Beauty Artist details
                if (cmbRole.SelectedItem?.ToString() == "Beauty Artist")
                {
                    row["ServiceType"] = cmbServiceType.SelectedItem?.ToString();
                    row["BringingEquipment"] = chkBringingEquipment.Checked;
                    row["LicensedProfessional"] = chkLicensedProfessional.Checked;
                }

                // Add row to table and write to XML
                participantTable.Rows.Add(row);
                participantTable.WriteXml(xmlFilePath, XmlWriteMode.WriteSchema);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Calculate the registration fee
        private decimal CalculateFee()
        {
            decimal fee = 0;
            string role = cmbRole.SelectedItem?.ToString();
            string attendance = cmbAttendanceDays.SelectedItem?.ToString();

            if (role == "Attendee")
            {
                if (attendance == "Day 1" || attendance == "Day 2")
                    fee = 25;
                else if (attendance == "Both")
                    fee = 40;
            }
            else if (role == "Performer")
            {
                fee = 50;
            }
            else if (role == "Beauty Artist")
            {
                fee = 100;
            }
            else if (role == "Vendor")
            {
                string boothSize = cmbBoothSize.SelectedItem?.ToString();

                switch (boothSize)
                {
                    case "Small":
                        fee = 150;
                        break;
                    case "Medium":
                        fee = 250;
                        break;
                    case "Large":
                        fee = 400;
                        break;
                }

                if (chkElectricity.Checked)
                    fee += 50;
                if (chkCornerBooth.Checked)
                    fee += 75;
            }

            return fee;
        }

        // Update the fee label (not a popup message)
        private void UpdateFeeLabel()
        {
            decimal finalFee = CalculateFee();
            lblFeeAmount.Text = $"${finalFee:0.00}";
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all groupboxes first
            grpVendor.Visible = false;
            grpPerformer.Visible = false;
            grpBeautyArtist.Visible = false;

            // Show the groupbox that matches the role
            string selectedRole = cmbRole.SelectedItem?.ToString();

            // if (selectedRole.StartsWith("Vendor"))
            // grpVendor.Visible = true;
            // else if (selectedRole.StartsWith("Performer"))
            //grpPerformer.Visible = true;
            //else if (selectedRole.StartsWith("Beauty Artist"))
            //grpBeautyArtist.Visible = true;

            switch (selectedRole)
            {
                case "Vendor":
                    grpVendor.Visible = true;
                    break;
                case "Performer":
                    grpPerformer.Visible = true;
                    break;
                case "Beauty Artist":
                    grpBeautyArtist.Visible = true;
                    break;
            }

            UpdateFeeLabel();
        }

        private void cmbAttendanceDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFeeLabel();
        }

        private void cmbBoothSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFeeLabel();
        }

        private void chkElectricity_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFeeLabel();
        }

        private void chkCornerBooth_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFeeLabel();
        }

        private void InitializeComponent()
        {
            this.lblRegistrationFormTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.grpVendor = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.Label();
            this.chkCornerBooth = new System.Windows.Forms.CheckBox();
            this.chkElectricity = new System.Windows.Forms.CheckBox();
            this.cmbBoothSize = new System.Windows.Forms.ComboBox();
            this.lblBoothSize = new System.Windows.Forms.Label();
            this.lblFeeLabel = new System.Windows.Forms.Label();
            this.lblFeeAmount = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPerformer = new System.Windows.Forms.GroupBox();
            this.chkAvailableForRehearsals = new System.Windows.Forms.CheckBox();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCulturalBackground = new System.Windows.Forms.Label();
            this.numPerformers = new System.Windows.Forms.NumericUpDown();
            this.lblNumPerformers = new System.Windows.Forms.Label();
            this.cmbPerformanceType = new System.Windows.Forms.ComboBox();
            this.lblPerformanceType = new System.Windows.Forms.Label();
            this.txtTechnicalRequirements = new System.Windows.Forms.TextBox();
            this.lblTechnicalRequirements = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.lblStageName = new System.Windows.Forms.Label();
            this.grpBeautyArtist = new System.Windows.Forms.GroupBox();
            this.chkLicensedProfessional = new System.Windows.Forms.CheckBox();
            this.chkBringingEquipment = new System.Windows.Forms.CheckBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.grpFoodVendor = new System.Windows.Forms.GroupBox();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.lblMenuDescription = new System.Windows.Forms.Label();
            this.lblFoodHandlerCert = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.chkVeganOptions = new System.Windows.Forms.CheckBox();
            this.txtMenuDescription = new System.Windows.Forms.TextBox();
            this.txtFoodHandlerCert = new System.Windows.Forms.TextBox();
            this.grpVendor.SuspendLayout();
            this.grpPerformer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPerformers)).BeginInit();
            this.grpBeautyArtist.SuspendLayout();
            this.grpFoodVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistrationFormTitle
            // 
            this.lblRegistrationFormTitle.AutoSize = true;
            this.lblRegistrationFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationFormTitle.Location = new System.Drawing.Point(479, 18);
            this.lblRegistrationFormTitle.Name = "lblRegistrationFormTitle";
            this.lblRegistrationFormTitle.Size = new System.Drawing.Size(222, 29);
            this.lblRegistrationFormTitle.TabIndex = 1;
            this.lblRegistrationFormTitle.Text = "Registration Form";
            this.lblRegistrationFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(66, 101);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(178, 102);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(285, 30);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(610, 98);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(276, 30);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(483, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(178, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(97, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(907, 101);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(1068, 96);
            this.mtxtPhoneNumber.Mask = "(999) 000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(185, 30);
            this.mtxtPhoneNumber.TabIndex = 13;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(510, 161);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 25);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Attendee",
            "Vendor",
            "Performer",
            "Beauty Artist"});
            this.comboBox1.Location = new System.Drawing.Point(591, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day 1 ($25)",
            "Day 2 ($25)",
            "Both ($40)"});
            this.comboBox2.Location = new System.Drawing.Point(997, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 33);
            this.comboBox2.TabIndex = 17;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(867, 158);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(112, 25);
            this.lblAttendance.TabIndex = 16;
            this.lblAttendance.Text = "Attendance";
            // 
            // grpVendor
            // 
            this.grpVendor.Controls.Add(this.textBox4);
            this.grpVendor.Controls.Add(this.lblPriceRange);
            this.grpVendor.Controls.Add(this.txtProductDescription);
            this.grpVendor.Controls.Add(this.lblProductDescription);
            this.grpVendor.Controls.Add(this.comboBox3);
            this.grpVendor.Controls.Add(this.cmbProductType);
            this.grpVendor.Controls.Add(this.textBox2);
            this.grpVendor.Controls.Add(this.txtBusinessName);
            this.grpVendor.Controls.Add(this.chkCornerBooth);
            this.grpVendor.Controls.Add(this.chkElectricity);
            this.grpVendor.Controls.Add(this.cmbBoothSize);
            this.grpVendor.Controls.Add(this.lblBoothSize);
            this.grpVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVendor.Location = new System.Drawing.Point(71, 246);
            this.grpVendor.Name = "grpVendor";
            this.grpVendor.Size = new System.Drawing.Size(1164, 159);
            this.grpVendor.TabIndex = 18;
            this.grpVendor.TabStop = false;
            this.grpVendor.Text = "Vendor Registration";
            this.grpVendor.Enter += new System.EventHandler(this.grpVendor_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 27);
            this.textBox4.TabIndex = 11;
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Location = new System.Drawing.Point(18, 128);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(101, 20);
            this.lblPriceRange.TabIndex = 10;
            this.lblPriceRange.Text = "Price Range";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(179, 58);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ShortcutsEnabled = false;
            this.txtProductDescription.Size = new System.Drawing.Size(969, 57);
            this.txtProductDescription.TabIndex = 9;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(5, 80);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(158, 20);
            this.lblProductDescription.TabIndex = 8;
            this.lblProductDescription.Text = "Product Description";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Art,",
            "Jewelry,",
            "Beauty Products,",
            "Food"});
            this.comboBox3.Location = new System.Drawing.Point(685, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(112, 28);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // cmbProductType
            // 
            this.cmbProductType.AutoSize = true;
            this.cmbProductType.Location = new System.Drawing.Point(571, 30);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(108, 20);
            this.cmbProductType.TabIndex = 6;
            this.cmbProductType.Text = "Product Type";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 27);
            this.textBox2.TabIndex = 5;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.AutoSize = true;
            this.txtBusinessName.Location = new System.Drawing.Point(6, 30);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(128, 20);
            this.txtBusinessName.TabIndex = 4;
            this.txtBusinessName.Text = "Business Name";
            // 
            // chkCornerBooth
            // 
            this.chkCornerBooth.AutoSize = true;
            this.chkCornerBooth.Location = new System.Drawing.Point(974, 129);
            this.chkCornerBooth.Name = "chkCornerBooth";
            this.chkCornerBooth.Size = new System.Drawing.Size(174, 24);
            this.chkCornerBooth.TabIndex = 3;
            this.chkCornerBooth.Text = "Corner Booth - $75";
            this.chkCornerBooth.UseVisualStyleBackColor = true;
            // 
            // chkElectricity
            // 
            this.chkElectricity.AutoSize = true;
            this.chkElectricity.Location = new System.Drawing.Point(747, 129);
            this.chkElectricity.Name = "chkElectricity";
            this.chkElectricity.Size = new System.Drawing.Size(201, 24);
            this.chkElectricity.TabIndex = 2;
            this.chkElectricity.Text = "Needs Electricity - $50";
            this.chkElectricity.UseVisualStyleBackColor = true;
            // 
            // cmbBoothSize
            // 
            this.cmbBoothSize.FormattingEnabled = true;
            this.cmbBoothSize.Items.AddRange(new object[] {
            "Small  - $150",
            "Medium - $250",
            "Large - $400"});
            this.cmbBoothSize.Location = new System.Drawing.Point(565, 125);
            this.cmbBoothSize.Name = "cmbBoothSize";
            this.cmbBoothSize.Size = new System.Drawing.Size(164, 28);
            this.cmbBoothSize.TabIndex = 1;
            this.cmbBoothSize.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblBoothSize
            // 
            this.lblBoothSize.AutoSize = true;
            this.lblBoothSize.Location = new System.Drawing.Point(461, 128);
            this.lblBoothSize.Name = "lblBoothSize";
            this.lblBoothSize.Size = new System.Drawing.Size(91, 20);
            this.lblBoothSize.TabIndex = 0;
            this.lblBoothSize.Text = "Booth Size";
            this.lblBoothSize.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblFeeLabel
            // 
            this.lblFeeLabel.AutoSize = true;
            this.lblFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeLabel.Location = new System.Drawing.Point(77, 1068);
            this.lblFeeLabel.Name = "lblFeeLabel";
            this.lblFeeLabel.Size = new System.Drawing.Size(159, 25);
            this.lblFeeLabel.TabIndex = 19;
            this.lblFeeLabel.Text = "Registration Fee:";
            // 
            // lblFeeAmount
            // 
            this.lblFeeAmount.AutoSize = true;
            this.lblFeeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeAmount.Location = new System.Drawing.Point(260, 1059);
            this.lblFeeAmount.Name = "lblFeeAmount";
            this.lblFeeAmount.Size = new System.Drawing.Size(91, 32);
            this.lblFeeAmount.TabIndex = 20;
            this.lblFeeAmount.Text = "$0.00";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(997, 1057);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(189, 40);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1192, 1061);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 30);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpPerformer
            // 
            this.grpPerformer.Controls.Add(this.chkAvailableForRehearsals);
            this.grpPerformer.Controls.Add(this.cmbDuration);
            this.grpPerformer.Controls.Add(this.textBox1);
            this.grpPerformer.Controls.Add(this.lblCulturalBackground);
            this.grpPerformer.Controls.Add(this.numPerformers);
            this.grpPerformer.Controls.Add(this.lblNumPerformers);
            this.grpPerformer.Controls.Add(this.cmbPerformanceType);
            this.grpPerformer.Controls.Add(this.lblPerformanceType);
            this.grpPerformer.Controls.Add(this.txtTechnicalRequirements);
            this.grpPerformer.Controls.Add(this.lblTechnicalRequirements);
            this.grpPerformer.Controls.Add(this.lblDuration);
            this.grpPerformer.Controls.Add(this.txtStageName);
            this.grpPerformer.Controls.Add(this.lblStageName);
            this.grpPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerformer.Location = new System.Drawing.Point(71, 682);
            this.grpPerformer.Name = "grpPerformer";
            this.grpPerformer.Size = new System.Drawing.Size(1164, 177);
            this.grpPerformer.TabIndex = 23;
            this.grpPerformer.TabStop = false;
            this.grpPerformer.Text = "Performer Registration";
            this.grpPerformer.Enter += new System.EventHandler(this.grpPerformer_Enter);
            // 
            // chkAvailableForRehearsals
            // 
            this.chkAvailableForRehearsals.AutoSize = true;
            this.chkAvailableForRehearsals.Location = new System.Drawing.Point(665, 135);
            this.chkAvailableForRehearsals.Name = "chkAvailableForRehearsals";
            this.chkAvailableForRehearsals.Size = new System.Drawing.Size(222, 24);
            this.chkAvailableForRehearsals.TabIndex = 13;
            this.chkAvailableForRehearsals.Text = "Available for Rehearsals?";
            this.chkAvailableForRehearsals.UseVisualStyleBackColor = true;
            // 
            // cmbDuration
            // 
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "10  Mins",
            "15 Mins",
            "20 Mins"});
            this.cmbDuration.Location = new System.Drawing.Point(825, 99);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(121, 28);
            this.cmbDuration.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 34);
            this.textBox1.TabIndex = 11;
            // 
            // lblCulturalBackground
            // 
            this.lblCulturalBackground.AutoSize = true;
            this.lblCulturalBackground.Location = new System.Drawing.Point(43, 142);
            this.lblCulturalBackground.Name = "lblCulturalBackground";
            this.lblCulturalBackground.Size = new System.Drawing.Size(161, 20);
            this.lblCulturalBackground.TabIndex = 10;
            this.lblCulturalBackground.Text = "Cultural Background";
            // 
            // numPerformers
            // 
            this.numPerformers.Location = new System.Drawing.Point(1073, 42);
            this.numPerformers.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numPerformers.Name = "numPerformers";
            this.numPerformers.Size = new System.Drawing.Size(61, 27);
            this.numPerformers.TabIndex = 9;
            // 
            // lblNumPerformers
            // 
            this.lblNumPerformers.AutoSize = true;
            this.lblNumPerformers.Location = new System.Drawing.Point(922, 42);
            this.lblNumPerformers.Name = "lblNumPerformers";
            this.lblNumPerformers.Size = new System.Drawing.Size(126, 20);
            this.lblNumPerformers.TabIndex = 8;
            this.lblNumPerformers.Text = "# of Performers";
            // 
            // cmbPerformanceType
            // 
            this.cmbPerformanceType.FormattingEnabled = true;
            this.cmbPerformanceType.Items.AddRange(new object[] {
            "Music",
            "Dance",
            "Theater",
            "Spoken Word",
            "Other"});
            this.cmbPerformanceType.Location = new System.Drawing.Point(725, 34);
            this.cmbPerformanceType.Name = "cmbPerformanceType";
            this.cmbPerformanceType.Size = new System.Drawing.Size(183, 28);
            this.cmbPerformanceType.TabIndex = 7;
            // 
            // lblPerformanceType
            // 
            this.lblPerformanceType.AutoSize = true;
            this.lblPerformanceType.Enabled = false;
            this.lblPerformanceType.Location = new System.Drawing.Point(573, 36);
            this.lblPerformanceType.Name = "lblPerformanceType";
            this.lblPerformanceType.Size = new System.Drawing.Size(146, 20);
            this.lblPerformanceType.TabIndex = 6;
            this.lblPerformanceType.Text = "Performance Type";
            // 
            // txtTechnicalRequirements
            // 
            this.txtTechnicalRequirements.Location = new System.Drawing.Point(234, 93);
            this.txtTechnicalRequirements.Multiline = true;
            this.txtTechnicalRequirements.Name = "txtTechnicalRequirements";
            this.txtTechnicalRequirements.Size = new System.Drawing.Size(374, 34);
            this.txtTechnicalRequirements.TabIndex = 5;
            // 
            // lblTechnicalRequirements
            // 
            this.lblTechnicalRequirements.AutoSize = true;
            this.lblTechnicalRequirements.Location = new System.Drawing.Point(27, 106);
            this.lblTechnicalRequirements.Name = "lblTechnicalRequirements";
            this.lblTechnicalRequirements.Size = new System.Drawing.Size(190, 20);
            this.lblTechnicalRequirements.TabIndex = 4;
            this.lblTechnicalRequirements.Text = "Technical Requirements";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(645, 102);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(174, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Performance Duration";
            // 
            // txtStageName
            // 
            this.txtStageName.Location = new System.Drawing.Point(234, 34);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(313, 27);
            this.txtStageName.TabIndex = 1;
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Location = new System.Drawing.Point(6, 41);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(211, 20);
            this.lblStageName.TabIndex = 0;
            this.lblStageName.Text = "Stage Name / Group Name";
            this.lblStageName.Click += new System.EventHandler(this.lblStageName_Click);
            // 
            // grpBeautyArtist
            // 
            this.grpBeautyArtist.Controls.Add(this.chkLicensedProfessional);
            this.grpBeautyArtist.Controls.Add(this.chkBringingEquipment);
            this.grpBeautyArtist.Controls.Add(this.cmbServiceType);
            this.grpBeautyArtist.Controls.Add(this.lblServiceType);
            this.grpBeautyArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeautyArtist.Location = new System.Drawing.Point(71, 902);
            this.grpBeautyArtist.Name = "grpBeautyArtist";
            this.grpBeautyArtist.Size = new System.Drawing.Size(1164, 96);
            this.grpBeautyArtist.TabIndex = 24;
            this.grpBeautyArtist.TabStop = false;
            this.grpBeautyArtist.Text = "Beauty Artist Registration";
            this.grpBeautyArtist.Enter += new System.EventHandler(this.grpBeautyArtist_Enter);
            // 
            // chkLicensedProfessional
            // 
            this.chkLicensedProfessional.AutoSize = true;
            this.chkLicensedProfessional.Location = new System.Drawing.Point(732, 32);
            this.chkLicensedProfessional.Name = "chkLicensedProfessional";
            this.chkLicensedProfessional.Size = new System.Drawing.Size(206, 24);
            this.chkLicensedProfessional.TabIndex = 6;
            this.chkLicensedProfessional.Text = "Licensed Professional?";
            this.chkLicensedProfessional.UseVisualStyleBackColor = true;
            // 
            // chkBringingEquipment
            // 
            this.chkBringingEquipment.AutoSize = true;
            this.chkBringingEquipment.Location = new System.Drawing.Point(444, 32);
            this.chkBringingEquipment.Name = "chkBringingEquipment";
            this.chkBringingEquipment.Size = new System.Drawing.Size(264, 24);
            this.chkBringingEquipment.TabIndex = 5;
            this.chkBringingEquipment.Text = "Bringing Your Own Equipment?";
            this.chkBringingEquipment.UseVisualStyleBackColor = true;
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Hair",
            "Nails",
            "Makeup",
            "Skincare",
            "Other"});
            this.cmbServiceType.Location = new System.Drawing.Point(144, 30);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(264, 28);
            this.cmbServiceType.TabIndex = 1;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(18, 38);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(106, 20);
            this.lblServiceType.TabIndex = 0;
            this.lblServiceType.Text = "Service Type";
            // 
            // grpFoodVendor
            // 
            this.grpFoodVendor.Controls.Add(this.txtFoodHandlerCert);
            this.grpFoodVendor.Controls.Add(this.txtMenuDescription);
            this.grpFoodVendor.Controls.Add(this.chkVeganOptions);
            this.grpFoodVendor.Controls.Add(this.cmbFoodCategory);
            this.grpFoodVendor.Controls.Add(this.lblFoodHandlerCert);
            this.grpFoodVendor.Controls.Add(this.lblMenuDescription);
            this.grpFoodVendor.Controls.Add(this.lblFoodCategory);
            this.grpFoodVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFoodVendor.Location = new System.Drawing.Point(71, 439);
            this.grpFoodVendor.Name = "grpFoodVendor";
            this.grpFoodVendor.Size = new System.Drawing.Size(1164, 144);
            this.grpFoodVendor.TabIndex = 14;
            this.grpFoodVendor.TabStop = false;
            this.grpFoodVendor.Text = "Food Vendor Details";
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCategory.Location = new System.Drawing.Point(18, 43);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(118, 20);
            this.lblFoodCategory.TabIndex = 0;
            this.lblFoodCategory.Text = "Food Category";
            // 
            // lblMenuDescription
            // 
            this.lblMenuDescription.AutoSize = true;
            this.lblMenuDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuDescription.Location = new System.Drawing.Point(440, 33);
            this.lblMenuDescription.Name = "lblMenuDescription";
            this.lblMenuDescription.Size = new System.Drawing.Size(141, 20);
            this.lblMenuDescription.TabIndex = 1;
            this.lblMenuDescription.Text = "Menu Description";
            this.lblMenuDescription.Click += new System.EventHandler(this.lblMenuDescription_Click);
            // 
            // lblFoodHandlerCert
            // 
            this.lblFoodHandlerCert.AutoSize = true;
            this.lblFoodHandlerCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodHandlerCert.Location = new System.Drawing.Point(278, 104);
            this.lblFoodHandlerCert.Name = "lblFoodHandlerCert";
            this.lblFoodHandlerCert.Size = new System.Drawing.Size(264, 25);
            this.lblFoodHandlerCert.TabIndex = 3;
            this.lblFoodHandlerCert.Text = "Food Handler Certificate #:";
            this.lblFoodHandlerCert.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Items.AddRange(new object[] {
            "Entrées",
            "Desserts",
            "Beverages",
            "Snacks"});
            this.cmbFoodCategory.Location = new System.Drawing.Point(159, 35);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(205, 28);
            this.cmbFoodCategory.TabIndex = 4;
            this.cmbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // chkVeganOptions
            // 
            this.chkVeganOptions.AutoSize = true;
            this.chkVeganOptions.Location = new System.Drawing.Point(24, 100);
            this.chkVeganOptions.Name = "chkVeganOptions";
            this.chkVeganOptions.Size = new System.Drawing.Size(213, 24);
            this.chkVeganOptions.TabIndex = 5;
            this.chkVeganOptions.Text = "Vegan Options Available";
            this.chkVeganOptions.UseVisualStyleBackColor = true;
            // 
            // txtMenuDescription
            // 
            this.txtMenuDescription.Location = new System.Drawing.Point(595, 17);
            this.txtMenuDescription.Multiline = true;
            this.txtMenuDescription.Name = "txtMenuDescription";
            this.txtMenuDescription.Size = new System.Drawing.Size(553, 68);
            this.txtMenuDescription.TabIndex = 6;
            this.txtMenuDescription.TextChanged += new System.EventHandler(this.txtMenuDescription_TextChanged);
            // 
            // txtFoodHandlerCert
            // 
            this.txtFoodHandlerCert.Location = new System.Drawing.Point(502, 97);
            this.txtFoodHandlerCert.Name = "txtFoodHandlerCert";
            this.txtFoodHandlerCert.Size = new System.Drawing.Size(227, 27);
            this.txtFoodHandlerCert.TabIndex = 7;
            // 
            // RegistrationForm
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1318, 1146);
            this.Controls.Add(this.grpFoodVendor);
            this.Controls.Add(this.grpBeautyArtist);
            this.Controls.Add(this.grpPerformer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblFeeAmount);
            this.Controls.Add(this.lblFeeLabel);
            this.Controls.Add(this.grpVendor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblRegistrationFormTitle);
            this.Name = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.grpVendor.ResumeLayout(false);
            this.grpVendor.PerformLayout();
            this.grpPerformer.ResumeLayout(false);
            this.grpPerformer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPerformers)).EndInit();
            this.grpBeautyArtist.ResumeLayout(false);
            this.grpBeautyArtist.PerformLayout();
            this.grpFoodVendor.ResumeLayout(false);
            this.grpFoodVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            grpVendor.Visible = false;
            grpPerformer.Visible = false;
            grpBeautyArtist.Visible = false;

            lblFeeAmount.Text = "$0.00";

            participantTable = new DataTable("Participants");

            if (File.Exists(xmlFilePath))
            {
                participantTable.ReadXml(xmlFilePath);
            }
            else
            {
                // COMMON FIELDS
                participantTable.Columns.Add("FirstName", typeof(string));
                participantTable.Columns.Add("LastName", typeof(string));
                participantTable.Columns.Add("Email", typeof(string));
                participantTable.Columns.Add("Phone", typeof(string));
                participantTable.Columns.Add("Role", typeof(string));
                participantTable.Columns.Add("Attendance", typeof(string));
                participantTable.Columns.Add("Fee", typeof(decimal));
                participantTable.Columns.Add("FestivalYear", typeof(int));

                // VENDOR FIELDS
                participantTable.Columns.Add("BusinessName", typeof(string));
                participantTable.Columns.Add("ProductType", typeof(string));
                participantTable.Columns.Add("ProductDescription", typeof(string));
                participantTable.Columns.Add("PriceRange", typeof(string));
                participantTable.Columns.Add("BoothSize", typeof(string));
                participantTable.Columns.Add("Electricity", typeof(bool));
                participantTable.Columns.Add("CornerBooth", typeof(bool));

                // PERFORMER FIELDS
                participantTable.Columns.Add("StageName", typeof(string));
                participantTable.Columns.Add("PerformanceType", typeof(string));
                participantTable.Columns.Add("NumPerformers", typeof(int));
                participantTable.Columns.Add("TechnicalRequirements", typeof(string));
                participantTable.Columns.Add("PerformanceDuration", typeof(string));
                participantTable.Columns.Add("CulturalBackground", typeof(string));
                participantTable.Columns.Add("AvailableForRehearsals", typeof(bool));

                // BEAUTY ARTIST FIELDS
                participantTable.Columns.Add("ServiceType", typeof(string));
                participantTable.Columns.Add("BringingEquipment", typeof(bool));
                participantTable.Columns.Add("LicensedProfessional", typeof(bool));
            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStageName_Click(object sender, EventArgs e)
        {

        }

        private void grpBeautyArtist_Enter(object sender, EventArgs e)
        {

        }

        private void grpVendor_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMenuDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMenuDescription_Click(object sender, EventArgs e)
        {

        }


        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedItem?.ToString() == "Food")
            {
                grpFoodVendor.Visible = true;
            }
            else
            {
                grpFoodVendor.Visible = false;
            }
        }

        private void grpPerformer_Enter(object sender, EventArgs e)
        {

        }
    }
}