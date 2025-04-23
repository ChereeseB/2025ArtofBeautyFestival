namespace _2025ArtofBeautyFestival.Forms
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
            this.components = new System.ComponentModel.Container();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnViewParticipants = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::_2025ArtofBeautyFestival.Properties.Resources.AoBFest_2025logo;
            this.picLogo.Location = new System.Drawing.Point(297, 29);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(345, 202);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(72, 274);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(219, 69);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register Participant";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnViewParticipants
            // 
            this.btnViewParticipants.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnViewParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParticipants.Location = new System.Drawing.Point(400, 274);
            this.btnViewParticipants.Name = "btnViewParticipants";
            this.btnViewParticipants.Size = new System.Drawing.Size(219, 69);
            this.btnViewParticipants.TabIndex = 2;
            this.btnViewParticipants.Text = "View Participants";
            this.btnViewParticipants.UseVisualStyleBackColor = false;
            this.btnViewParticipants.Click += new System.EventHandler(this.btnViewParticipants_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(739, 274);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(219, 69);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(750, 485);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(219, 69);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1217, 989);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnViewParticipants);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.picLogo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art of Beauty Festival Management";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewParticipants;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}