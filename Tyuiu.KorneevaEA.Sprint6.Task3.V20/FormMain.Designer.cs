
namespace Tyuiu.KorneevaEA.Sprint6.Task3.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonInform_KEA = new System.Windows.Forms.Button();
            this.buttonPushMe_KEA = new System.Windows.Forms.Button();
            this.groupBoxOut_KEA = new System.Windows.Forms.GroupBox();
            this.labelResult_KEA = new System.Windows.Forms.Label();
            this.textBoxResult_KEA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KEA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KEA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_KEA = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_KEA.SuspendLayout();
            this.groupBoxTask_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInform_KEA
            // 
            this.buttonInform_KEA.Location = new System.Drawing.Point(473, 193);
            this.buttonInform_KEA.Name = "buttonInform_KEA";
            this.buttonInform_KEA.Size = new System.Drawing.Size(32, 35);
            this.buttonInform_KEA.TabIndex = 6;
            this.buttonInform_KEA.Text = "?";
            this.buttonInform_KEA.UseVisualStyleBackColor = true;
            this.buttonInform_KEA.Click += new System.EventHandler(this.buttonInform_KEA_Click);
            // 
            // buttonPushMe_KEA
            // 
            this.buttonPushMe_KEA.Location = new System.Drawing.Point(513, 187);
            this.buttonPushMe_KEA.Name = "buttonPushMe_KEA";
            this.buttonPushMe_KEA.Size = new System.Drawing.Size(80, 47);
            this.buttonPushMe_KEA.TabIndex = 4;
            this.buttonPushMe_KEA.Text = "Выполнить";
            this.buttonPushMe_KEA.UseVisualStyleBackColor = true;
            this.buttonPushMe_KEA.Click += new System.EventHandler(this.buttonPushMe_KEA_Click);
            // 
            // groupBoxOut_KEA
            // 
            this.groupBoxOut_KEA.Controls.Add(this.labelResult_KEA);
            this.groupBoxOut_KEA.Controls.Add(this.textBoxResult_KEA);
            this.groupBoxOut_KEA.Location = new System.Drawing.Point(464, 25);
            this.groupBoxOut_KEA.Name = "groupBoxOut_KEA";
            this.groupBoxOut_KEA.Size = new System.Drawing.Size(129, 122);
            this.groupBoxOut_KEA.TabIndex = 5;
            this.groupBoxOut_KEA.TabStop = false;
            this.groupBoxOut_KEA.Text = "Вывод данных";
            // 
            // labelResult_KEA
            // 
            this.labelResult_KEA.AutoSize = true;
            this.labelResult_KEA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_KEA.Name = "labelResult_KEA";
            this.labelResult_KEA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KEA.TabIndex = 1;
            this.labelResult_KEA.Text = "Результат:";
            // 
            // textBoxResult_KEA
            // 
            this.textBoxResult_KEA.Location = new System.Drawing.Point(9, 32);
            this.textBoxResult_KEA.Multiline = true;
            this.textBoxResult_KEA.Name = "textBoxResult_KEA";
            this.textBoxResult_KEA.ReadOnly = true;
            this.textBoxResult_KEA.Size = new System.Drawing.Size(109, 78);
            this.textBoxResult_KEA.TabIndex = 0;
            this.textBoxResult_KEA.TabStop = false;
            // 
            // groupBoxTask_KEA
            // 
            this.groupBoxTask_KEA.Controls.Add(this.textBoxUslovie_KEA);
            this.groupBoxTask_KEA.Controls.Add(this.dataGridViewMatrix_KEA);
            this.groupBoxTask_KEA.Location = new System.Drawing.Point(5, 25);
            this.groupBoxTask_KEA.Name = "groupBoxTask_KEA";
            this.groupBoxTask_KEA.Size = new System.Drawing.Size(453, 209);
            this.groupBoxTask_KEA.TabIndex = 3;
            this.groupBoxTask_KEA.TabStop = false;
            this.groupBoxTask_KEA.Text = "Условие";
            // 
            // textBoxUslovie_KEA
            // 
            this.textBoxUslovie_KEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_KEA.Location = new System.Drawing.Point(6, 16);
            this.textBoxUslovie_KEA.Multiline = true;
            this.textBoxUslovie_KEA.Name = "textBoxUslovie_KEA";
            this.textBoxUslovie_KEA.ReadOnly = true;
            this.textBoxUslovie_KEA.Size = new System.Drawing.Size(242, 184);
            this.textBoxUslovie_KEA.TabIndex = 0;
            this.textBoxUslovie_KEA.TabStop = false;
            this.textBoxUslovie_KEA.Text = resources.GetString("textBoxUslovie_KEA.Text");
            this.textBoxUslovie_KEA.TextChanged += new System.EventHandler(this.textBoxUslovie_KEA_TextChanged);
            // 
            // dataGridViewMatrix_KEA
            // 
            this.dataGridViewMatrix_KEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KEA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KEA.Location = new System.Drawing.Point(254, 16);
            this.dataGridViewMatrix_KEA.Name = "dataGridViewMatrix_KEA";
            this.dataGridViewMatrix_KEA.ReadOnly = true;
            this.dataGridViewMatrix_KEA.RowHeadersVisible = false;
            this.dataGridViewMatrix_KEA.Size = new System.Drawing.Size(193, 184);
            this.dataGridViewMatrix_KEA.TabIndex = 0;
            this.dataGridViewMatrix_KEA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 259);
            this.Controls.Add(this.buttonInform_KEA);
            this.Controls.Add(this.buttonPushMe_KEA);
            this.Controls.Add(this.groupBoxOut_KEA);
            this.Controls.Add(this.groupBoxTask_KEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск3 | Вариант 20 | Корнеева Е.А. | АСОиУб-23-3";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOut_KEA.ResumeLayout(false);
            this.groupBoxOut_KEA.PerformLayout();
            this.groupBoxTask_KEA.ResumeLayout(false);
            this.groupBoxTask_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInform_KEA;
        private System.Windows.Forms.Button buttonPushMe_KEA;
        private System.Windows.Forms.GroupBox groupBoxOut_KEA;
        private System.Windows.Forms.Label labelResult_KEA;
        private System.Windows.Forms.TextBox textBoxResult_KEA;
        private System.Windows.Forms.GroupBox groupBoxTask_KEA;
        private System.Windows.Forms.TextBox textBoxUslovie_KEA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KEA;
    }
}

