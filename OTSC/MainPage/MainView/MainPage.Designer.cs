namespace OTSC.MainPage.MainView
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            btn_Close = new PictureBox();
            pic_Theme = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_label = new LinkLabel();
            label1 = new Label();
            btn_Ezhednevnik = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btn_Generator = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Theme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Ezhednevnik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Generator).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.Location = new Point(958, 1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(45, 45);
            btn_Close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Close.TabIndex = 12;
            btn_Close.TabStop = false;
            // 
            // pic_Theme
            // 
            pic_Theme.Image = (Image)resources.GetObject("pic_Theme.Image");
            pic_Theme.Location = new Point(914, 505);
            pic_Theme.Name = "pic_Theme";
            pic_Theme.Size = new Size(89, 55);
            pic_Theme.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Theme.TabIndex = 13;
            pic_Theme.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(715, 384);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btn_label
            // 
            btn_label.AutoSize = true;
            btn_label.Location = new Point(723, 515);
            btn_label.Name = "btn_label";
            btn_label.Size = new Size(149, 20);
            btn_label.TabIndex = 15;
            btn_label.TabStop = true;
            btn_label.Text = "HAPPYBOTINOK_BOT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(56, 501);
            label1.Name = "label1";
            label1.Size = new Size(613, 34);
            label1.TabIndex = 16;
            label1.Text = "Пользование всеми возможностями:";
            // 
            // btn_Ezhednevnik
            // 
            btn_Ezhednevnik.Image = (Image)resources.GetObject("btn_Ezhednevnik.Image");
            btn_Ezhednevnik.Location = new Point(45, 12);
            btn_Ezhednevnik.Name = "btn_Ezhednevnik";
            btn_Ezhednevnik.Size = new Size(303, 289);
            btn_Ezhednevnik.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Ezhednevnik.TabIndex = 17;
            btn_Ezhednevnik.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label2.Location = new Point(96, 302);
            label2.Name = "label2";
            label2.Size = new Size(217, 34);
            label2.TabIndex = 18;
            label2.Text = "Ежедневник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            label3.Location = new Point(517, 316);
            label3.Name = "label3";
            label3.Size = new Size(425, 34);
            label3.TabIndex = 19;
            label3.Text = "Генератор поздравлений";
            // 
            // btn_Generator
            // 
            btn_Generator.Image = (Image)resources.GetObject("btn_Generator.Image");
            btn_Generator.Location = new Point(569, 12);
            btn_Generator.Name = "btn_Generator";
            btn_Generator.Size = new Size(303, 289);
            btn_Generator.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Generator.TabIndex = 20;
            btn_Generator.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1002, 558);
            Controls.Add(btn_Generator);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Ezhednevnik);
            Controls.Add(label1);
            Controls.Add(btn_label);
            Controls.Add(pictureBox1);
            Controls.Add(pic_Theme);
            Controls.Add(btn_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)btn_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Theme).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Ezhednevnik).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Generator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_Close;
        private PictureBox pic_Theme;
        private PictureBox pictureBox1;
        private LinkLabel btn_label;
        private Label label1;
        private PictureBox btn_Ezhednevnik;
        private Label label2;
        private Label label3;
        private PictureBox btn_Generator;
    }
}