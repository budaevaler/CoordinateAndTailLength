using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coordinate_and_tail_length
{
    class Sensor_part1 : IComparable
    {
        public string Name { get; private set; }
        public double TailLength { get; private set; }
        public Sensor_part1(string name, double tailLength)
        {
            Name = name;
            TailLength = tailLength;
        }

        int IComparable.CompareTo(object obj)
        {
            Sensor_part1 other = obj as Sensor_part1;
            return TailLength.CompareTo(other.TailLength);
        }
    }

    class Sensor_part2 : IComparable
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        double RecuiredTailLength { get; set; }
        public double NumberOfPat { get; set; }
        public Sensor_part2(double x, double y, double recuiredTailLength, double numberOfPat)
        {
            X = x;
            Y = y;
            RecuiredTailLength = recuiredTailLength;
            NumberOfPat = numberOfPat;
        }

        public int CompareTo(object obj)
        {
            Sensor_part2 other = obj as Sensor_part2;
            return RecuiredTailLength.CompareTo(other.RecuiredTailLength);
        }
    }

    public class Sensor_full
    {
        public string Name { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double TailLength { get; private set; }
        public double NumberOfPat { get; private set; }
        public Sensor_full(string name, double x, double y, double tailLength, double numberOfPat)
        {
            Name = name;
            X = x;
            Y = y;
            TailLength = tailLength;
            NumberOfPat = numberOfPat;
        }
    }
    public class Sensors
    {
        
        List<Sensor_full> sensors_full= new List<Sensor_full>();

        public Sensors(string name)
        {
            List<Sensor_part1> sensors_part1 = new List<Sensor_part1>();
            List<Sensor_part2> sensors_part2 = new List<Sensor_part2>();
            FileStream fs1=null;
            StreamReader sr1=null;
            
            try
            {
                fs1 = new FileStream("Data/Name_and_tail_length.txt", FileMode.Open, FileAccess.Read);
                sr1 = new StreamReader(fs1);


                string tempName = "1";
                string temp = "1";
                while (temp != null)
                {

                    temp = sr1.ReadLine();
                    string[] temp1 = temp.Split(';');
                    tempName = $"{temp1[1]}-{temp1[0]}-{temp1[2]}";
                    if (tempName.Contains(name))
                    {
                        sensors_part1.Add(new Sensor_part1(tempName, Convert.ToDouble(temp1[3])));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {


            }
            sensors_part1.Sort();
            FileStream fs2 = null;
            StreamReader sr2 = null;
            try
            {
                fs2 = new FileStream("Data/Сoordinates_and_required_tail_length.txt", FileMode.Open, FileAccess.Read);
                sr2 = new StreamReader(fs2);
                string temp;
                temp = "1";
                while (temp != null)
                {
                    

                    temp = sr2.ReadLine();
                    string[] temp1 = temp.Split(';');
                    sensors_part2.Add(new Sensor_part2(Convert.ToDouble(temp1[0]), Convert.ToDouble(temp1[1]), Convert.ToDouble(temp1[2]), Convert.ToDouble(temp1[3])));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
            sensors_part2.Sort();
            for (int i=0; i<sensors_part1.Count; i++)
            {
                sensors_full.Add(new Sensor_full(sensors_part1[i].Name, sensors_part2[i].X, sensors_part2[i].Y, sensors_part1[i].TailLength, sensors_part2[i].NumberOfPat));
            }
        }
        public Sensor_full Find(string name1)
        {
            for (int i=0; i<sensors_full.Count; i++)
            {
                if (sensors_full[i].Name == name1)
                {
                    return sensors_full[i];
                }
            }
            return null;
        }
        public int Count1()
        {
            return sensors_full.Count;
        }
        public List<Sensor_full> List()
        {
            return sensors_full;
        }
    }
}
