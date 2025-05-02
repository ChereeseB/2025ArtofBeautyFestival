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

namespace _2025ArtofBeautyFestival.Forms
{
    public partial class ParticipantListForm : Form
    {
        private string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles", "participants.xml");

        public ParticipantListForm()
        {
            InitializeComponent();
        }

        private void ParticipantListForm_Load(object sender, EventArgs e)
        {
            LoadParticipantData();
        }

        private void LoadParticipantData()
        {
            if (File.Exists(xmlFilePath))
            {
                try
                {
                    fullData = new DataTable();
                    fullData.ReadXml(xmlFilePath);

                    dgvParticipants.DataSource = fullData;

                    // Load unique roles and years into filter dropdowns
                    var roles = fullData.AsEnumerable()
                        .Select(row => row["Role"].ToString())
                        .Distinct()
                        .OrderBy(r => r)
                        .ToList();

                    cmbFilterRole.Items.Clear();
                    cmbFilterRole.Items.Add("All");
                    cmbFilterRole.Items.AddRange(roles.ToArray());
                    cmbFilterRole.SelectedIndex = 0;

                    var years = fullData.AsEnumerable()
                        .Select(row => row["FestivalYear"].ToString())
                        .Distinct()
                        .OrderBy(y => y)
                        .ToList();

                    cmbFilterYear.Items.Clear();
                    cmbFilterYear.Items.Add("All");
                    cmbFilterYear.Items.AddRange(years.ToArray());
                    cmbFilterYear.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading participant data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No participant data file found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ApplyFilters()
        {
            if (fullData == null) return;

            string role = cmbFilterRole.SelectedItem?.ToString();
            string year = cmbFilterYear.SelectedItem?.ToString();

            var filtered = fullData.AsEnumerable();

            if (!string.IsNullOrEmpty(role) && role != "All")
                filtered = filtered.Where(row => row["Role"].ToString() == role);

            if (!string.IsNullOrEmpty(year) && year != "All")
                filtered = filtered.Where(row => row["FestivalYear"].ToString() == year);

            dgvParticipants.DataSource = filtered.CopyToDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ParticipantListForm_Load_1(object sender, EventArgs e)
        {
                   
        }

        private void cmbFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbFilterRole.SelectedIndex = 0;
            cmbFilterYear.SelectedIndex = 0;
            dgvParticipants.DataSource = fullData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}