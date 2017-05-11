using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ballscrew_temp_control
{
    public partial class Graph : Form
    {
        UInt16 AxisY_MIN = 25 ;
        UInt16 AxisY_MAX = 27;
        public Graph(List<TempList> Data1, List<TempList> Data2)
        {
            InitializeComponent();
          
            chart_temp.Series["Object Temp1"].ChartType = SeriesChartType.FastLine;
            chart_temp.Series["Object Temp1"].Color = Color.Red;

            chart_temp.Series["Object Temp2"].ChartType = SeriesChartType.FastLine;
            chart_temp.Series["Object Temp2"].Color = Color.Green;

            chart_temp.Series["Abient Temp"].ChartType = SeriesChartType.FastLine;
            chart_temp.Series["Abient Temp"].Color = Color.Blue;

            chart_temp.ChartAreas[0].AxisY.Minimum = AxisY_MIN;
            chart_temp.ChartAreas[0].AxisY.Maximum = AxisY_MAX;


            foreach (TempList temp in Data1)
            {
                Update_Graph_add1(temp);

            }
             foreach (TempList temp in Data2)
            {
                Update_Graph_add2(temp);
            }
        }

        private void chart_temp_Click(object sender, EventArgs e)
        {
        }
        public void Update_Graph_add1(TempList Data1)
        {
            if (this.chart_temp.InvokeRequired)
            {
                chart_temp.Invoke((MethodInvoker)delegate() { Update_Graph_add1(Data1); });
            }
            else
            {
                chart_temp.Series["Object Temp1"].Points.AddY(Data1.ObjectTemp);
                chart_temp.Series["Abient Temp"].Points.AddY(Data1.AmbientTemp);
                if (Data1.AmbientTemp < AxisY_MIN)
                {
                    AxisY_MIN = (UInt16)Data1.AmbientTemp;
                }
                else if (Data1.ObjectTemp < AxisY_MIN)
                {
                    AxisY_MIN = (UInt16)(Data1.AmbientTemp - 1);
                }
                if (Data1.ObjectTemp > AxisY_MAX)
                {
                    AxisY_MAX = (UInt16)(Data1.ObjectTemp + 1);
                }
                else if(Data1.AmbientTemp > AxisY_MAX)
                {
                    AxisY_MAX = (UInt16)Data1.AmbientTemp;
                }
                chart_temp.ChartAreas[0].AxisY.Minimum = AxisY_MIN;
                chart_temp.ChartAreas[0].AxisY.Maximum = AxisY_MAX;
            }
        }
        public void Update_Graph_add2(TempList Data2)
        {
            if (this.chart_temp.InvokeRequired)
            {
                chart_temp.Invoke((MethodInvoker)delegate() { Update_Graph_add2( Data2); });
            }
            else
            {
                chart_temp.Series["Object Temp2"].Points.AddY(Data2.ObjectTemp);
            }  
        }
        public void Update_Graph(TempList Data1 , TempList Data2)
        {
            if (this.chart_temp.InvokeRequired)
            {
                chart_temp.Invoke((MethodInvoker)delegate() { Update_Graph(Data1, Data2); });
            }
            else
            {
                
                if (Data1.AmbientTemp < AxisY_MIN)
                {
                    AxisY_MIN = (UInt16)(Data1.AmbientTemp -1);
                    chart_temp.ChartAreas[0].AxisY.Minimum = AxisY_MIN;
                }
                if (Data1.ObjectTemp > AxisY_MAX)
                {
                    AxisY_MAX = (UInt16)(Data1.ObjectTemp+1);
                    chart_temp.ChartAreas[0].AxisY.Maximum = AxisY_MAX;
                }
                if (Data2.ObjectTemp > AxisY_MAX)
                {
                    AxisY_MAX = (UInt16)(Data2.ObjectTemp+1);
                    chart_temp.ChartAreas[0].AxisY.Maximum = AxisY_MAX;
                }

                if (Data2.ObjectTemp < AxisY_MIN)
                {
                    AxisY_MIN = (UInt16)(Data2.ObjectTemp-1);
                    chart_temp.ChartAreas[0].AxisY.Minimum = AxisY_MIN;
                }
                
                chart_temp.Series["Object Temp1"].Points.AddY(Data1.ObjectTemp);
                chart_temp.Series["Abient Temp"].Points.AddY(Data1.AmbientTemp);
                chart_temp.Series["Object Temp2"].Points.AddY(Data2.ObjectTemp);
            }
        }
        public void Clear_Graph()
        {
            if (this.chart_temp.InvokeRequired)
            {
                chart_temp.Invoke((MethodInvoker)delegate() { Clear_Graph(); });
            }
            else
            {
                chart_temp.Series["Object Temp1"].Points.Clear();
                chart_temp.Series["Object Temp2"].Points.Clear();
                chart_temp.Series["Abient Temp"].Points.Clear();
            }
        }

        private void Graph_FormClosing(object sender, FormClosingEventArgs e)
        {
            chart_temp.Dispose();
        }

    }
}
