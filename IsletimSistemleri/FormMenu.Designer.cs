
namespace IsletimSistemleri
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.buttonSound = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonApplications = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMonitoring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonitor.Image = global::IsletimSistemleri.Properties.Resources.icons8_monitor_48;
            this.buttonMonitor.Location = new System.Drawing.Point(42, 101);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(75, 61);
            this.buttonMonitor.TabIndex = 0;
            this.buttonMonitor.UseVisualStyleBackColor = true;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // buttonSound
            // 
            this.buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound.Image = global::IsletimSistemleri.Properties.Resources.icons8_voice_50;
            this.buttonSound.Location = new System.Drawing.Point(150, 101);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(75, 61);
            this.buttonSound.TabIndex = 1;
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::IsletimSistemleri.Properties.Resources.rsz_logoa;
            this.pictureBox1.Location = new System.Drawing.Point(146, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonApplications
            // 
            this.buttonApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplications.Image = global::IsletimSistemleri.Properties.Resources.icons8_application_window_50;
            this.buttonApplications.Location = new System.Drawing.Point(256, 101);
            this.buttonApplications.Name = "buttonApplications";
            this.buttonApplications.Size = new System.Drawing.Size(75, 61);
            this.buttonApplications.TabIndex = 3;
            this.buttonApplications.UseVisualStyleBackColor = true;
            this.buttonApplications.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::IsletimSistemleri.Properties.Resources.icons8_laptop_settings_50;
            this.buttonSettings.Location = new System.Drawing.Point(256, 190);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 61);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonMonitoring
            // 
            this.buttonMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonitoring.Image = global::IsletimSistemleri.Properties.Resources.icons8_monitoring_50;
            this.buttonMonitoring.Location = new System.Drawing.Point(150, 190);
            this.buttonMonitoring.Name = "buttonMonitoring";
            this.buttonMonitoring.Size = new System.Drawing.Size(75, 61);
            this.buttonMonitoring.TabIndex = 5;
            this.buttonMonitoring.UseVisualStyleBackColor = true;
            this.buttonMonitoring.Click += new System.EventHandler(this.buttonMonitoring_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.buttonMonitoring);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonApplications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.buttonMonitor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMonitor;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonApplications;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMonitoring;
     
    }
}