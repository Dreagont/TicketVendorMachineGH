
namespace TicketVendorMachine
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.vehicle = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.fee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle";
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "Super Market",
            "School",
            "Hospital",
            "Internet Cafe"});
            this.location.Location = new System.Drawing.Point(256, 50);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(304, 24);
            this.location.TabIndex = 3;
            this.location.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vehicle
            // 
            this.vehicle.FormattingEnabled = true;
            this.vehicle.Items.AddRange(new object[] {
            "Bus",
            "Taxi",
            "Train",
            "UFO"});
            this.vehicle.Location = new System.Drawing.Point(256, 199);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(304, 24);
            this.vehicle.TabIndex = 4;
            this.vehicle.SelectedIndexChanged += new System.EventHandler(this.vehicle_SelectedIndexChanged);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(256, 129);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(304, 22);
            this.time.TabIndex = 5;
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(590, 276);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(140, 22);
            this.fee.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fee";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(304, 333);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(193, 50);
            this.done.TabIndex = 8;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.time);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.ComboBox vehicle;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button done;
    }
}