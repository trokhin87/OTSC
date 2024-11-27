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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            npgsqlDataAdapter2 = new Npgsql.NpgsqlDataAdapter();
            btn_generator = new PictureBox();
            label2 = new Label();
            btn_ezhednevnik = new PictureBox();
            label3 = new Label();
            btn_profile = new PictureBox();
            panel5 = new Panel();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_Close).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_generator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ezhednevnik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_profile).BeginInit();
            panel5.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 112, 101);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_Close);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 45);
            panel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(91, 112, 101);
            panel4.Location = new Point(0, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 515);
            panel2.TabIndex = 22;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(74, -2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(124, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(447, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlDataAdapter2
            // 
            npgsqlDataAdapter2.DeleteCommand = null;
            npgsqlDataAdapter2.InsertCommand = null;
            npgsqlDataAdapter2.SelectCommand = null;
            npgsqlDataAdapter2.UpdateCommand = null;
            // 
            // btn_generator
            // 
            btn_generator.Image = (Image)resources.GetObject("btn_generator.Image");
            btn_generator.Location = new Point(40, 9);
            btn_generator.Name = "btn_generator";
            btn_generator.Size = new Size(120, 114);
            btn_generator.SizeMode = PictureBoxSizeMode.Zoom;
            btn_generator.TabIndex = 24;
            btn_generator.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(-1, 127);
            label2.Name = "label2";
            label2.Size = new Size(201, 19);
            label2.TabIndex = 24;
            label2.Text = "Генератор поздравлений";
            // 
            // btn_ezhednevnik
            // 
            btn_ezhednevnik.Image = (Image)resources.GetObject("btn_ezhednevnik.Image");
            btn_ezhednevnik.Location = new Point(40, 158);
            btn_ezhednevnik.Name = "btn_ezhednevnik";
            btn_ezhednevnik.Size = new Size(120, 107);
            btn_ezhednevnik.SizeMode = PictureBoxSizeMode.Zoom;
            btn_ezhednevnik.TabIndex = 23;
            btn_ezhednevnik.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(45, 278);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 25;
            label3.Text = "Ежедневник";
            // 
            // btn_profile
            // 
            btn_profile.Image = (Image)resources.GetObject("btn_profile.Image");
            btn_profile.Location = new Point(0, 423);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(158, 91);
            btn_profile.SizeMode = PictureBoxSizeMode.Zoom;
            btn_profile.TabIndex = 24;
            btn_profile.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(91, 112, 101);
            panel5.Controls.Add(btn_profile);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(btn_ezhednevnik);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btn_generator);
            panel5.Location = new Point(0, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(198, 514);
            panel5.TabIndex = 22;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(198, 44);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(805, 515);
            mainPanel.TabIndex = 23;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1002, 558);
            Controls.Add(mainPanel);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)btn_Close).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_generator).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ezhednevnik).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_profile).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_Close;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter2;
        private PictureBox btn_generator;
        private Label label2;
        private PictureBox btn_ezhednevnik;
        private Label label3;
        private PictureBox btn_profile;
        private Panel panel5;
        private Panel mainPanel;
        private DateTimePicker dateTimePicker1;
    }
}