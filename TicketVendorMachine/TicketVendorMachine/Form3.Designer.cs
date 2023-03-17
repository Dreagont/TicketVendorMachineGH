
namespace TicketVendorMachine
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Button();
            this.qrcode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Payment";
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(49, 157);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(281, 114);
            this.credit.TabIndex = 1;
            this.credit.Text = "Credit Card";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.button1_Click);
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(480, 157);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(281, 114);
            this.qrcode.TabIndex = 2;
            this.qrcode.Text = "QR Code";
            this.qrcode.UseVisualStyleBackColor = true;
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 93);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Done);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.Button qrcode;
        private System.Windows.Forms.Button button1;
    }
}