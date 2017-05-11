using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballscrew_temp_control
{
    public class TempList
    {
        double TempOne;
        double TempTwo;
        DateTime MeasureTime;

        public DateTime Time
        {
            get { return MeasureTime; }
            set { MeasureTime = value; }
        }
        public double ObjectTemp
        {
            get { return TempOne; }
            set { TempOne = value; }
        }

        public double AmbientTemp
        {
            get { return TempTwo; }
            set { TempTwo = value; }
        }

        public TempList(double Object, double Ambient, DateTime time)
        {
            this.ObjectTemp = Object;
            this.AmbientTemp = Ambient;
            this.Time = time;
        }
    }

    public class DualIR
    {
        double TempOne;
        double TempTwo;
        DateTime MeasureTime;

        public DateTime Time
        {
            get { return MeasureTime; }
            set { MeasureTime = value; }
        }
        public double ObjectTemp1
        {
            get { return TempOne; }
            set { TempOne = value; }
        }

        public double AmbientTemp1
        {
            get { return TempTwo; }
            set { TempTwo = value; }
        }

 
        public DualIR(double Object1, double Ambient1, double Object2, double Ambient2, int Position, DateTime time)
        {
            this.ObjectTemp1 = Object1;
            this.AmbientTemp1 = Ambient1;
            this.ObjectTemp2= Object2;
            this.AmbientTemp2 = Ambient2;
            this.position = Position;
            this.Time = time;
        }
     /*   public struct Mode
        {
            bool Time;

        }    */

        public double AmbientTemp2 { get; set; }

        public double ObjectTemp2 { get; set; }

        public int position { get; set; }
    }


    public class IR
    {
        public IR(double Object, double Ambient, int Position, DateTime time)
        {
            this.ObjectTemp = Object;
            this.AmbientTemp = Ambient;
            this.position = Position;
            this.Time = time;
        }
        public DateTime Time {get;set;}
        public double AmbientTemp { get; set; }
        public double ObjectTemp { get; set; }
        public int position { get; set; }
    }
}
