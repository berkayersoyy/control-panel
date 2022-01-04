
namespace IsletimSistemleri
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonSleepMode = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.progressBarBattery = new System.Windows.Forms.ProgressBar();
            this.labelBattery = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRestart.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestart.Image")));
            this.buttonRestart.Location = new System.Drawing.Point(279, 285);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(39, 39);
            this.buttonRestart.TabIndex = 12;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackColor = System.Drawing.Color.Transparent;
            this.buttonShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShutdown.ForeColor = System.Drawing.Color.Transparent;
            this.buttonShutdown.Image = ((System.Drawing.Image)(resources.GetObject("buttonShutdown.Image")));
            this.buttonShutdown.Location = new System.Drawing.Point(324, 285);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(39, 39);
            this.buttonShutdown.TabIndex = 11;
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonSleepMode
            // 
            this.buttonSleepMode.BackColor = System.Drawing.Color.Transparent;
            this.buttonSleepMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSleepMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSleepMode.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSleepMode.Image = global::IsletimSistemleri.Properties.Resources.moon1;
            this.buttonSleepMode.Location = new System.Drawing.Point(234, 285);
            this.buttonSleepMode.Name = "buttonSleepMode";
            this.buttonSleepMode.Size = new System.Drawing.Size(39, 39);
            this.buttonSleepMode.TabIndex = 10;
            this.buttonSleepMode.UseVisualStyleBackColor = false;
            this.buttonSleepMode.Click += new System.EventHandler(this.buttonSleepMode_Click);
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
            this.buttonBack.TabIndex = 13;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(234, 9);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(0, 15);
            this.labelCurrentDate.TabIndex = 14;
            // 
            // progressBarBattery
            // 
            this.progressBarBattery.Location = new System.Drawing.Point(110, 115);
            this.progressBarBattery.Name = "progressBarBattery";
            this.progressBarBattery.Size = new System.Drawing.Size(163, 33);
            this.progressBarBattery.TabIndex = 15;
            // 
            // labelBattery
            // 
            this.labelBattery.AutoSize = true;
            this.labelBattery.Location = new System.Drawing.Point(174, 166);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(0, 15);
            this.labelBattery.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.labelBattery);
            this.Controls.Add(this.progressBarBattery);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonSleepMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonSleepMode;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.ProgressBar progressBarBattery;
        private System.Windows.Forms.Label labelBattery;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}