
namespace IsletimSistemleri
{
    partial class FormMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitoring));
            this.spinnerCPU = new MetroFramework.Controls.MetroProgressSpinner();
            this.spinnerRam = new MetroFramework.Controls.MetroProgressSpinner();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spinnerCPU
            // 
            this.spinnerCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spinnerCPU.CustomBackground = true;
            this.spinnerCPU.Location = new System.Drawing.Point(27, 87);
            this.spinnerCPU.Maximum = 100;
            this.spinnerCPU.Name = "spinnerCPU";
            this.spinnerCPU.Size = new System.Drawing.Size(130, 117);
            this.spinnerCPU.Spinning = false;
            this.spinnerCPU.TabIndex = 0;
            this.spinnerCPU.UseSelectable = true;
            this.spinnerCPU.Click += new System.EventHandler(this.spinnerCPU_Click);
            // 
            // spinnerRam
            // 
            this.spinnerRam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spinnerRam.CustomBackground = true;
            this.spinnerRam.Location = new System.Drawing.Point(221, 87);
            this.spinnerRam.Maximum = 16000;
            this.spinnerRam.Name = "spinnerRam";
            this.spinnerRam.Size = new System.Drawing.Size(130, 117);
            this.spinnerRam.Spinning = false;
            this.spinnerRam.TabIndex = 1;
            this.spinnerRam.UseSelectable = true;
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
            this.buttonBack.TabIndex = 14;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(83, 219);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(0, 15);
            this.labelCPU.TabIndex = 15;
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(269, 219);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(0, 15);
            this.labelRam.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "RAM";
            // 
            // FormMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.spinnerRam);
            this.Controls.Add(this.spinnerCPU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanım İzleme";
            this.Load += new System.EventHandler(this.FormMonitoring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner spinnerCPU;
        private MetroFramework.Controls.MetroProgressSpinner spinnerRam;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}