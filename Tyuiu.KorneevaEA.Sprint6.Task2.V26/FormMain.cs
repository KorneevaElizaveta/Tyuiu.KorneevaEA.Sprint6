using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorneevaEA.Sprint6.Task2.V26.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void ButtonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(TextBoxStart_KEA.Text);
                int stopStep = Convert.ToInt32(TextBoxStop_KEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.Chart_KEA.Titles.Add("График функции");
                this.Chart_KEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_KEA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.DataGridView_KEA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.Chart_KEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonDone_KEA_MouseEnter(object sender, EventArgs e)
        {
            ButtonDone_KEA.BackColor = Color.Red;
        }

        private void ButtonDone_KEA_MouseLeave(object sender, EventArgs e)
        {
            ButtonDone_KEA.BackColor = Color.Green;
        }

        private void ButtonDone_KEA_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonDone_KEA.BackColor = Color.Blue;
        }

        private void ButtonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-3 Корнеева Елизавета Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
