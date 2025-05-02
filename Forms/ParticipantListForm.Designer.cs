using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _2025ArtofBeautyFestival.Forms
{
    public partial class ParticipantListForm : Form
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
            this.cmbFilterRole = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.lblFilterYear = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFilterRole
            // 
            this.cmbFilterRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterRole.FormattingEnabled = true;
            this.cmbFilterRole.Items.AddRange(new object[] {
            "Attendee",
            "Performer",
            "Beauty Artist",
            "Vendor"});
            this.cmbFilterRole.Location = new System.Drawing.Point(183, 98);
            this.cmbFilterRole.Name = "cmbFilterRole";
            this.cmbFilterRole.Size = new System.Drawing.Size(157, 33);
            this.cmbFilterRole.TabIndex = 0;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(25, 291);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(190, 40);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterRole.Location = new System.Drawing.Point(54, 106);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(98, 25);
            this.lblFilterRole.TabIndex = 3;
            this.lblFilterRole.Text = "Filter Role";
            // 
            // lblFilterYear
            // 
            this.lblFilterYear.AutoSize = true;
            this.lblFilterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterYear.Location = new System.Drawing.Point(54, 190);
            this.lblFilterYear.Name = "lblFilterYear";
            this.lblFilterYear.Size = new System.Drawing.Size(125, 31);
            this.lblFilterYear.TabIndex = 5;
            this.lblFilterYear.Text = "Filter Year";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Attendee",
            "Performer",
            "Beauty Artist",
            "Vendor"});
            this.comboBox1.Location = new System.Drawing.Point(183, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // ParticipantListForm
            // 
            this.ClientSize = new System.Drawing.Size(975, 841);
            this.Controls.Add(this.lblFilterYear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblFilterRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.cmbFilterRole);
            this.Name = "ParticipantListForm";
            this.Load += new System.EventHandler(this.ParticipantListForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private ComboBox cmbFilterRole;
        private Button btnClearFilter;
        private Button button1;
        private Label lblFilterRole;
        private Label lblFilterYear;
        private ComboBox comboBox1;
    }
}