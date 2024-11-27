namespace OTSC.MainPage.MainView
{
    partial class ToDoPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            combobox_compl = new Guna.UI2.WinForms.Guna2ComboBox();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
            ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            txt_task = new Guna.UI2.WinForms.Guna2TextBox();
            txt_desc = new Guna.UI2.WinForms.Guna2TextBox();
            label_interes = new Label();
            date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label_data = new Label();
            label_user = new Label();
            DataTableTask = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataTableTask).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(691, 203);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 28;
            label1.Text = "Сложность";
            // 
            // combobox_compl
            // 
            combobox_compl.BackColor = Color.Transparent;
            combobox_compl.BorderRadius = 15;
            combobox_compl.CustomizableEdges = customizableEdges17;
            combobox_compl.DrawMode = DrawMode.OwnerDrawFixed;
            combobox_compl.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_compl.FocusedColor = Color.FromArgb(94, 148, 255);
            combobox_compl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            combobox_compl.Font = new Font("Segoe UI", 10F);
            combobox_compl.ForeColor = Color.FromArgb(68, 88, 112);
            combobox_compl.ItemHeight = 30;
            combobox_compl.Items.AddRange(new object[] { "Простой", "Средний", "Сложный" });
            combobox_compl.Location = new Point(629, 228);
            combobox_compl.Name = "combobox_compl";
            combobox_compl.ShadowDecoration.CustomizableEdges = customizableEdges18;
            combobox_compl.Size = new Size(175, 36);
            combobox_compl.TabIndex = 27;
            // 
            // btn_delete
            // 
            btn_delete.BorderRadius = 15;
            btn_delete.CustomizableEdges = customizableEdges19;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.FillColor = Color.LightCoral;
            btn_delete.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_delete.ForeColor = Color.Black;
            btn_delete.Location = new Point(375, 430);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btn_delete.Size = new Size(175, 61);
            btn_delete.TabIndex = 26;
            btn_delete.Text = "Удалить";
            // 
            // btn_update
            // 
            btn_update.BorderRadius = 15;
            btn_update.CustomizableEdges = customizableEdges21;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.FillColor = Color.PaleGoldenrod;
            btn_update.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_update.ForeColor = Color.Black;
            btn_update.Location = new Point(194, 430);
            btn_update.Name = "btn_update";
            btn_update.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btn_update.Size = new Size(175, 61);
            btn_update.TabIndex = 25;
            btn_update.Text = "Обновить";
            // 
            // btn_add
            // 
            btn_add.BorderRadius = 15;
            btn_add.CustomizableEdges = customizableEdges23;
            btn_add.DisabledState.BorderColor = Color.DarkGray;
            btn_add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_add.FillColor = Color.DarkSeaGreen;
            btn_add.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_add.ForeColor = Color.Black;
            btn_add.Location = new Point(12, 430);
            btn_add.Name = "btn_add";
            btn_add.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btn_add.Size = new Size(175, 61);
            btn_add.TabIndex = 24;
            btn_add.Text = "Добавить";
            // 
            // ClearBtn
            // 
            ClearBtn.BorderRadius = 15;
            ClearBtn.CustomizableEdges = customizableEdges25;
            ClearBtn.DisabledState.BorderColor = Color.DarkGray;
            ClearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearBtn.FillColor = Color.Gray;
            ClearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ClearBtn.ForeColor = Color.Black;
            ClearBtn.Location = new Point(598, 430);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.ShadowDecoration.CustomizableEdges = customizableEdges26;
            ClearBtn.Size = new Size(207, 61);
            ClearBtn.TabIndex = 23;
            ClearBtn.Text = "Очистить";
            // 
            // txt_task
            // 
            txt_task.BorderRadius = 15;
            txt_task.CustomizableEdges = customizableEdges27;
            txt_task.DefaultText = "";
            txt_task.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_task.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_task.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_task.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_task.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_task.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txt_task.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_task.Location = new Point(634, 57);
            txt_task.Margin = new Padding(4);
            txt_task.Name = "txt_task";
            txt_task.PasswordChar = '\0';
            txt_task.PlaceholderText = "";
            txt_task.SelectedText = "";
            txt_task.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txt_task.Size = new Size(171, 42);
            txt_task.TabIndex = 22;
            // 
            // txt_desc
            // 
            txt_desc.BorderRadius = 15;
            txt_desc.CustomizableEdges = customizableEdges29;
            txt_desc.DefaultText = "";
            txt_desc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_desc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_desc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_desc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_desc.FillColor = Color.WhiteSmoke;
            txt_desc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_desc.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txt_desc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_desc.Location = new Point(629, 295);
            txt_desc.Margin = new Padding(4);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.PasswordChar = '\0';
            txt_desc.PlaceholderText = "";
            txt_desc.SelectedText = "";
            txt_desc.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txt_desc.Size = new Size(171, 128);
            txt_desc.TabIndex = 21;
            // 
            // label_interes
            // 
            label_interes.AutoSize = true;
            label_interes.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_interes.Location = new Point(692, 267);
            label_interes.Name = "label_interes";
            label_interes.Size = new Size(104, 22);
            label_interes.TabIndex = 20;
            label_interes.Text = "Описание";
            // 
            // date_picker
            // 
            date_picker.BackColor = Color.Gainsboro;
            date_picker.BorderRadius = 15;
            date_picker.Checked = true;
            date_picker.CustomFormat = "dd.MM.yyyy hh:mm";
            date_picker.CustomizableEdges = customizableEdges31;
            date_picker.FillColor = Color.WhiteSmoke;
            date_picker.Font = new Font("Segoe UI", 9F);
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.Location = new Point(633, 138);
            date_picker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_picker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_picker.Name = "date_picker";
            date_picker.ShadowDecoration.CustomizableEdges = customizableEdges32;
            date_picker.ShowUpDown = true;
            date_picker.Size = new Size(171, 46);
            date_picker.TabIndex = 19;
            date_picker.Value = new DateTime(2024, 11, 25, 0, 12, 26, 436);
            // 
            // label_data
            // 
            label_data.AutoSize = true;
            label_data.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_data.Location = new Point(640, 113);
            label_data.Name = "label_data";
            label_data.Size = new Size(165, 22);
            label_data.TabIndex = 18;
            label_data.Text = "Дата Окончания";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_user.Location = new Point(723, 31);
            label_user.Name = "label_user";
            label_user.Size = new Size(77, 22);
            label_user.TabIndex = 17;
            label_user.Text = "Задача";
            // 
            // DataTableTask
            // 
            DataTableTask.AllowUserToAddRows = false;
            DataTableTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTableTask.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataTableTask.BackgroundColor = Color.Gainsboro;
            DataTableTask.BorderStyle = BorderStyle.None;
            DataTableTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTableTask.Location = new Point(0, 0);
            DataTableTask.Name = "DataTableTask";
            DataTableTask.RowHeadersVisible = false;
            DataTableTask.RowHeadersWidth = 51;
            DataTableTask.Size = new Size(623, 401);
            DataTableTask.TabIndex = 16;
            // 
            // ToDoPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(805, 515);
            Controls.Add(label1);
            Controls.Add(combobox_compl);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(ClearBtn);
            Controls.Add(txt_task);
            Controls.Add(txt_desc);
            Controls.Add(label_interes);
            Controls.Add(date_picker);
            Controls.Add(label_data);
            Controls.Add(label_user);
            Controls.Add(DataTableTask);
            Name = "ToDoPage";
            Text = "ToDoPage";
            ((System.ComponentModel.ISupportInitialize)DataTableTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox combobox_compl;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2TextBox txt_task;
        private Guna.UI2.WinForms.Guna2TextBox txt_desc;
        private Label label_interes;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_picker;
        private Label label_data;
        private Label label_user;
        private DataGridView DataTableTask;
    }
}