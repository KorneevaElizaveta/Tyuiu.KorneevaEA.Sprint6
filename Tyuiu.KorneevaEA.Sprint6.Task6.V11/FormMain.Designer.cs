
namespace Tyuiu.KorneevaEA.Sprint6.Task6.V11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp_KEA = new System.Windows.Forms.Button();
            this.buttonDone_KEA = new System.Windows.Forms.Button();
            this.buttonOpen_KEA = new System.Windows.Forms.Button();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_KEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipAnnotation_KEA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxTask_KEA.SuspendLayout();
            this.groupBoxInput_KEA.SuspendLayout();
            this.groupBoxOutput_KEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelp_KEA);
            this.groupBox1.Controls.Add(this.buttonDone_KEA);
            this.groupBox1.Controls.Add(this.buttonOpen_KEA);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы управления";
            // 
            // buttonHelp_KEA
            // 
            this.buttonHelp_KEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KEA.Image")));
            this.buttonHelp_KEA.Location = new System.Drawing.Point(850, 21);
            this.buttonHelp_KEA.Name = "buttonHelp_KEA";
            this.buttonHelp_KEA.Size = new System.Drawing.Size(67, 60);
            this.buttonHelp_KEA.TabIndex = 0;
            this.toolTipAnnotation_KEA.SetToolTip(this.buttonHelp_KEA, "Информация о разработчике\r\n\r\n");
            this.buttonHelp_KEA.UseVisualStyleBackColor = false;
            this.buttonHelp_KEA.Click += new System.EventHandler(this.buttonHelp_KEA_Click);
            // 
            // buttonDone_KEA
            // 
            this.buttonDone_KEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_KEA.Enabled = false;
            this.buttonDone_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KEA.Image")));
            this.buttonDone_KEA.Location = new System.Drawing.Point(114, 20);
            this.buttonDone_KEA.Name = "buttonDone_KEA";
            this.buttonDone_KEA.Size = new System.Drawing.Size(69, 62);
            this.buttonDone_KEA.TabIndex = 0;
            this.toolTipAnnotation_KEA.SetToolTip(this.buttonDone_KEA, "Вывести предпоследнее слово каждой строки\r\n");
            this.buttonDone_KEA.UseVisualStyleBackColor = false;
            this.buttonDone_KEA.Click += new System.EventHandler(this.buttonDone_KEA_Click);
            // 
            // buttonOpen_KEA
            // 
            this.buttonOpen_KEA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpen_KEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KEA.Image")));
            this.buttonOpen_KEA.Location = new System.Drawing.Point(6, 19);
            this.buttonOpen_KEA.Name = "buttonOpen_KEA";
            this.buttonOpen_KEA.Size = new System.Drawing.Size(67, 62);
            this.buttonOpen_KEA.TabIndex = 0;
            this.toolTipAnnotation_KEA.SetToolTip(this.buttonOpen_KEA, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            this.buttonOpen_KEA.UseVisualStyleBackColor = false;
            this.buttonOpen_KEA.Click += new System.EventHandler(this.buttonOpen_KEA_Click);
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxTask_KEA);
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(13, 112);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(947, 76);
            this.groupBoxTask_KEA.TabIndex = 1;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // textBoxTask_KEA
            // 
            this.textBoxTask_KEA.Location = new System.Drawing.Point(7, 19);
            this.textBoxTask_KEA.Multiline = true;
            this.textBoxTask_KEA.Name = "textBoxTask_KEA";
            this.textBoxTask_KEA.ReadOnly = true;
            this.textBoxTask_KEA.Size = new System.Drawing.Size(934, 46);
            this.textBoxTask_KEA.TabIndex = 0;
            this.textBoxTask_KEA.Text = resources.GetString("textBoxTask_KEA.Text");
            // 
            // groupBoxInput_KEA
            // 
            this.groupBoxInput_KEA.Controls.Add(this.textBoxInput_KEA);
            this.groupBoxInput_KEA.Location = new System.Drawing.Point(13, 194);
            this.groupBoxInput_KEA.Name = "groupBoxInput_KEA";
            this.groupBoxInput_KEA.Size = new System.Drawing.Size(474, 394);
            this.groupBoxInput_KEA.TabIndex = 2;
            this.groupBoxInput_KEA.TabStop = false;
            this.groupBoxInput_KEA.Text = "Ввод";
            // 
            // textBoxInput_KEA
            // 
            this.textBoxInput_KEA.Location = new System.Drawing.Point(7, 20);
            this.textBoxInput_KEA.Multiline = true;
            this.textBoxInput_KEA.Name = "textBoxInput_KEA";
            this.textBoxInput_KEA.Size = new System.Drawing.Size(461, 368);
            this.textBoxInput_KEA.TabIndex = 0;
            // 
            // groupBoxOutput_KEA
            // 
            this.groupBoxOutput_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxOutput_KEA.Location = new System.Drawing.Point(493, 194);
            this.groupBoxOutput_KEA.Name = "groupBoxOutput_KEA";
            this.groupBoxOutput_KEA.Size = new System.Drawing.Size(471, 394);
            this.groupBoxOutput_KEA.TabIndex = 2;
            this.groupBoxOutput_KEA.TabStop = false;
            this.groupBoxOutput_KEA.Text = "Вывод";
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.Size = new System.Drawing.Size(461, 368);
            this.textBoxResult_KEA.TabIndex = 0;
            // 
            // openFileDialogTask_KEA
            // 
            this.openFileDialogTask_KEA.FileName = "openFileDialog1";
            // 
            // toolTipAnnotation_KEA
            // 
            this.toolTipAnnotation_KEA.Tag = "";
            this.toolTipAnnotation_KEA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_KEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 600);
            this.Controls.Add(this.groupBoxOutput_KEA);
            this.Controls.Add(this.groupBoxInput_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain_KEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Корнеева Е.А.";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            this.groupBoxInput_KEA.ResumeLayout(false);
            this.groupBoxInput_KEA.PerformLayout();
            this.groupBoxOutput_KEA.ResumeLayout(false);
            this.groupBoxOutput_KEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHelp_KEA;
        private System.Windows.Forms.Button buttonDone_KEA;
        private System.Windows.Forms.Button buttonOpen_KEA;
        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxTask_KEA;
        private System.Windows.Forms.GroupBox groupBoxInput_KEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KEA;
        private System.Windows.Forms.TextBox textBoxInput_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.ToolTip toolTipAnnotation_KEA;
    }
}

