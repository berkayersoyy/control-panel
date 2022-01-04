
namespace IsletimSistemleri
{
    partial class FormMonitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitor));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButtonMaxPower = new System.Windows.Forms.RadioButton();
            this.radioButtonAveragePower = new System.Windows.Forms.RadioButton();
            this.radioButtonLowPower = new System.Windows.Forms.RadioButton();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 55);
            this.trackBar1.Maximum = 128;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(354, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 128;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButtonMaxPower
            // 
            this.radioButtonMaxPower.AutoSize = true;
            this.radioButtonMaxPower.Location = new System.Drawing.Point(139, 132);
            this.radioButtonMaxPower.Name = "radioButtonMaxPower";
            this.radioButtonMaxPower.Size = new System.Drawing.Size(109, 19);
            this.radioButtonMaxPower.TabIndex = 4;
            this.radioButtonMaxPower.TabStop = true;
            this.radioButtonMaxPower.Text = "Yüksek Parlaklık";
            this.radioButtonMaxPower.UseVisualStyleBackColor = true;
            this.radioButtonMaxPower.CheckedChanged += new System.EventHandler(this.radioButtonMaxPower_CheckedChanged);
            // 
            // radioButtonAveragePower
            // 
            this.radioButtonAveragePower.AutoSize = true;
            this.radioButtonAveragePower.Location = new System.Drawing.Point(139, 170);
            this.radioButtonAveragePower.Name = "radioButtonAveragePower";
            this.radioButtonAveragePower.Size = new System.Drawing.Size(121, 19);
            this.radioButtonAveragePower.TabIndex = 5;
            this.radioButtonAveragePower.TabStop = true;
            this.radioButtonAveragePower.Text = "Ortalama Parlaklık";
            this.radioButtonAveragePower.UseVisualStyleBackColor = true;
            this.radioButtonAveragePower.CheckedChanged += new System.EventHandler(this.radioButtonAveragePower_CheckedChanged);
            // 
            // radioButtonLowPower
            // 
            this.radioButtonLowPower.AutoSize = true;
            this.radioButtonLowPower.Location = new System.Drawing.Point(139, 208);
            this.radioButtonLowPower.Name = "radioButtonLowPower";
            this.radioButtonLowPower.Size = new System.Drawing.Size(105, 19);
            this.radioButtonLowPower.TabIndex = 6;
            this.radioButtonLowPower.TabStop = true;
            this.radioButtonLowPower.Text = "Düşük Parlaklık";
            this.radioButtonLowPower.UseVisualStyleBackColor = true;
            this.radioButtonLowPower.CheckedChanged += new System.EventHandler(this.radioButtonLowPower_CheckedChanged);
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
            this.buttonBack.TabIndex = 11;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.radioButtonLowPower);
            this.Controls.Add(this.radioButtonAveragePower);
            this.Controls.Add(this.radioButtonMaxPower);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekran Ayarları";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radioButtonMaxPower;
        private System.Windows.Forms.RadioButton radioButtonAveragePower;
        private System.Windows.Forms.RadioButton radioButtonLowPower;
        private System.Windows.Forms.Button buttonBack;
    }
}

