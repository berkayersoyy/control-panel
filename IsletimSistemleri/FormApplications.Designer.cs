
namespace IsletimSistemleri
{
    partial class FormApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplications));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonCmd = new System.Windows.Forms.Button();
            this.buttonMagnifyingGlass = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // buttonCalculator
            // 
            this.buttonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculator.Image = global::IsletimSistemleri.Properties.Resources.icons8_calculator_50;
            this.buttonCalculator.Location = new System.Drawing.Point(89, 69);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(75, 61);
            this.buttonCalculator.TabIndex = 14;
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonCmd
            // 
            this.buttonCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCmd.Image = global::IsletimSistemleri.Properties.Resources.icons8_console_50;
            this.buttonCmd.Location = new System.Drawing.Point(204, 69);
            this.buttonCmd.Name = "buttonCmd";
            this.buttonCmd.Size = new System.Drawing.Size(75, 61);
            this.buttonCmd.TabIndex = 15;
            this.buttonCmd.UseVisualStyleBackColor = true;
            this.buttonCmd.Click += new System.EventHandler(this.buttonCmd_Click);
            // 
            // buttonMagnifyingGlass
            // 
            this.buttonMagnifyingGlass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMagnifyingGlass.Image = global::IsletimSistemleri.Properties.Resources.icons8_magnifying_glass_50;
            this.buttonMagnifyingGlass.Location = new System.Drawing.Point(89, 167);
            this.buttonMagnifyingGlass.Name = "buttonMagnifyingGlass";
            this.buttonMagnifyingGlass.Size = new System.Drawing.Size(75, 61);
            this.buttonMagnifyingGlass.TabIndex = 16;
            this.buttonMagnifyingGlass.UseVisualStyleBackColor = true;
            this.buttonMagnifyingGlass.Click += new System.EventHandler(this.buttonMagnifyingGlass_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowser.Image = global::IsletimSistemleri.Properties.Resources.icons8_browser_50;
            this.buttonBrowser.Location = new System.Drawing.Point(204, 167);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(75, 61);
            this.buttonBrowser.TabIndex = 17;
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonCalender_Click);
            // 
            // FormApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.buttonMagnifyingGlass);
            this.Controls.Add(this.buttonCmd);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulamalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonCmd;
        private System.Windows.Forms.Button buttonMagnifyingGlass;
        private System.Windows.Forms.Button buttonBrowser;
    }
}