
namespace Tyuiu.KorneevaEA.Sprint6.Task1.V30
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
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.buttonInfo_SRR = new System.Windows.Forms.Button();
            this.groupBoxStartStopValue_SRR = new System.Windows.Forms.GroupBox();
            this.labelStopValue_SRR = new System.Windows.Forms.Label();
            this.labelStartValue_SRR = new System.Windows.Forms.Label();
            this.textBoxStopValue_SRR = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SRR = new System.Windows.Forms.GroupBox();
            this.labelResult_SRR = new System.Windows.Forms.Label();
            this.textBoxResult_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxtask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxStartStopValue_SRR.SuspendLayout();
            this.groupBoxOutput_SRR.SuspendLayout();
            this.groupBoxCondition_SRR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SRR.Location = new System.Drawing.Point(392, 314);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(91, 68);
            this.buttonDone_SRR.TabIndex = 1;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = false;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // buttonInfo_SRR
            // 
            this.buttonInfo_SRR.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_SRR.Location = new System.Drawing.Point(295, 314);
            this.buttonInfo_SRR.Name = "buttonInfo_SRR";
            this.buttonInfo_SRR.Size = new System.Drawing.Size(91, 68);
            this.buttonInfo_SRR.TabIndex = 1;
            this.buttonInfo_SRR.Text = "Справка";
            this.buttonInfo_SRR.UseVisualStyleBackColor = false;
            this.buttonInfo_SRR.Click += new System.EventHandler(this.buttonInfo_SRR_Click);
            // 
            // groupBoxStartStopValue_SRR
            // 
            this.groupBoxStartStopValue_SRR.Controls.Add(this.labelStopValue_SRR);
            this.groupBoxStartStopValue_SRR.Controls.Add(this.labelStartValue_SRR);
            this.groupBoxStartStopValue_SRR.Controls.Add(this.textBoxStopValue_SRR);
            this.groupBoxStartStopValue_SRR.Controls.Add(this.textBoxStartValue_SRR);
            this.groupBoxStartStopValue_SRR.Location = new System.Drawing.Point(35, 314);
            this.groupBoxStartStopValue_SRR.Name = "groupBoxStartStopValue_SRR";
            this.groupBoxStartStopValue_SRR.Size = new System.Drawing.Size(218, 68);
            this.groupBoxStartStopValue_SRR.TabIndex = 2;
            this.groupBoxStartStopValue_SRR.TabStop = false;
            this.groupBoxStartStopValue_SRR.Text = "Ввод данных";
            // 
            // labelStopValue_SRR
            // 
            this.labelStopValue_SRR.AutoSize = true;
            this.labelStopValue_SRR.Location = new System.Drawing.Point(112, 20);
            this.labelStopValue_SRR.Name = "labelStopValue_SRR";
            this.labelStopValue_SRR.Size = new System.Drawing.Size(66, 13);
            this.labelStopValue_SRR.TabIndex = 3;
            this.labelStopValue_SRR.Text = "Конец шага";
            // 
            // labelStartValue_SRR
            // 
            this.labelStartValue_SRR.AutoSize = true;
            this.labelStartValue_SRR.Location = new System.Drawing.Point(7, 20);
            this.labelStartValue_SRR.Name = "labelStartValue_SRR";
            this.labelStartValue_SRR.Size = new System.Drawing.Size(72, 13);
            this.labelStartValue_SRR.TabIndex = 2;
            this.labelStartValue_SRR.Text = "Начало шага";
            // 
            // textBoxStopValue_SRR
            // 
            this.textBoxStopValue_SRR.Location = new System.Drawing.Point(112, 42);
            this.textBoxStopValue_SRR.Multiline = true;
            this.textBoxStopValue_SRR.Name = "textBoxStopValue_SRR";
            this.textBoxStopValue_SRR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_SRR.TabIndex = 0;
            // 
            // textBoxStartValue_SRR
            // 
            this.textBoxStartValue_SRR.Location = new System.Drawing.Point(6, 42);
            this.textBoxStartValue_SRR.Multiline = true;
            this.textBoxStartValue_SRR.Name = "textBoxStartValue_SRR";
            this.textBoxStartValue_SRR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_SRR.TabIndex = 0;
            // 
            // groupBoxOutput_SRR
            // 
            this.groupBoxOutput_SRR.Controls.Add(this.labelResult_SRR);
            this.groupBoxOutput_SRR.Controls.Add(this.textBoxResult_SRR);
            this.groupBoxOutput_SRR.Location = new System.Drawing.Point(594, 12);
            this.groupBoxOutput_SRR.Name = "groupBoxOutput_SRR";
            this.groupBoxOutput_SRR.Size = new System.Drawing.Size(200, 426);
            this.groupBoxOutput_SRR.TabIndex = 4;
            this.groupBoxOutput_SRR.TabStop = false;
            this.groupBoxOutput_SRR.Text = "Вывод данных";
            // 
            // labelResult_SRR
            // 
            this.labelResult_SRR.AutoSize = true;
            this.labelResult_SRR.Location = new System.Drawing.Point(7, 16);
            this.labelResult_SRR.Name = "labelResult_SRR";
            this.labelResult_SRR.Size = new System.Drawing.Size(59, 13);
            this.labelResult_SRR.TabIndex = 1;
            this.labelResult_SRR.Text = "Результат";
            // 
            // textBoxResult_SRR
            // 
            this.textBoxResult_SRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SRR.Location = new System.Drawing.Point(7, 35);
            this.textBoxResult_SRR.Multiline = true;
            this.textBoxResult_SRR.Name = "textBoxResult_SRR";
            this.textBoxResult_SRR.Size = new System.Drawing.Size(187, 385);
            this.textBoxResult_SRR.TabIndex = 0;
            // 
            // groupBoxCondition_SRR
            // 
            this.groupBoxCondition_SRR.Controls.Add(this.textBoxtask_KEA);
            this.groupBoxCondition_SRR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
            this.groupBoxCondition_SRR.Size = new System.Drawing.Size(583, 216);
            this.groupBoxCondition_SRR.TabIndex = 5;
            this.groupBoxCondition_SRR.TabStop = false;
            this.groupBoxCondition_SRR.Text = "Условие";
            // 
            // textBoxtask_KEA
            // 
            this.textBoxtask_KEA.Location = new System.Drawing.Point(3, 13);
            this.textBoxtask_KEA.Name = "textBoxtask_KEA";
            this.textBoxtask_KEA.ReadOnly = true;
            this.textBoxtask_KEA.Size = new System.Drawing.Size(574, 20);
            this.textBoxtask_KEA.TabIndex = 0;
            this.textBoxtask_KEA.Text = "Проивести табулирование на заданном диапозоне [-5; 5]";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCondition_SRR);
            this.Controls.Add(this.groupBoxOutput_SRR);
            this.Controls.Add(this.groupBoxStartStopValue_SRR);
            this.Controls.Add(this.buttonInfo_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxStartStopValue_SRR.ResumeLayout(false);
            this.groupBoxStartStopValue_SRR.PerformLayout();
            this.groupBoxOutput_SRR.ResumeLayout(false);
            this.groupBoxOutput_SRR.PerformLayout();
            this.groupBoxCondition_SRR.ResumeLayout(false);
            this.groupBoxCondition_SRR.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDone_SRR;
		private System.Windows.Forms.Button buttonInfo_SRR;
		private System.Windows.Forms.GroupBox groupBoxStartStopValue_SRR;
		private System.Windows.Forms.Label labelStopValue_SRR;
		private System.Windows.Forms.Label labelStartValue_SRR;
		private System.Windows.Forms.TextBox textBoxStopValue_SRR;
		private System.Windows.Forms.TextBox textBoxStartValue_SRR;
		private System.Windows.Forms.GroupBox groupBoxOutput_SRR;
		private System.Windows.Forms.Label labelResult_SRR;
		private System.Windows.Forms.TextBox textBoxResult_SRR;
		private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
        private System.Windows.Forms.TextBox textBoxtask_KEA;
    }
}

