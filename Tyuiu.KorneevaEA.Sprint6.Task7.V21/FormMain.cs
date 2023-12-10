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
using Tyuiu.KorneevaEA.Sprint6.Task7.V21.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KEA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_KEA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonLoadFile_KEA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_KEA.Enabled = true;
        }
        private void buttonOpenFile_KEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEA.ShowDialog();
            openFilePath = openFileDialogTask_KEA.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KEA.ColumnCount = columns;
            dataGridViewIn_KEA.RowCount = rows;
            dataGridViewOut_KEA.ColumnCount = columns;
            dataGridViewOut_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KEA.Columns[i].Width = 25;
                dataGridViewOut_KEA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonLoadFile_KEA.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KEA.ColumnCount = 38;
            dataGridViewOut_KEA.ColumnCount = 38;

            dataGridViewIn_KEA.RowCount = 38;
            dataGridViewOut_KEA.RowCount = 38;

            panelLeft_KEA.Width = this.Width / 2;

            for (int i = 0; i < 38; i++)
            {
                dataGridViewIn_KEA.Columns[i].Width = 19;
                dataGridViewOut_KEA.Columns[i].Width = 19;
            }
        }

        private void buttonSaveFile_KEA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KEA.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_KEA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KEA.ShowDialog();

            string path = saveFileDialogTask_KEA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_KEA.RowCount;
            int columns = dataGridViewOut_KEA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEA.ToolTipTitle = "Открыть файл";
        }

        private void buttonLoadFile_KEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEA.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_KEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KEA.ToolTipTitle = "Справка";
        }

    }
}
