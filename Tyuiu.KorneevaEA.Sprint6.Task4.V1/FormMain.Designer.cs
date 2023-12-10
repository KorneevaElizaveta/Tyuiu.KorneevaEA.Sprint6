
namespace Tyuiu.KorneevaEA.Sprint6.Task4.V1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_KEA = new System.Windows.Forms.Panel();
            this.groupBoxInput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxInputStopValue_KEA = new System.Windows.Forms.TextBox();
            this.textBoxInputStartValue_KEA = new System.Windows.Forms.TextBox();
            this.labelStart_KEA = new System.Windows.Forms.Label();
            this.labelStop_KEA = new System.Windows.Forms.Label();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonSave_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.panelLeft_KEA = new System.Windows.Forms.Panel();
            this.groupBoxOutput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.labelResult_KEA = new System.Windows.Forms.Label();
            this.panelFill_KEA = new System.Windows.Forms.Panel();
            this.chartFunction_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOutput_KEA = new System.Windows.Forms.Splitter();
            this.panelTop_KEA.SuspendLayout();
            this.groupBoxInput_KEA.SuspendLayout();
            this.groupBoxTask_KEA.SuspendLayout();
            this.panelLeft_KEA.SuspendLayout();
            this.groupBoxOutput_KEA.SuspendLayout();
            this.panelFill_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_KEA
            // 
            this.panelTop_KEA.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop_KEA.Controls.Add(this.groupBoxInput_KEA);
            this.panelTop_KEA.Controls.Add(this.buttonHelp_KEA);
            this.panelTop_KEA.Controls.Add(this.buttonSave_KEA);
            this.panelTop_KEA.Controls.Add(this.buttonDone_KEA);
            this.panelTop_KEA.Controls.Add(this.groupBoxTask_KEA);
            this.panelTop_KEA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KEA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KEA.Name = "panelTop_KEA";
            this.panelTop_KEA.Size = new System.Drawing.Size(984, 86);
            this.panelTop_KEA.TabIndex = 0;
            // 
            // groupBoxInput_KEA
            // 
            this.groupBoxInput_KEA.Controls.Add(this.textBoxInputStopValue_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.textBoxInputStartValue_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.labelStart_KEA);
            this.groupBoxInput_KEA.Controls.Add(this.labelStop_KEA);
            this.groupBoxInput_KEA.Location = new System.Drawing.Point(423, 5);
            this.groupBoxInput_KEA.Name = "groupBoxInput_KEA";
            this.groupBoxInput_KEA.Size = new System.Drawing.Size(280, 75);
            this.groupBoxInput_KEA.TabIndex = 2;
            this.groupBoxInput_KEA.TabStop = false;
            this.groupBoxInput_KEA.Text = "Ввод данных:";
            // 
            // textBoxInputStopValue_KEA
            // 
            this.textBoxInputStopValue_KEA.Location = new System.Drawing.Point(156, 35);
            this.textBoxInputStopValue_KEA.Multiline = true;
            this.textBoxInputStopValue_KEA.Name = "textBoxInputStopValue_KEA";
            this.textBoxInputStopValue_KEA.Size = new System.Drawing.Size(118, 20);
            this.textBoxInputStopValue_KEA.TabIndex = 1;
            // 
            // textBoxInputStartValue_KEA
            // 
            this.textBoxInputStartValue_KEA.Location = new System.Drawing.Point(9, 35);
            this.textBoxInputStartValue_KEA.Multiline = true;
            this.textBoxInputStartValue_KEA.Name = "textBoxInputStartValue_KEA";
            this.textBoxInputStartValue_KEA.Size = new System.Drawing.Size(118, 20);
            this.textBoxInputStartValue_KEA.TabIndex = 0;
            // 
            // labelStart_KEA
            // 
            this.labelStart_KEA.AutoSize = true;
            this.labelStart_KEA.Location = new System.Drawing.Point(6, 19);
            this.labelStart_KEA.Name = "labelStart_KEA";
            this.labelStart_KEA.Size = new System.Drawing.Size(75, 13);
            this.labelStart_KEA.TabIndex = 0;
            this.labelStart_KEA.Text = "Начало шага:";
            // 
            // labelStop_KEA
            // 
            this.labelStop_KEA.AutoSize = true;
            this.labelStop_KEA.Location = new System.Drawing.Point(153, 19);
            this.labelStop_KEA.Name = "labelStop_KEA";
            this.labelStop_KEA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_KEA.TabIndex = 0;
            this.labelStop_KEA.Text = "Конец шага:";
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KEA.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_KEA.Location = new System.Drawing.Point(906, 20);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(75, 50);
            this.buttonHelp_KEA.TabIndex = 4;
            this.buttonHelp_KEA.Text = "Справка";
            this.buttonHelp_KEA.UseVisualStyleBackColor = false;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // buttonSave_KEA
            // 
            this.buttonSave_KEA.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_KEA.Location = new System.Drawing.Point(790, 20);
            this.buttonSave_KEA.Name = "buttonSave_KEA";
            this.buttonSave_KEA.Size = new System.Drawing.Size(75, 50);
            this.buttonSave_KEA.TabIndex = 3;
            this.buttonSave_KEA.Text = "Сохранить";
            this.buttonSave_KEA.UseVisualStyleBackColor = false;
            this.buttonSave_KEA.Click += new System.EventHandler(this.buttonSave_KEA_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KEA.Location = new System.Drawing.Point(709, 21);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(75, 49);
            this.buttonDone_KEA.TabIndex = 2;
            this.buttonDone_KEA.Text = "Выполнить";
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(12, 5);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(405, 75);
            this.groupBoxTask_KEA.TabIndex = 0;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие:";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Location = new System.Drawing.Point(6, 16);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(393, 48);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.TabStop = false;
            this.textBoxTask_KEA.Text = "Протабулировать функцию f(x) на заданном диапазоне -5 до 5. Результат вывести в t" +
    "extBox, построить график фукнции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки";
            // 
            // panelLeft_KEA
            // 
            this.panelLeft_KEA.BackColor = System.Drawing.SystemColors.Window;
            this.panelLeft_KEA.Controls.Add(this.groupBoxOutput_KEA);
            this.panelLeft_KEA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KEA.Location = new System.Drawing.Point(0, 86);
            this.panelLeft_KEA.Name = "panelLeft_KEA";
            this.panelLeft_KEA.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft_KEA.Size = new System.Drawing.Size(192, 375);
            this.panelLeft_KEA.TabIndex = 0;
            // 
            // groupBoxOutput_KEA
            // 
            this.groupBoxOutput_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxOutput_KEA.Controls.Add(this.labelResult_KEA);
            this.groupBoxOutput_KEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_KEA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutput_KEA.Name = "groupBoxOutput_KEA";
            this.groupBoxOutput_KEA.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBoxOutput_KEA.Size = new System.Drawing.Size(186, 369);
            this.groupBoxOutput_KEA.TabIndex = 6;
            this.groupBoxOutput_KEA.TabStop = false;
            this.groupBoxOutput_KEA.Text = "Вывод данных:";
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KEA.Location = new System.Drawing.Point(3, 33);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.ReadOnly = true;
            this.textBoxResult_KEA.Size = new System.Drawing.Size(180, 333);
            this.textBoxResult_KEA.TabIndex = 6;
            this.textBoxResult_KEA.TabStop = false;
            // 
            // labelResult_KEA
            // 
            this.labelResult_KEA.AutoSize = true;
            this.labelResult_KEA.Location = new System.Drawing.Point(6, 17);
            this.labelResult_KEA.Name = "labelResult_KEA";
            this.labelResult_KEA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KEA.TabIndex = 0;
            this.labelResult_KEA.Text = "Результат:";
            // 
            // panelFill_KEA
            // 
            this.panelFill_KEA.BackColor = System.Drawing.SystemColors.Window;
            this.panelFill_KEA.Controls.Add(this.chartFunction_KEA);
            this.panelFill_KEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KEA.Location = new System.Drawing.Point(192, 86);
            this.panelFill_KEA.Name = "panelFill_KEA";
            this.panelFill_KEA.Padding = new System.Windows.Forms.Padding(3);
            this.panelFill_KEA.Size = new System.Drawing.Size(792, 375);
            this.panelFill_KEA.TabIndex = 0;
            // 
            // chartFunction_KEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KEA.ChartAreas.Add(chartArea1);
            this.chartFunction_KEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_KEA.Legends.Add(legend1);
            this.chartFunction_KEA.Location = new System.Drawing.Point(3, 3);
            this.chartFunction_KEA.Name = "chartFunction_KEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KEA.Series.Add(series1);
            this.chartFunction_KEA.Size = new System.Drawing.Size(786, 369);
            this.chartFunction_KEA.TabIndex = 1;
            this.chartFunction_KEA.TabStop = false;
            this.chartFunction_KEA.Text = "chart1";
            // 
            // splitterOutput_KEA
            // 
            this.splitterOutput_KEA.Location = new System.Drawing.Point(192, 86);
            this.splitterOutput_KEA.Name = "splitterOutput_KEA";
            this.splitterOutput_KEA.Size = new System.Drawing.Size(3, 375);
            this.splitterOutput_KEA.TabIndex = 1;
            this.splitterOutput_KEA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.splitterOutput_KEA);
            this.Controls.Add(this.panelFill_KEA);
            this.Controls.Add(this.panelLeft_KEA);
            this.Controls.Add(this.panelTop_KEA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 1 | Корнеева Е.А.";
            this.panelTop_KEA.ResumeLayout(false);
            this.groupBoxInput_KEA.ResumeLayout(false);
            this.groupBoxInput_KEA.PerformLayout();
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.panelLeft_KEA.ResumeLayout(false);
            this.groupBoxOutput_KEA.ResumeLayout(false);
            this.groupBoxOutput_KEA.PerformLayout();
            this.panelFill_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_KEA;
        private System.Windows.Forms.Panel panelLeft_KEA;
        private System.Windows.Forms.Panel panelFill_KEA;
        private System.Windows.Forms.Splitter splitterOutput_KEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.Label labelResult_KEA;
        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonSave_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.GroupBox groupBoxInput_KEA;
        private System.Windows.Forms.Label labelStop_KEA;
        private System.Windows.Forms.TextBox textBoxInputStartValue_KEA;
        private System.Windows.Forms.Label labelStart_KEA;
        private System.Windows.Forms.TextBox textBoxInputStopValue_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KEA;
    }
}

