using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KorneevaEA.Sprint6.Task3.V20.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {{-14,17,-19,3,2},
                                     {-4,-14,-19,-9,-1},
                                     {1,0,13,14,8},
                                     {13,7,8,-3,-15},
                                     {2,-20,12,-14,4}};

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KEA.ColumnCount = columns;
            dataGridViewMatrix_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KEA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewMatrix_KEA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void textBoxUslovie_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPushMe_KEA_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            mtrx = ds.Calculate(mtrx);

            string matrix = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix += mtrx[i, j].ToString();
                    matrix += "   ";
                }

                matrix += Environment.NewLine;
            }
            this.textBoxResult_KEA.Text = matrix;
        }

        private void buttonInform_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-3 Корнеева Елизавета Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
