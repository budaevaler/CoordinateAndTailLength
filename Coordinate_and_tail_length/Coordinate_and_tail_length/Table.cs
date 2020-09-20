using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Coordinate_and_tail_length
{
    public partial class Table : Form
    {

        DataGridView dataGridView1 = new DataGridView();
        void Funtcion(Sensors sensors)
        {
            /*размер таблицы*/
            dataGridView1.Size = new Size(550, 655);
            dataGridView1.Location = new Point(0, 25);
            /*создание столбцов*/
            //1 столбец, текстовый
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "NameOfSensor";
            column0.HeaderText = "Имя зонда";
            //2 столбец, текстовый
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "X";
            column1.HeaderText = "X";
            //3 столбец
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Y";
            column2.HeaderText = "Y";
            //4 столбец
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "TailLength";
            column3.HeaderText = "Длина хвоста";
            //5 столбец
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "NumberOfPat";
            column4.HeaderText = "Номер патрубка";
            //добавляем столбцы
            dataGridView1.Columns.AddRange(column0, column1, column2, column3, column4);

            /*создание ячеек*/
            //ячейки для 1 строки
            for (int i = 0; i <sensors.Count1(); i++)
            {

                DataGridViewCell NameOfSensor = new DataGridViewTextBoxCell();
                DataGridViewCell X = new DataGridViewTextBoxCell();
                DataGridViewCell Y = new DataGridViewTextBoxCell();
                DataGridViewCell TailLength = new DataGridViewTextBoxCell();
                DataGridViewCell NumberOfPat = new DataGridViewTextBoxCell();
                NameOfSensor.Value = sensors.List()[i].Name.ToString();
                X.Value = sensors.List()[i].X;
                Y.Value = sensors.List()[i].Y;
                TailLength.Value = sensors.List()[i].TailLength;
                NumberOfPat.Value= sensors.List()[i].NumberOfPat;
                //создание строки
                DataGridViewRow row = new DataGridViewRow();
                //добавление ячеек в строку
                row.Cells.AddRange(NameOfSensor, X, Y, TailLength, NumberOfPat);
                //добавление строки в таблицу
                dataGridView1.Rows.Add(row);
            }
               
        }
        public Table(Sensors sensors)
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            Funtcion(sensors);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            
            string[] temp = dataGridView1.Rows[0].Cells[0].Value.ToString().Split('-');
            string filename = temp[0] + "-" + temp[1];
            try
            {
                fs = new FileStream($"{filename}.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        sw.Write(dataGridView1.Rows[j].Cells[i].Value+";");
                    }

                    sw.WriteLine();
                }


                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
