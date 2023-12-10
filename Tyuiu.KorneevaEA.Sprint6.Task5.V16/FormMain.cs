using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorneevaEA.Sprint6.Task5.V16.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-3 Корнеева Елизавета Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        DataService ds = new DataService();
        string path = @"C:\Users\1\source\repos\Tyuiu.KorneevaEA.Sprint6\Tyuiu.KorneevaEA.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";


        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BMS.ColumnCount = 2;
            dataGridViewResult_BMS.Columns[0].Width = 20;
            dataGridViewResult_BMS.Columns[1].Width = 50;

            this.chartFunction_BMS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BMS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_BMS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BMS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_BMS.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpenFile_BMS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
