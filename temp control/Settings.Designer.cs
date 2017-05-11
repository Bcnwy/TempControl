namespace ballscrew_temp_control
{
    partial class Settings
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
            this.Save_bn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tempmodebox = new System.Windows.Forms.ComboBox();
            this.IMUmodebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Temptimebox = new System.Windows.Forms.TextBox();
            this.IMUtimebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Temp_check = new System.Windows.Forms.CheckBox();
            this.IMU_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Save_bn
            // 
            this.Save_bn.Location = new System.Drawing.Point(12, 92);
            this.Save_bn.Name = "Save_bn";
            this.Save_bn.Size = new System.Drawing.Size(75, 23);
            this.Save_bn.TabIndex = 0;
            this.Save_bn.Text = "Save";
            this.Save_bn.UseVisualStyleBackColor = true;
            this.Save_bn.Click += new System.EventHandler(this.Save_bn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tempmodebox
            // 
            this.Tempmodebox.FormattingEnabled = true;
            this.Tempmodebox.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.Tempmodebox.Location = new System.Drawing.Point(12, 25);
            this.Tempmodebox.Name = "Tempmodebox";
            this.Tempmodebox.Size = new System.Drawing.Size(75, 21);
            this.Tempmodebox.TabIndex = 4;
            this.Tempmodebox.Text = "Manual";
            this.Tempmodebox.SelectedIndexChanged += new System.EventHandler(this.Tempmodebox_SelectedIndexChanged);
            // 
            // IMUmodebox
            // 
            this.IMUmodebox.Enabled = false;
            this.IMUmodebox.FormattingEnabled = true;
            this.IMUmodebox.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.IMUmodebox.Location = new System.Drawing.Point(12, 65);
            this.IMUmodebox.Name = "IMUmodebox";
            this.IMUmodebox.Size = new System.Drawing.Size(75, 21);
            this.IMUmodebox.TabIndex = 5;
            this.IMUmodebox.Text = "Manual";
            this.IMUmodebox.SelectedIndexChanged += new System.EventHandler(this.IMUmodebox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IMU:";
            // 
            // Temptimebox
            // 
            this.Temptimebox.Enabled = false;
            this.Temptimebox.Location = new System.Drawing.Point(93, 26);
            this.Temptimebox.Name = "Temptimebox";
            this.Temptimebox.Size = new System.Drawing.Size(75, 20);
            this.Temptimebox.TabIndex = 8;
            // 
            // IMUtimebox
            // 
            this.IMUtimebox.Enabled = false;
            this.IMUtimebox.Location = new System.Drawing.Point(93, 66);
            this.IMUtimebox.Name = "IMUtimebox";
            this.IMUtimebox.Size = new System.Drawing.Size(75, 20);
            this.IMUtimebox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Update (ms):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Update (ms):";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // Temp_check
            // 
            this.Temp_check.AutoSize = true;
            this.Temp_check.Checked = true;
            this.Temp_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Temp_check.Location = new System.Drawing.Point(174, 29);
            this.Temp_check.Name = "Temp_check";
            this.Temp_check.Size = new System.Drawing.Size(15, 14);
            this.Temp_check.TabIndex = 12;
            this.Temp_check.UseVisualStyleBackColor = true;
            this.Temp_check.CheckedChanged += new System.EventHandler(this.Temp_check_CheckedChanged);
            // 
            // IMU_check
            // 
            this.IMU_check.AutoSize = true;
            this.IMU_check.Location = new System.Drawing.Point(174, 69);
            this.IMU_check.Name = "IMU_check";
            this.IMU_check.Size = new System.Drawing.Size(15, 14);
            this.IMU_check.TabIndex = 13;
            this.IMU_check.UseVisualStyleBackColor = true;
            this.IMU_check.CheckedChanged += new System.EventHandler(this.IMU_check_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 126);
            this.Controls.Add(this.IMU_check);
            this.Controls.Add(this.Temp_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IMUtimebox);
            this.Controls.Add(this.Temptimebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IMUmodebox);
            this.Controls.Add(this.Tempmodebox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save_bn);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_bn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Tempmodebox;
        private System.Windows.Forms.ComboBox IMUmodebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Temptimebox;
        private System.Windows.Forms.TextBox IMUtimebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox Temp_check;
        private System.Windows.Forms.CheckBox IMU_check;
    }
}