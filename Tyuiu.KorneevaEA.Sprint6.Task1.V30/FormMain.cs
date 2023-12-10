using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorneevaEA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task1.V30
{
	public partial class FormMain : Form
	{
		DataService ds = new DataService();
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
			try
			{
				int startValue = Convert.ToInt32(textBoxStartValue_SRR.Text);
				int stopValue = Convert.ToInt32(textBoxStopValue_SRR.Text);

				string strLine;

				int len = ds.GetMassFunction(startValue, stopValue).Length;

				double[] valueArray;
				valueArray = new double[len];

				valueArray = ds.GetMassFunction(startValue, stopValue);
				textBoxResult_SRR.Text = "";
				textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);
				textBoxResult_SRR.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
				textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);
				for (int i = 0; i < len; i++)
				{
					strLine = String.Format("|{0,5:d}      |  {1,7:f2}   |", startValue, valueArray[i]);
					textBoxResult_SRR.AppendText(strLine + Environment.NewLine);
					startValue++;
				}
				textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);
			}
			catch
			{
				MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonInfo_SRR_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-3 Корнеева Елизавета Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}
