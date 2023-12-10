
namespace Tyuiu.KorneevaEA.Sprint6.Task6.V11
{
    partial class FormAbout
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
            this.textBoxDeveloper_KEA = new System.Windows.Forms.TextBox();
            this.buttonOK_KEA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDeveloper_KEA
            // 
            this.textBoxDeveloper_KEA.Location = new System.Drawing.Point(187, 44);
            this.textBoxDeveloper_KEA.Multiline = true;
            this.textBoxDeveloper_KEA.Name = "textBoxDeveloper_KEA";
            this.textBoxDeveloper_KEA.ReadOnly = true;
            this.textBoxDeveloper_KEA.Size = new System.Drawing.Size(207, 69);
            this.textBoxDeveloper_KEA.TabIndex = 0;
            this.textBoxDeveloper_KEA.TabStop = false;
            this.textBoxDeveloper_KEA.Text = "Разработчик: Корнеева Е.А.\r\nГруппа АСОиУб-23-3\r\nВысшая школа цифровых технологий " +
    "(c) 2023\r\n";
            // 
            // buttonOK_KEA
            // 
            this.buttonOK_KEA.Location = new System.Drawing.Point(319, 134);
            this.buttonOK_KEA.Name = "buttonOK_KEA";
            this.buttonOK_KEA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KEA.TabIndex = 2;
            this.buttonOK_KEA.Text = "OK";
            this.buttonOK_KEA.UseVisualStyleBackColor = true;
            this.buttonOK_KEA.Click += new System.EventHandler(this.buttonOK_KEA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.KorneevaEA.Sprint6.Task6.V11.Properties.Resources.lsdjhfglskjdthdjth;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout_KEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 169);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOK_KEA);
            this.Controls.Add(this.textBoxDeveloper_KEA);
            this.MaximumSize = new System.Drawing.Size(422, 208);
            this.MinimumSize = new System.Drawing.Size(422, 208);
            this.Name = "FormAbout_KEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeveloper_KEA;
        private System.Windows.Forms.Button buttonOK_KEA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
