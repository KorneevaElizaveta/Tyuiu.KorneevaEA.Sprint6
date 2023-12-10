
namespace Tyuiu.KorneevaEA.Sprint6.Task7.V21
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
            this.buttonAccept_KEA = new System.Windows.Forms.Button();
            this.labelInfo_KEA = new System.Windows.Forms.Label();
            this.pictureBoxTrueMe_KEA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrueMe_KEA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept_KEA
            // 
            this.buttonAccept_KEA.Location = new System.Drawing.Point(318, 117);
            this.buttonAccept_KEA.Name = "buttonAccept_KEA";
            this.buttonAccept_KEA.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept_KEA.TabIndex = 10;
            this.buttonAccept_KEA.Text = "Согласен";
            this.buttonAccept_KEA.UseVisualStyleBackColor = true;
            this.buttonAccept_KEA.Click += new System.EventHandler(this.buttonAccept_KEA_Click);
            // 
            // labelInfo_KEA
            // 
            this.labelInfo_KEA.AutoSize = true;
            this.labelInfo_KEA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo_KEA.Location = new System.Drawing.Point(132, 9);
            this.labelInfo_KEA.Name = "labelInfo_KEA";
            this.labelInfo_KEA.Size = new System.Drawing.Size(269, 91);
            this.labelInfo_KEA.TabIndex = 9;
            this.labelInfo_KEA.Text = "Разработчик: Корнеева Е. А.\r\nГруппа АСОиУб-23-3\r\n\r\nЛучшая цитата: \"шкаф не тумба," +
    " тимон не пумба\".\r\n\r\n\r\nВнутренне имя: Tyuiu.KorneevaEA.Sprint6.Task7.V21";
            // 
            // pictureBoxTrueMe_KEA
            // 
            this.pictureBoxTrueMe_KEA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrueMe_KEA.Name = "pictureBoxTrueMe_KEA";
            this.pictureBoxTrueMe_KEA.Size = new System.Drawing.Size(126, 152);
            this.pictureBoxTrueMe_KEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrueMe_KEA.TabIndex = 15;
            this.pictureBoxTrueMe_KEA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 152);
            this.Controls.Add(this.buttonAccept_KEA);
            this.Controls.Add(this.labelInfo_KEA);
            this.Controls.Add(this.pictureBoxTrueMe_KEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 191);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrueMe_KEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAccept_KEA;
        private System.Windows.Forms.Label labelInfo_KEA;
        private System.Windows.Forms.PictureBox pictureBoxTrueMe_KEA;
    }
}
