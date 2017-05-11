using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballscrew_temp_control
{
    public class Acc
    {
          public Acc(double xaxis, double yaxis, double zaxis)
        {
            this.Xaxis = xaxis;
            this.Yaxis = yaxis;
            this.Zaxis = zaxis;
        }

          public double Zaxis { get; set; }

          public double Xaxis { get; set; }

          public double Yaxis { get; set; }
    }
}
