using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballscrew_temp_control
{
    public class SaveFile
    {
        private string filePath;
        private string[] Header = { "Object Temperature", "Ambient Temperature", "Time" };
        private string[] Header2 = { "Object Temperature 1", "Ambient Temperature 1", "Time", "Object Temperature 2", "Ambient Temperature 2", "Time" };
        private string[] Header3 = { "pos1", "pos2", "pos3", "pos4", " pos5", "pos6", "pos7", "pos8", "pos9", "pos10", "pos11", "pos12", "pos13", "pos14", "pos15", "pos16", "pos17", "pos18", "pos19"};
        private string[] Header4 = { "Object Temperature", "Ambient Temperature", "Time", "Position" };
        private string delimiter = ",";
       // private string NLine = ";";
        StringBuilder sb = new StringBuilder();
       // StringBuilder pos1,pos2,pos3,pos4,pos5,pos6,pos7,pos8,pos9,pos10 = new StringBuilder();
       
        List<string> output = new List<string>();  
        public string FilePath
        {
            get { return filePath; }
            set { filePath = @"C:\Users\u1056080\Documents\" + value + ".csv"; }
        }
        
        public SaveFile(string path, int header)
        {
            
            this.filePath = path;

            if (!File.Exists(filePath))
            {
                if (header == 1)
                {
                    File.Create(filePath).Close();
                    sb.AppendLine(string.Join(delimiter, Header));
                    File.AppendAllText(filePath, sb.ToString());
                    sb.Clear();
                }
                else if(header == 2)
                {
                    File.Create(filePath).Close();
                    sb.AppendLine(string.Join(delimiter, Header2));
                    File.AppendAllText(filePath, sb.ToString());
                    sb.Clear();
                }
                else if(header ==3)
                {
                    File.Create(filePath).Close();
                    sb.AppendLine(string.Join(delimiter, Header3));
                    File.AppendAllText(filePath, sb.ToString());
                    sb.Clear();
                }
                else if(header == 4)
                {
                    File.Create(filePath).Close();
                    sb.AppendLine(string.Join(delimiter, Header4));
                    File.AppendAllText(filePath, sb.ToString());
                    sb.Clear();
                }
            }
        }

        public void Save(List<TempList> Data)
        {
            foreach (TempList temp in Data)
            {
                string[] output = { temp.ObjectTemp.ToString(), temp.AmbientTemp.ToString(), temp.Time.ToString()};
                sb.AppendLine((string.Join(delimiter, output)));
            }
            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();
        }
         public void Save(List<DualIR>[] Data)
        {
            //StringBuilder output;  
           int size = Data.GetLength(1);
                /*   foreach(DualIR temp in Data[1])
                 {
                     string[] T = { temp.ObjectTemp1.ToString(), temp.ObjectTemp2.ToString()};
                     
                     sb.AppendLine((string.Join(delimiter, T)));
                    
                 }*/
             
             int x;
             for(int i = 1; i<=19; i++)
             {
                x = (i-1)*2;
                 foreach(DualIR temp in Data[i])
                 {
                     string[] T = { temp.ObjectTemp1.ToString(), temp.ObjectTemp2.ToString()};
                     sb.Insert(x,(string.Join(delimiter, T)));
                     x += 2 * i;
                 } 
             }  
             File.AppendAllText(filePath, sb.ToString());
             sb.Clear();
        }

        public void Save(List<TempList> Data, List<TempList> Data2)
        {
            Save(Data);
            File.AppendAllText(filePath, "Sensor 3\r");
            Save(Data2);
        }


        public void Save_ballscrew(List<List<TempList>> Data)
        {
            string s;
            foreach (List<TempList> templist in Data)
            {
                foreach (TempList temp in templist)
                {
                    s = temp.ObjectTemp.ToString();
                    output.Add(s);
                }
                sb.AppendLine(string.Join(delimiter, output));
                output.Clear();
            }
            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();
        }
        public void save_pos(List<int> p)
        {
            foreach (int i in p)
            {
                sb.AppendLine(string.Join(delimiter, i.ToString()));
            }
            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();
        }

        public void Save(List<IR> Data)
        {
            
                foreach (IR temp in Data)
                {
                    string[] T = { temp.ObjectTemp.ToString(),temp.AmbientTemp.ToString(), temp.Time.ToString(), temp.position.ToString()};
                    sb.AppendLine(string.Join(delimiter, T));
                  
            }
            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();
        }
    }
}