using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using System.Timers;

namespace ballscrew_temp_control
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(300);

        List<TempList> Temp1 = new List<TempList>();
        List<TempList> Temp2 = new List<TempList>();
        List<TempList> Temp3 = new List<TempList>();
        List<DualIR>[]  dualir = new List<DualIR>[19];
        List<TempList>[] Ballscrew = new List<TempList>[19];
        List<IR> IR = new List<IR>();

        List<TempList> Pos1 = new List<TempList>();
        List<TempList> Pos2 = new List<TempList>();
        List<TempList> Pos3 = new List<TempList>();
        List<TempList> Pos4 = new List<TempList>();
        List<TempList> Pos5 = new List<TempList>();
        List<TempList> Pos6 = new List<TempList>();
        List<TempList> Pos7 = new List<TempList>();
        List<TempList> Pos8 = new List<TempList>();
        List<TempList> Pos9 = new List<TempList>();

        List<TempList> Pos10 = new List<TempList>();
        List<TempList> Pos11 = new List<TempList>();
        List<TempList> Pos12 = new List<TempList>();
        List<TempList> Pos13 = new List<TempList>();
        List<TempList> Pos14 = new List<TempList>();
        List<TempList> Pos15 = new List<TempList>();
        List<TempList> Pos16 = new List<TempList>();
        List<TempList> Pos17 = new List<TempList>();
        List<TempList> Pos18 = new List<TempList>();

        List<TempList> Pos19 = new List<TempList>();
        List<int> Poslist = new List<int>();

        //bool acc_mode = false;
        bool Graph = false;
        Graph graph;
        Settings settings;
        DateTime StartTime;
        DateTime LastTime = new DateTime(0);
        //bool manual_sample = false;
        bool clear_sample = true;
        int Pos=1;
        int loop = 0;
        int Posdirection = 1;
        bool heating = false;
        //True Takes samples while in the heating phase
        public bool mea_heat = false;
        public bool heat_pos = false;
        private int nSensors = 1;
        private int sensread = 0;
        private int readlim = 100;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string[] ports2 = SerialPort.GetPortNames();
            comboBox1.DataSource = ports;
            comboBox2.DataSource = ports2;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                serialPort1.Dispose();
                serialPort2.Dispose();
                timer.Dispose();
            }
            catch (Exception)
            {
                
                throw new NotImplementedException();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.GetItemText(comboBox1.SelectedItem);
           // settext(serialPort1.PortName);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort2.PortName = comboBox2.GetItemText(comboBox2.SelectedItem);
            //settext(serialPort2.PortName);
        }

        private void connect_bn_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 57600;
            serialPort1.Open();
            StartTime = DateTime.Now;
            connect_bn.Enabled = false;
            Disconnect_bn.Enabled = true;
            if (serialPort1.IsOpen)
            {
                settings = new Settings();
                settings.Disposed += new EventHandler(Settings_disposed);
                settings.Show();
            }
        }

        private void Settings_disposed(object sender, EventArgs e)
        {
            //serialPort1.Write("S");
            serialPort1.Write(settings.Temperature, 0, settings.Temperature.Length);
           // serialPort1.Write(settings.IMU, 0, settings.IMU.Length);
            serialPort1.WriteLine("F");
        }
        private void Disconnect_bn_Click(object sender, EventArgs e)
        {
            try
            {   
                timer.Stop();
                serialPort1.Close();
                Disconnect_bn.Enabled = false;
                connect_bn.Enabled = true;
                
            }
            catch (System.IndexOutOfRangeException)
            {
                throw;
            }
            catch (System.InvalidOperationException)
            {
                throw;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            temp();         
        }

        private void temp()
        {
            string read;
            try
            {
                //settext("Reading");
                read = serialPort1.ReadLine();
                serialPort1.DiscardInBuffer();

                DateTime Time = DateTime.Now;
                /*TimeSpan diftime = (Time - LastTime); 
                LastTime = DateTime.Now;
                settext(diftime.Seconds.ToString());
                settext(".");
                settext(diftime.Milliseconds.ToString());
                settext("\n");*/
                settext(read);
              //  Pos = 1;
                if(!heating || mea_heat)
                { 
                    string[] sensorRead = read.Split(',');
                    setobjecttext(sensorRead[1]);
                    setambienttext(sensorRead[2]);
                    setpostext(sensorRead[3]);
                    IR tIR = new IR((double.Parse(sensorRead[1])), (double.Parse(sensorRead[2])), (int.Parse(sensorRead[3])), Time);
                    TempList t = new TempList((double.Parse(sensorRead[1])), (double.Parse(sensorRead[2])), Time);
                    Temp1.Add(t);
                    IR.Add(tIR);
                    if (Graph == true)
                    {
                        graph.Update_Graph_add1(t);
                    }
                }
              
            }
            catch (System.IndexOutOfRangeException)
            {
                settext("Serial Data Incorrect");
            }
            catch (System.IO.IOException)
            {
                settext("Serial Data Incorrect");
            }
        }

        public void settext(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((MethodInvoker)delegate() { settext(text); });
            }
            else
            {
                richTextBox1.AppendText(text);
                richTextBox1.AppendText("\r");
            }
        }
        private void setobjecttext(string text)
        {
            if (this.objecttext.InvokeRequired)
            {
                objecttext.Invoke((MethodInvoker)delegate() { setobjecttext(text); });
            }
            else
            {
                objecttext.Text = text;
            }
        }
        private void setpostext(string text)
        {
            if (this.objecttext.InvokeRequired)
            {
                postext.Invoke((MethodInvoker)delegate() { setpostext(text); });
            }
            else
            {
                postext.Text = text;
            }
        }

        private void setambienttext(string text)
        {
            if (this.ambienttext.InvokeRequired)
            {
                ambienttext.Invoke((MethodInvoker)delegate() { setambienttext(text); });
            }
            else
            {
                ambienttext.Text = text;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save_menu = new SaveFileDialog();
            Save_menu.Filter = "Comma Seperated Values|*.csv";

            if (Save_menu.ShowDialog() == DialogResult.OK)
            {
              /*List<List<TempList>> position_array = new List<List<TempList>>();
                position_array.Add(Pos1);
                position_array.Add(Pos2);
                position_array.Add(Pos3);
                position_array.Add(Pos4);
                position_array.Add(Pos5);
                position_array.Add(Pos6);
                position_array.Add(Pos7);
                position_array.Add(Pos8);
                position_array.Add(Pos9);
                position_array.Add(Pos10);
                position_array.Add(Pos11);
                position_array.Add(Pos12);
                position_array.Add(Pos13);
                position_array.Add(Pos14);
                position_array.Add(Pos15);
                position_array.Add(Pos16);
                position_array.Add(Pos17);
                position_array.Add(Pos18);
                position_array.Add(Pos19);
                SaveFile File = new SaveFile(Save_menu.FileName,4);
                File.Save_ballscrew(position_array);
                Temp.Clear();*/
                SaveFile File = new SaveFile(Save_menu.FileName, 4);
                File.Save(IR);
                settext("Saved");
            }
        }

        private void Clear_bn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Temp1.Clear();
            Temp2.Clear();
            Temp3.Clear();
            IR.Clear();
            Pos1.Clear();
            Pos2.Clear();
            Pos3.Clear();
            Pos4.Clear();
            Pos5.Clear();
            Pos6.Clear();
            Pos7.Clear();
            Pos8.Clear();
            Pos9.Clear();
            Pos10.Clear();
            Pos11.Clear();
            Pos12.Clear();
            Pos13.Clear();
            Pos14.Clear();
            Pos15.Clear();
            Pos16.Clear();
            Pos17.Clear();
            Pos18.Clear();
            Pos19.Clear();
            StartTime = DateTime.Now;
            if (Graph)
            {
                graph.Clear_Graph();
            }
        }

        private void Graph_bn_Click(object sender, EventArgs e)
        {
            graph = new Graph(Temp1, Temp2);
            Graph = true;
            graph.Disposed += new EventHandler(Graph_disposed);
            graph.Show();
        }

        private void Graph_disposed(object sender, EventArgs e)
        {
            Graph = false;
        }

        private void Sample_bn_Click(object sender, EventArgs e)
        {
            if (clear_sample)
            {
                try
                {
                    serialPort1.WriteLine("R");
                }
                catch (System.InvalidOperationException)
                {
                    settext("Serial Data Incorrect");
                }
            }
        }

        private void Setting_bn_Click(object sender, EventArgs e)
        {
               timer.Elapsed += HandleTimer;
               timer.AutoReset = true;
               timer.Start();
        }

        private void HandleTimer(Object source, ElapsedEventArgs e)
        {
           
            if (clear_sample && sensread < readlim)
            {
                try
                {
                    serialPort1.WriteLine("R");
                }
                catch (System.InvalidOperationException)
                {
                    settext("Serial Data Incorrect");
                }
                catch(System.IndexOutOfRangeException)
                { throw; }
                sensread++;
            }
        }

        private void File_bn_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save_menu = new SaveFileDialog();
            Save_menu.Filter = "Comma Seperated Values|*.csv";

            if (Save_menu.ShowDialog() == DialogResult.OK)
            {
              SaveFile dualir_file = new SaveFile(Save_menu.FileName, 1);
              dualir_file.Save(Temp3); 
            }
        }

        private void Acc_bn_Click(object sender, EventArgs e)
        {
        }

        private void Connect_bn2_Click(object sender, EventArgs e)
        {
            serialPort2.BaudRate = 115200;
            serialPort2.Open();
            Connect_bn2.Enabled = false;
            Disconnect_bn2.Enabled = true;
        }

        private void Disconnect_bn2_Click(object sender, EventArgs e)
        {
            serialPort2.Close();
            Disconnect_bn2.Enabled = false;
            Connect_bn2.Enabled = true;
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte indata;
            try
            {
                indata = (byte)serialPort2.ReadByte();
                if (indata == '1')
                {
                    clear_sample = true;
                    timer.Start();
                }
                else
                {
                    clear_sample = false;
                    position();
                    timer.Stop();
                }
            }
            catch (Exception)
            {
                throw;
            }
            sensread = 0;
        }
        private void position()
        {
            if (heating && heat_pos)
            {
                if (Pos >= 10)
                {
                    settext("neg heating");
                    loop++;
                    Pos = 1;
                }
                else if(Pos<=1)
                {
                    Pos = 10;
                    settext("pos heating");
                }
                setpostext(Pos.ToString());
                if (loop >= 21)
                {
                    heating = false;
                    loop = 0;
                    Pos = 1;
                }
            }
            else
            {
                if (Posdirection == 0) Pos--;
                else Pos++;
                setpostext(Pos.ToString() );
                if (Pos >= 19)
                {
                    Posdirection = 0;
                    settext("neg sample");
                }
                else if (Pos <= 1)
                {
                    Posdirection = 1;
                    settext("pos sample");
                    loop++;
                }
              
                if (loop >= 2)
                {
                    if (heat_pos) heating = true;
                    Pos = 1;
                    loop = 0;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mea_heat_ckbox.Checked)
            {
                mea_heat = true;
                heat_pos = true;
                checkBox2.Checked = true;
            }
            else
            {
                mea_heat = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                heat_pos = true;
            }
            else heat_pos = false;
        }

        private void postext_TextChanged(object sender, EventArgs e)
        {
            Pos = Int32.Parse(postext.Text.ToString());
        }

        private void Sensor_input_box_TextChanged(object sender, EventArgs e)
        {
            nSensors = int.Parse( Sensor_input_box.Text);
        }

        private void objecttext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}