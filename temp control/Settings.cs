using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Mode : byte{Auto = 0x41, Manual = 0x4D}
enum sensor : byte {Tempature = 0x54, IMU = 0x41}

namespace ballscrew_temp_control
{
    public partial class Settings : Form
    {

        private SaveFile AccFile;

        public SaveFile File
        {
            get { return AccFile; }
            set { AccFile = value; }
        }

        StringBuilder sb = new StringBuilder();
        byte[] TempSetting;

        public byte[] Temperature
        {
            get { return TempSetting; }
            set { TempSetting = value; }
        }
       byte[] IMUSetting;

       public byte[] IMU
       {
           get { return IMUSetting; }
           set { IMUSetting = value; }
       }

       byte Tempmode;
       byte IMUmode;
       byte Highb;
       byte Lowb;
        
        public Settings()
        {
            InitializeComponent();
            IMUmode = (byte)Mode.Manual;
            Tempmode = (byte)Mode.Manual;
        }

        private void Tempmodebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tempmodebox.Text == "Auto")
            {
                Tempmode = (byte)Mode.Auto;
                Temptimebox.Enabled = true;
            } 
            else
            {
                Tempmode = (byte)Mode.Manual;
                Temptimebox.Enabled = false;
            }
        }

        private void IMUmodebox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (IMUmodebox.Text == "Auto")
            {
                IMUmode = (byte)Mode.Auto;
                IMUtimebox.Enabled = true;
            }
            else
            {
                IMUmode = (byte)Mode.Manual;
                IMUtimebox.Enabled = false;

            }
        }

        private void Save_bn_Click(object sender, EventArgs e)
        {
            if (Tempmode == (byte)Mode.Auto && Temp_check.Checked)
            {
                UInt16 T;
               try{
                    T = UInt16.Parse( Temptimebox.Text.ToString());
               }
               catch(System.FormatException)
               {
                   T = 250;
               }


                if (T < 250)
                 {
                    T = 250;
                 }

                Highb = (byte)( T >> 8);
                Lowb = (byte)(T);
                TempSetting =  new byte[] {((byte)sensor.Tempature), (byte)Tempmode, Highb, Lowb, 0x30};
            }
            else 
            {
                TempSetting =  new byte[] {((byte)sensor.Tempature), (byte)Tempmode};
            }

             if (IMUmode == (char)Mode.Auto && IMU_check.Checked)
             {
                 short A = short.Parse( IMUtimebox.Text.ToString());
                 if (A < 10)
                 {
                      A = 10;
                 }

                 Highb = (byte)(A>>8);
                 Lowb = (byte)(A);
                 IMUSetting = new byte[] {((byte)sensor.IMU) , (byte)IMUmode, Highb, Lowb, 0x30};
             }             
             else 
             {
                 IMUSetting = new byte[] {((byte)sensor.IMU), (byte)IMUmode};
             }

            SaveFileDialog Save_menu = new SaveFileDialog();
            Save_menu.Filter = "Comma Seperated Values|*.csv";
            
            if(IMU_check.Checked)
            {
                if (Save_menu.ShowDialog() == DialogResult.OK)
                {
                    AccFile = new SaveFile(Save_menu.FileName,2);
                }
            }
            

             this.Dispose();
        }

        private void Temp_check_CheckedChanged(object sender, EventArgs e)
        {
            if(Temp_check.Checked)
            {
                Tempmodebox.Enabled = true;

            }
            else
            {
                Tempmodebox.Enabled = false;
            }

        }

        private void IMU_check_CheckedChanged(object sender, EventArgs e)
        {
            if (IMU_check.Checked)
            {
                IMUmodebox.Enabled = true;
            }
            else
            {
                IMUmodebox.Enabled = false;
            }

        }
    }
}
