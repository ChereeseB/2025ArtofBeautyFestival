namespace ArtofBeautyFestival2025.Forms
{
    partial class MainForm
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnViewParticipants = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_2025ArtofBeautyFestival.Properties.Resources.AoBFest_2025logo;
            this.pictureBox3.Location = new System.Drawing.Point(424, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(381, 202);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(81, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 105);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register Participant";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnViewParticipants
            // 
            this.btnViewParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParticipants.Location = new System.Drawing.Point(484, 386);
            this.btnViewParticipants.Name = "btnViewParticipants";
            this.btnViewParticipants.Size = new System.Drawing.Size(220, 105);
            this.btnViewParticipants.TabIndex = 3;
            this.btnViewParticipants.Text = "View Participants";
            this.btnViewParticipants.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(885, 386);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(220, 105);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = true;tnReports1
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1232, 960);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnViewParticipants);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox3);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.PictureBox picLogo;
       // private System.Windows.Forms.Button btnRegister;
       //private System.Windows.Forms.Button btnViewParticipants;
       // private System.Windows.Forms.Button btnReports1;
        //private System.Windows.Forms.Button btnSettings;
        //private System.Windows.Forms.ToolTip toolTip1;
       // private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Button btnResigter;
        //private System.Windows.Forms.Button btnViewParticipants1;
        //private System.Windows.Forms.Button btnReports1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewParticipants;
        private System.Windows.Forms.Button btnReports;
    }
}