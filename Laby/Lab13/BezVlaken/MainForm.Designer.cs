
namespace BezVlaken
{
    partial class MainForm
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
            this.BtnAkce = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.PbPostup = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnAkce
            // 
            this.BtnAkce.Location = new System.Drawing.Point(423, 90);
            this.BtnAkce.Name = "BtnAkce";
            this.BtnAkce.Size = new System.Drawing.Size(193, 53);
            this.BtnAkce.TabIndex = 0;
            this.BtnAkce.Text = "Akce";
            this.BtnAkce.UseVisualStyleBackColor = true;
            this.BtnAkce.Click += new System.EventHandler(this.BtnAkce_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(116, 107);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(38, 15);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = "label1";
            // 
            // PbPostup
            // 
            this.PbPostup.Location = new System.Drawing.Point(111, 192);
            this.PbPostup.Name = "PbPostup";
            this.PbPostup.Size = new System.Drawing.Size(504, 40);
            this.PbPostup.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbPostup);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnAkce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAkce;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.ProgressBar PbPostup;
    }
}

