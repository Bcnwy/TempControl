namespace ballscrew_temp_control
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connect_bn = new System.Windows.Forms.Button();
            this.Disconnect_bn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.objecttext = new System.Windows.Forms.RichTextBox();
            this.ambienttext = new System.Windows.Forms.RichTextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Graph_bn = new System.Windows.Forms.Button();
            this.Clear_bn = new System.Windows.Forms.Button();
            this.Sample_bn = new System.Windows.Forms.Button();
            this.Setting_bn = new System.Windows.Forms.Button();
            this.File_bn = new System.Windows.Forms.Button();
            this.Disconnect_bn2 = new System.Windows.Forms.Button();
            this.Connect_bn2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.postext = new System.Windows.Forms.RichTextBox();
            this.mea_heat_ckbox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Sensor_input_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // connect_bn
            // 
            this.connect_bn.Location = new System.Drawing.Point(130, 10);
            this.connect_bn.Name = "connect_bn";
            this.connect_bn.Size = new System.Drawing.Size(75, 23);
            this.connect_bn.TabIndex = 1;
            this.connect_bn.Text = "Connect";
            this.connect_bn.UseVisualStyleBackColor = true;
            this.connect_bn.Click += new System.EventHandler(this.connect_bn_Click);
            // 
            // Disconnect_bn
            // 
            this.Disconnect_bn.Enabled = false;
            this.Disconnect_bn.Location = new System.Drawing.Point(211, 10);
            this.Disconnect_bn.Name = "Disconnect_bn";
            this.Disconnect_bn.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_bn.TabIndex = 2;
            this.Disconnect_bn.Text = "Disconnect";
            this.Disconnect_bn.UseVisualStyleBackColor = true;
            this.Disconnect_bn.Click += new System.EventHandler(this.Disconnect_bn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(436, 288);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ambient";
            // 
            // objecttext
            // 
            this.objecttext.Location = new System.Drawing.Point(455, 231);
            this.objecttext.Multiline = false;
            this.objecttext.Name = "objecttext";
            this.objecttext.ReadOnly = true;
            this.objecttext.Size = new System.Drawing.Size(68, 29);
            this.objecttext.TabIndex = 6;
            this.objecttext.Text = "";
            this.objecttext.WordWrap = false;
            this.objecttext.TextChanged += new System.EventHandler(this.objecttext_TextChanged);
            // 
            // ambienttext
            // 
            this.ambienttext.Location = new System.Drawing.Point(455, 279);
            this.ambienttext.Multiline = false;
            this.ambienttext.Name = "ambienttext";
            this.ambienttext.ReadOnly = true;
            this.ambienttext.Size = new System.Drawing.Size(68, 29);
            this.ambienttext.TabIndex = 7;
            this.ambienttext.Text = "";
            this.ambienttext.WordWrap = false;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(292, 10);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Graph_bn
            // 
            this.Graph_bn.Location = new System.Drawing.Point(454, 10);
            this.Graph_bn.Name = "Graph_bn";
            this.Graph_bn.Size = new System.Drawing.Size(75, 76);
            this.Graph_bn.TabIndex = 9;
            this.Graph_bn.Text = "Graph";
            this.Graph_bn.UseVisualStyleBackColor = true;
            this.Graph_bn.Click += new System.EventHandler(this.Graph_bn_Click);
            // 
            // Clear_bn
            // 
            this.Clear_bn.Location = new System.Drawing.Point(373, 10);
            this.Clear_bn.Name = "Clear_bn";
            this.Clear_bn.Size = new System.Drawing.Size(75, 23);
            this.Clear_bn.TabIndex = 10;
            this.Clear_bn.Text = "Clear";
            this.Clear_bn.UseVisualStyleBackColor = true;
            this.Clear_bn.Click += new System.EventHandler(this.Clear_bn_Click);
            // 
            // Sample_bn
            // 
            this.Sample_bn.Location = new System.Drawing.Point(454, 92);
            this.Sample_bn.Name = "Sample_bn";
            this.Sample_bn.Size = new System.Drawing.Size(75, 23);
            this.Sample_bn.TabIndex = 11;
            this.Sample_bn.Text = "Sample";
            this.Sample_bn.UseVisualStyleBackColor = true;
            this.Sample_bn.Click += new System.EventHandler(this.Sample_bn_Click);
            // 
            // Setting_bn
            // 
            this.Setting_bn.Location = new System.Drawing.Point(454, 121);
            this.Setting_bn.Name = "Setting_bn";
            this.Setting_bn.Size = new System.Drawing.Size(75, 23);
            this.Setting_bn.TabIndex = 12;
            this.Setting_bn.Text = "Auto";
            this.Setting_bn.UseVisualStyleBackColor = true;
            this.Setting_bn.Click += new System.EventHandler(this.Setting_bn_Click);
            // 
            // File_bn
            // 
            this.File_bn.Location = new System.Drawing.Point(454, 150);
            this.File_bn.Name = "File_bn";
            this.File_bn.Size = new System.Drawing.Size(75, 23);
            this.File_bn.TabIndex = 13;
            this.File_bn.Text = "File";
            this.File_bn.UseVisualStyleBackColor = true;
            this.File_bn.Click += new System.EventHandler(this.File_bn_Click);
            // 
            // Disconnect_bn2
            // 
            this.Disconnect_bn2.Enabled = false;
            this.Disconnect_bn2.Location = new System.Drawing.Point(211, 37);
            this.Disconnect_bn2.Name = "Disconnect_bn2";
            this.Disconnect_bn2.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_bn2.TabIndex = 16;
            this.Disconnect_bn2.Text = "Disconnect";
            this.Disconnect_bn2.UseVisualStyleBackColor = true;
            this.Disconnect_bn2.Click += new System.EventHandler(this.Disconnect_bn2_Click);
            // 
            // Connect_bn2
            // 
            this.Connect_bn2.Location = new System.Drawing.Point(130, 37);
            this.Connect_bn2.Name = "Connect_bn2";
            this.Connect_bn2.Size = new System.Drawing.Size(75, 23);
            this.Connect_bn2.TabIndex = 15;
            this.Connect_bn2.Text = "Connect";
            this.Connect_bn2.UseVisualStyleBackColor = true;
            this.Connect_bn2.Click += new System.EventHandler(this.Connect_bn2_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.PortName = "COM9";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // postext
            // 
            this.postext.BackColor = System.Drawing.SystemColors.Control;
            this.postext.Location = new System.Drawing.Point(455, 183);
            this.postext.Name = "postext";
            this.postext.Size = new System.Drawing.Size(69, 29);
            this.postext.TabIndex = 7;
            this.postext.Text = "";
            this.postext.TextChanged += new System.EventHandler(this.postext_TextChanged);
            // 
            // mea_heat_ckbox
            // 
            this.mea_heat_ckbox.AutoSize = true;
            this.mea_heat_ckbox.Location = new System.Drawing.Point(455, 314);
            this.mea_heat_ckbox.Name = "mea_heat_ckbox";
            this.mea_heat_ckbox.Size = new System.Drawing.Size(93, 17);
            this.mea_heat_ckbox.TabIndex = 18;
            this.mea_heat_ckbox.Text = "Measure Heat";
            this.mea_heat_ckbox.UseVisualStyleBackColor = true;
            this.mea_heat_ckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(455, 337);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Heating Cycle";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Sensor_input_box
            // 
            this.Sensor_input_box.Location = new System.Drawing.Point(292, 39);
            this.Sensor_input_box.Name = "Sensor_input_box";
            this.Sensor_input_box.Size = new System.Drawing.Size(156, 21);
            this.Sensor_input_box.TabIndex = 21;
            this.Sensor_input_box.Text = "";
            this.Sensor_input_box.TextChanged += new System.EventHandler(this.Sensor_input_box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 495);
            this.Controls.Add(this.Sensor_input_box);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.mea_heat_ckbox);
            this.Controls.Add(this.postext);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Disconnect_bn2);
            this.Controls.Add(this.Connect_bn2);
            this.Controls.Add(this.File_bn);
            this.Controls.Add(this.Setting_bn);
            this.Controls.Add(this.Sample_bn);
            this.Controls.Add(this.Clear_bn);
            this.Controls.Add(this.Graph_bn);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.ambienttext);
            this.Controls.Add(this.objecttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Disconnect_bn);
            this.Controls.Add(this.connect_bn);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "TMP007 Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect_bn;
        private System.Windows.Forms.Button Disconnect_bn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox objecttext;
        private System.Windows.Forms.RichTextBox ambienttext;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Graph_bn;
        private System.Windows.Forms.Button Clear_bn;
        private System.Windows.Forms.Button Sample_bn;
        private System.Windows.Forms.Button Setting_bn;
        private System.Windows.Forms.Button File_bn;
        private System.Windows.Forms.Button Disconnect_bn2;
        private System.Windows.Forms.Button Connect_bn2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox postext;
        private System.Windows.Forms.CheckBox mea_heat_ckbox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox Sensor_input_box;
    }
}

