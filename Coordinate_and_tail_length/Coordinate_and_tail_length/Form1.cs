using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coordinate_and_tail_length
{
    public partial class Form1 : Form
    {

        public Sensors sensors;
        Graphics myGraphics;
        public Form1()
        {
            InitializeComponent();
            pbVC.Image = Image.FromFile("Data/VC.png");
        }
        double k = 0.15;
        int width = 20;
        int height = 20;
        void UpdateInfo()
        {
            pbVC.Refresh();
            string name = $"{cmbNumberOfLine.SelectedItem}-{cmbNameOfLine.SelectedItem}";
            sensors = new Sensors(name);
            string nameFind = $"{cmbNumberOfLine.SelectedItem}-{cmbNameOfLine.SelectedItem}-{cmbNumberOfSensor.SelectedItem}";
            txbX.Text = sensors.Find(nameFind).X.ToString();
            txbY.Text = sensors.Find(nameFind).Y.ToString();
            txbTailLength.Text = sensors.Find(nameFind).TailLength.ToString();
            txbNumberOfPat.Text = sensors.Find(nameFind).NumberOfPat.ToString();
            myGraphics = pbVC.CreateGraphics();
            myGraphics.TranslateTransform(150, 600);
            Pen myPen = new Pen(Color.Red, 4);
            Rectangle sens = new Rectangle((int)(sensors.Find(nameFind).X * k) - width / 2, -((int)(sensors.Find(nameFind).Y * k) + height / 2), width, height);
            this.Invalidate(sens, true);
            myGraphics.DrawEllipse(myPen, sens);
        }

        void UpdateInfo1(Sensor_full sensor)
        {
            string NamberOfSensor = sensor.Name.Substring(sensor.Name.Length-2);
            if (Int32.TryParse(NamberOfSensor, out int result) && result>0)
                cmbNumberOfSensor.SelectedIndex = result-1;
            else
            {
                NamberOfSensor = sensor.Name.Substring(sensor.Name.Length - 1);
                cmbNumberOfSensor.SelectedIndex = Convert.ToInt32(NamberOfSensor)-1;
            }
            
            pbVC.Refresh();
            txbX.Text = sensor.X.ToString();
            txbY.Text = sensor.Y.ToString();
            txbTailLength.Text = sensor.TailLength.ToString();
            txbNumberOfPat.Text = sensor.NumberOfPat.ToString();
            myGraphics = pbVC.CreateGraphics();
            myGraphics.TranslateTransform(150, 600);
            Pen myPen = new Pen(Color.Red, 4);
            Rectangle sens = new Rectangle((int)(sensor.X * k) - width / 2, -((int)(sensor.Y * k) + height / 2), width, height);
            this.Invalidate(sens, true);
            myGraphics.DrawEllipse(myPen, sens);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            pbVC.Enabled = true;
            UpdateInfo();
            btnTab.Enabled = true;
            
        }

        private void cmbNumberOfLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbNameOfLine.SelectedIndex > -1) && (cmbNumberOfLine.SelectedIndex > -1) && (cmbNumberOfSensor.SelectedIndex > -1)) { Find.Enabled = true;  }
        }

        private void cmbNameOfLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbNameOfLine.SelectedIndex > -1) && (cmbNumberOfLine.SelectedIndex > -1) && (cmbNumberOfSensor.SelectedIndex > -1)) { Find.Enabled = true; }
        }

        private void cmbNumberOfSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbNameOfLine.SelectedIndex > -1) && (cmbNumberOfLine.SelectedIndex > -1) && (cmbNumberOfSensor.SelectedIndex > -1)) { Find.Enabled = true; }
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            Table table = new Table(sensors);
            table.ShowDialog();
        }
        
        private void pbVC_Click(object sender, EventArgs e)
        {
           
        }

        private void pbVC_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void pbVC_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < sensors.Count1(); i++)
            {
                myGraphics = pbVC.CreateGraphics();
                myGraphics.TranslateTransform(150, 600);
                Rectangle sens = new Rectangle((int)(sensors.List()[i].X * k) - width / 2, -((int)(sensors.List()[i].Y * k) + height / 2), width, height);
                if (sens.Contains(new Point(e.X-150, e.Y-600)))
                    UpdateInfo1(sensors.List()[i]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbNameOfLine_SelectedValueChanged(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            List<int> NumberOfSensors = new List<int>();
            try
            {
                fs = new FileStream("Data/Name_and_tail_length.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string temp = "1";
                string[] s;
                while (temp != null)
                {
                    temp = sr.ReadLine();
                    s = temp.Split(';');
                    if ((s[0].ToString() + s[1].ToString()) == (cmbNameOfLine.SelectedItem.ToString() + cmbNumberOfLine.SelectedItem.ToString()))
                    {
                        int t = Convert.ToInt32(s[2]);
                        if (!NumberOfSensors.Contains(t))
                            NumberOfSensors.Add(t);
                    }
                    
                }
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
            cmbNumberOfSensor.Items.Clear();
            for (int i=0; i<NumberOfSensors.Count; i++)
                cmbNumberOfSensor.Items.Add(NumberOfSensors[i]);
            Find.Enabled = false;
            pbVC.Enabled = false;
        }

        private void cmbNumberOfLine_SelectedValueChanged(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            List<int> NumberOfSensors = new List<int>();
            try
            {
                fs = new FileStream("Data/Name_and_tail_length.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string temp = "1";
                string[] s;
                while (temp != null)
                {
                    temp = sr.ReadLine();
                    s = temp.Split(';');
                    if ((s[0].ToString() + s[1].ToString()) == (cmbNameOfLine.SelectedItem.ToString() + cmbNumberOfLine.SelectedItem.ToString()))
                    {
                        int t = Convert.ToInt32(s[2]);
                        if (!NumberOfSensors.Contains(t))
                            NumberOfSensors.Add(t);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }
            cmbNumberOfSensor.Items.Clear();
            for (int i = 0; i < NumberOfSensors.Count; i++)
                cmbNumberOfSensor.Items.Add(NumberOfSensors[i]);
            Find.Enabled = false;
            pbVC.Enabled = false;
        }
    }
}
