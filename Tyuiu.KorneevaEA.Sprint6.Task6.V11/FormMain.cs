using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KorneevaEA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KEA.ShowDialog();
            openFilePath = openFileDialogTask_KEA.FileName;
            textBoxInput_KEA.Text = File.ReadAllText(openFilePath);
            buttonDone_KEA.Enabled = true;
            groupBoxInput_KEA.Text = groupBoxInput_KEA.Text + " " + openFileDialogTask_KEA.FileName;
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            //string path = @"C:\DataSprint6\InPutFileTask6V11.txt";
            textBoxResult_KEA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
