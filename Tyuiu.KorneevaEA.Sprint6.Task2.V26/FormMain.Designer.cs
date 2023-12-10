
namespace Tyuiu.KorneevaEA.Sprint6.Task2.V26
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
            this.GroupBoxCond_KEA = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.GroupBoxInput_KEA = new System.Windows.Forms.GroupBox();
            this.TextBoxStop_KEA = new System.Windows.Forms.TextBox();
            this.TextBoxStart_KEA = new System.Windows.Forms.TextBox();
            this.LabelStop_KEA = new System.Windows.Forms.Label();
            this.LabelStart_KEA = new System.Windows.Forms.Label();
            this.ButtonInfo_KEA = new System.Windows.Forms.Button();
            this.ButtonDone_KEA = new System.Windows.Forms.Button();
            this.GroupBoxOutput_KEA = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Chart_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridView_KEA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.GroupBoxCond_KEA.SuspendLayout();
            this.GroupBoxInput_KEA.SuspendLayout();
            this.GroupBoxOutput_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_KEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxCond_KEA
            // 
            this.GroupBoxCond_KEA.Controls.Add(this.TextBoxTask_KEA);
            this.GroupBoxCond_KEA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxCond_KEA.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCond_KEA.Name = "GroupBoxCond_KEA";
            this.GroupBoxCond_KEA.Size = new System.Drawing.Size(615, 304);
            this.GroupBoxCond_KEA.TabIndex = 0;
            this.GroupBoxCond_KEA.TabStop = false;
            this.GroupBoxCond_KEA.Text = "Условие";
            // 
            // TextBoxTask_KEA
            // 
            this.TextBoxTask_KEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_KEA.Location = new System.Drawing.Point(21, 34);
            this.TextBoxTask_KEA.Multiline = true;
            this.TextBoxTask_KEA.Name = "TextBoxTask_KEA";
            this.TextBoxTask_KEA.ReadOnly = true;
            this.TextBoxTask_KEA.Size = new System.Drawing.Size(576, 253);
            this.TextBoxTask_KEA.TabIndex = 0;
            this.TextBoxTask_KEA.TabStop = false;
            this.TextBoxTask_KEA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // GroupBoxInput_KEA
            // 
            this.GroupBoxInput_KEA.Controls.Add(this.TextBoxStop_KEA);
            this.GroupBoxInput_KEA.Controls.Add(this.TextBoxStart_KEA);
            this.GroupBoxInput_KEA.Controls.Add(this.LabelStop_KEA);
            this.GroupBoxInput_KEA.Controls.Add(this.LabelStart_KEA);
            this.GroupBoxInput_KEA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_KEA.Location = new System.Drawing.Point(12, 322);
            this.GroupBoxInput_KEA.Name = "GroupBoxInput_KEA";
            this.GroupBoxInput_KEA.Size = new System.Drawing.Size(346, 116);
            this.GroupBoxInput_KEA.TabIndex = 1;
            this.GroupBoxInput_KEA.TabStop = false;
            this.GroupBoxInput_KEA.Text = "Ввод данных";
            // 
            // TextBoxStop_KEA
            // 
            this.TextBoxStop_KEA.Location = new System.Drawing.Point(167, 62);
            this.TextBoxStop_KEA.Name = "TextBoxStop_KEA";
            this.TextBoxStop_KEA.Size = new System.Drawing.Size(154, 36);
            this.TextBoxStop_KEA.TabIndex = 3;
            // 
            // TextBoxStart_KEA
            // 
            this.TextBoxStart_KEA.Location = new System.Drawing.Point(10, 62);
            this.TextBoxStart_KEA.Name = "TextBoxStart_KEA";
            this.TextBoxStart_KEA.Size = new System.Drawing.Size(151, 36);
            this.TextBoxStart_KEA.TabIndex = 2;
            // 
            // LabelStop_KEA
            // 
            this.LabelStop_KEA.AutoSize = true;
            this.LabelStop_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStop_KEA.Location = new System.Drawing.Point(163, 35);
            this.LabelStop_KEA.Name = "LabelStop_KEA";
            this.LabelStop_KEA.Size = new System.Drawing.Size(120, 22);
            this.LabelStop_KEA.TabIndex = 1;
            this.LabelStop_KEA.Text = "Конец шага:";
            // 
            // LabelStart_KEA
            // 
            this.LabelStart_KEA.AutoSize = true;
            this.LabelStart_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStart_KEA.Location = new System.Drawing.Point(6, 35);
            this.LabelStart_KEA.Name = "LabelStart_KEA";
            this.LabelStart_KEA.Size = new System.Drawing.Size(120, 22);
            this.LabelStart_KEA.TabIndex = 0;
            this.LabelStart_KEA.Text = "Старт шага:";
            // 
            // ButtonInfo_KEA
            // 
            this.ButtonInfo_KEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonInfo_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_KEA.Location = new System.Drawing.Point(376, 357);
            this.ButtonInfo_KEA.Name = "ButtonInfo_KEA";
            this.ButtonInfo_KEA.Size = new System.Drawing.Size(103, 56);
            this.ButtonInfo_KEA.TabIndex = 2;
            this.ButtonInfo_KEA.Text = "Справка";
            this.ButtonInfo_KEA.UseVisualStyleBackColor = false;
            this.ButtonInfo_KEA.Click += new System.EventHandler(this.ButtonInfo_KEA_Click);
            // 
            // ButtonDone_KEA
            // 
            this.ButtonDone_KEA.BackColor = System.Drawing.Color.Green;
            this.ButtonDone_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_KEA.Location = new System.Drawing.Point(485, 357);
            this.ButtonDone_KEA.Name = "ButtonDone_KEA";
            this.ButtonDone_KEA.Size = new System.Drawing.Size(142, 56);
            this.ButtonDone_KEA.TabIndex = 3;
            this.ButtonDone_KEA.Text = "Выполнить";
            this.ButtonDone_KEA.UseVisualStyleBackColor = false;
            this.ButtonDone_KEA.Click += new System.EventHandler(this.ButtonDone_KEA_Click);
            this.ButtonDone_KEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDone_KEA_MouseDown);
            this.ButtonDone_KEA.MouseEnter += new System.EventHandler(this.ButtonDone_KEA_MouseEnter);
            this.ButtonDone_KEA.MouseLeave += new System.EventHandler(this.ButtonDone_KEA_MouseLeave);
            // 
            // GroupBoxOutput_KEA
            // 
            this.GroupBoxOutput_KEA.Controls.Add(this.dataGridView1);
            this.GroupBoxOutput_KEA.Controls.Add(this.Chart_KEA);
            this.GroupBoxOutput_KEA.Controls.Add(this.DataGridView_KEA);
            this.GroupBoxOutput_KEA.Controls.Add(this.TextBoxResult_KEA);
            this.GroupBoxOutput_KEA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_KEA.Location = new System.Drawing.Point(633, 12);
            this.GroupBoxOutput_KEA.Name = "GroupBoxOutput_KEA";
            this.GroupBoxOutput_KEA.Size = new System.Drawing.Size(673, 426);
            this.GroupBoxOutput_KEA.TabIndex = 4;
            this.GroupBoxOutput_KEA.TabStop = false;
            this.GroupBoxOutput_KEA.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 5;
            // 
            // Chart_KEA
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_KEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_KEA.Legends.Add(legend1);
            this.Chart_KEA.Location = new System.Drawing.Point(192, 34);
            this.Chart_KEA.Name = "Chart_KEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_KEA.Series.Add(series1);
            this.Chart_KEA.Size = new System.Drawing.Size(476, 386);
            this.Chart_KEA.TabIndex = 4;
            this.Chart_KEA.Text = "chart1";
            // 
            // DataGridView_KEA
            // 
            this.DataGridView_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_KEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.DataGridView_KEA.Location = new System.Drawing.Point(7, 58);
            this.DataGridView_KEA.Name = "DataGridView_KEA";
            this.DataGridView_KEA.RowHeadersVisible = false;
            this.DataGridView_KEA.RowTemplate.Height = 27;
            this.DataGridView_KEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView_KEA.Size = new System.Drawing.Size(179, 362);
            this.DataGridView_KEA.TabIndex = 3;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 80;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 80;
            // 
            // TextBoxResult_KEA
            // 
            this.TextBoxResult_KEA.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResult_KEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResult_KEA.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxResult_KEA.Location = new System.Drawing.Point(7, 34);
            this.TextBoxResult_KEA.Multiline = true;
            this.TextBoxResult_KEA.Name = "TextBoxResult_KEA";
            this.TextBoxResult_KEA.Size = new System.Drawing.Size(660, 392);
            this.TextBoxResult_KEA.TabIndex = 2;
            this.TextBoxResult_KEA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.GroupBoxOutput_KEA);
            this.Controls.Add(this.ButtonDone_KEA);
            this.Controls.Add(this.ButtonInfo_KEA);
            this.Controls.Add(this.GroupBoxInput_KEA);
            this.Controls.Add(this.GroupBoxCond_KEA);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Корнеева Е.А.";
            this.GroupBoxCond_KEA.ResumeLayout(false);
            this.GroupBoxCond_KEA.PerformLayout();
            this.GroupBoxInput_KEA.ResumeLayout(false);
            this.GroupBoxInput_KEA.PerformLayout();
            this.GroupBoxOutput_KEA.ResumeLayout(false);
            this.GroupBoxOutput_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_KEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxCond_KEA;
        private System.Windows.Forms.TextBox TextBoxTask_KEA;
        private System.Windows.Forms.GroupBox GroupBoxInput_KEA;
        private System.Windows.Forms.TextBox TextBoxStop_KEA;
        private System.Windows.Forms.TextBox TextBoxStart_KEA;
        private System.Windows.Forms.Label LabelStop_KEA;
        private System.Windows.Forms.Label LabelStart_KEA;
        private System.Windows.Forms.Button ButtonInfo_KEA;
        private System.Windows.Forms.Button ButtonDone_KEA;
        private System.Windows.Forms.GroupBox GroupBoxOutput_KEA;
        private System.Windows.Forms.TextBox TextBoxResult_KEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_KEA;
        private System.Windows.Forms.DataGridView DataGridView_KEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

