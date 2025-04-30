using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025ArtofBeautyFestival.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

            if (selectedRole.StartsWith("Vendor"))
                grpVendor.Visible = true;
            else if (selectedRole.StartsWith("Performer"))
                grpPerformer.Visible = true;
            else if (selectedRole.StartsWith("Beauty Artist"))
                grpBeautyArtist.Visible = true;

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
    }
}