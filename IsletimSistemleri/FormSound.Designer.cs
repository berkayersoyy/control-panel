
namespace IsletimSistemleri
{
    partial class FormSound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSound));
            this.buttonVolUp = new System.Windows.Forms.Button();
            this.buttonVolDown = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolUp
            // 
            this.buttonVolUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVolUp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonVolUp.Image = global::IsletimSistemleri.Properties.Resources.icons8_plus___50;
            this.buttonVolUp.Location = new System.Drawing.Point(245, 130);
            this.buttonVolUp.Name = "buttonVolUp";
            this.buttonVolUp.Size = new System.Drawing.Size(64, 58);
            this.buttonVolUp.TabIndex = 8;
            this.buttonVolUp.UseVisualStyleBackColor = false;
            this.buttonVolUp.Click += new System.EventHandler(this.buttonVolUp_Click);
            // 
            // buttonVolDown
            // 
            this.buttonVolDown.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVolDown.ForeColor = System.Drawing.Color.Transparent;
            this.buttonVolDown.Image = global::IsletimSistemleri.Properties.Resources.icons8_minus_50;
            this.buttonVolDown.Location = new System.Drawing.Point(71, 130);
            this.buttonVolDown.Name = "buttonVolDown";
            this.buttonVolDown.Size = new System.Drawing.Size(64, 58);
            this.buttonVolDown.TabIndex = 9;
            this.buttonVolDown.UseVisualStyleBackColor = false;
            this.buttonVolDown.Click += new System.EventHandler(this.buttonVolDown_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.Transparent;
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMute.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMute.Image = global::IsletimSistemleri.Properties.Resources.icons8_mute_50;
            this.buttonMute.Location = new System.Drawing.Point(158, 130);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(64, 58);
            this.buttonMute.TabIndex = 10;
            this.buttonMute.UseVisualStyleBackColor = false;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.Image = global::IsletimSistemleri.Properties.Resources.icons8_right_arrow_30;
            this.buttonBack.Location = new System.Drawing.Point(12, 285);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(39, 39);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.buttonVolDown);
            this.Controls.Add(this.buttonVolUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ses Ayarları";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolUp;
        private System.Windows.Forms.Button buttonVolDown;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonBack;
    }
}