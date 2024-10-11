namespace Cinema
{
    partial class Admin_Form
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
            this.FilmsDataGridView = new System.Windows.Forms.DataGridView();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.TrailerBox = new System.Windows.Forms.TextBox();
            this.DirectorBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.PosterBox = new System.Windows.Forms.TextBox();
            this.ActorsBox = new System.Windows.Forms.TextBox();
            this.DubbingBox = new System.Windows.Forms.TextBox();
            this.AboutBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PremiereBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.DayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.FilmIDBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.HallBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.DeleteS = new System.Windows.Forms.Button();
            this.AddS = new System.Windows.Forms.Button();
            this.SaveS = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SessionIDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmsDataGridView
            // 
            this.FilmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.FilmsDataGridView.Name = "FilmsDataGridView";
            this.FilmsDataGridView.Size = new System.Drawing.Size(523, 550);
            this.FilmsDataGridView.TabIndex = 0;
            this.FilmsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmsDataGridView_CellContentClick);
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(541, 28);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(301, 21);
            this.FilmsComboBox.TabIndex = 1;
            this.FilmsComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите фильм";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(579, 419);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(660, 419);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(741, 419);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(541, 81);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(301, 20);
            this.TitleBox.TabIndex = 6;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(541, 120);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(301, 20);
            this.GenreBox.TabIndex = 7;
            // 
            // TrailerBox
            // 
            this.TrailerBox.Location = new System.Drawing.Point(541, 198);
            this.TrailerBox.Name = "TrailerBox";
            this.TrailerBox.Size = new System.Drawing.Size(301, 20);
            this.TrailerBox.TabIndex = 8;
            // 
            // DirectorBox
            // 
            this.DirectorBox.Location = new System.Drawing.Point(541, 393);
            this.DirectorBox.Name = "DirectorBox";
            this.DirectorBox.Size = new System.Drawing.Size(301, 20);
            this.DirectorBox.TabIndex = 9;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(541, 159);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(87, 20);
            this.AgeBox.TabIndex = 10;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(634, 159);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(67, 20);
            this.DurationBox.TabIndex = 11;
            // 
            // PosterBox
            // 
            this.PosterBox.Location = new System.Drawing.Point(541, 237);
            this.PosterBox.Name = "PosterBox";
            this.PosterBox.Size = new System.Drawing.Size(301, 20);
            this.PosterBox.TabIndex = 12;
            // 
            // ActorsBox
            // 
            this.ActorsBox.Location = new System.Drawing.Point(541, 276);
            this.ActorsBox.Name = "ActorsBox";
            this.ActorsBox.Size = new System.Drawing.Size(301, 20);
            this.ActorsBox.TabIndex = 13;
            // 
            // DubbingBox
            // 
            this.DubbingBox.Location = new System.Drawing.Point(541, 315);
            this.DubbingBox.Name = "DubbingBox";
            this.DubbingBox.Size = new System.Drawing.Size(301, 20);
            this.DubbingBox.TabIndex = 14;
            // 
            // AboutBox
            // 
            this.AboutBox.Location = new System.Drawing.Point(541, 354);
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.Size = new System.Drawing.Size(301, 20);
            this.AboutBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Возраст. огран.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Продолжит.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Гиперссылка на трейлер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Гиперссылка на постер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "В главных ролях";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Дубляж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "О фильме";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Режиссер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(707, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Дата премьеры";
            // 
            // PremiereBox
            // 
            this.PremiereBox.Location = new System.Drawing.Point(707, 159);
            this.PremiereBox.Name = "PremiereBox";
            this.PremiereBox.Size = new System.Drawing.Size(87, 20);
            this.PremiereBox.TabIndex = 32;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(637, 486);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 32);
            this.Back.TabIndex = 34;
            this.Back.Text = "Вернуться";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(848, 12);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.Size = new System.Drawing.Size(255, 401);
            this.ScheduleDataGridView.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(845, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Выберите день недели";
            // 
            // DayOfWeekComboBox
            // 
            this.DayOfWeekComboBox.FormattingEnabled = true;
            this.DayOfWeekComboBox.Items.AddRange(new object[] {
            "понедельник",
            "вторник",
            "среда",
            "четверг",
            "пятница",
            "суббота",
            "воскресенье"});
            this.DayOfWeekComboBox.Location = new System.Drawing.Point(845, 435);
            this.DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            this.DayOfWeekComboBox.Size = new System.Drawing.Size(255, 21);
            this.DayOfWeekComboBox.TabIndex = 36;
            this.DayOfWeekComboBox.SelectedIndexChanged += new System.EventHandler(this.DayOfWeekComboBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1031, 462);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Фильм (ID)";
            // 
            // FilmIDBox
            // 
            this.FilmIDBox.Location = new System.Drawing.Point(1013, 478);
            this.FilmIDBox.Name = "FilmIDBox";
            this.FilmIDBox.Size = new System.Drawing.Size(87, 20);
            this.FilmIDBox.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(953, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Зал";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(868, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Время";
            // 
            // HallBox
            // 
            this.HallBox.Location = new System.Drawing.Point(932, 478);
            this.HallBox.Name = "HallBox";
            this.HallBox.Size = new System.Drawing.Size(75, 20);
            this.HallBox.TabIndex = 41;
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(845, 478);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(81, 20);
            this.TimeBox.TabIndex = 40;
            // 
            // DeleteS
            // 
            this.DeleteS.Location = new System.Drawing.Point(975, 542);
            this.DeleteS.Name = "DeleteS";
            this.DeleteS.Size = new System.Drawing.Size(75, 23);
            this.DeleteS.TabIndex = 48;
            this.DeleteS.Text = "Удалить";
            this.DeleteS.UseVisualStyleBackColor = true;
            this.DeleteS.Click += new System.EventHandler(this.DeleteS_Click);
            // 
            // AddS
            // 
            this.AddS.Location = new System.Drawing.Point(975, 504);
            this.AddS.Name = "AddS";
            this.AddS.Size = new System.Drawing.Size(75, 23);
            this.AddS.TabIndex = 47;
            this.AddS.Text = "Добавить";
            this.AddS.UseVisualStyleBackColor = true;
            this.AddS.Click += new System.EventHandler(this.AddS_Click);
            // 
            // SaveS
            // 
            this.SaveS.Location = new System.Drawing.Point(894, 504);
            this.SaveS.Name = "SaveS";
            this.SaveS.Size = new System.Drawing.Size(75, 23);
            this.SaveS.TabIndex = 46;
            this.SaveS.Text = "Сохранить";
            this.SaveS.UseVisualStyleBackColor = true;
            this.SaveS.Click += new System.EventHandler(this.SaveS_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(899, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Сессия(ID)";
            // 
            // SessionIDBox
            // 
            this.SessionIDBox.Location = new System.Drawing.Point(894, 545);
            this.SessionIDBox.Name = "SessionIDBox";
            this.SessionIDBox.Size = new System.Drawing.Size(74, 20);
            this.SessionIDBox.TabIndex = 49;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 574);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SessionIDBox);
            this.Controls.Add(this.DeleteS);
            this.Controls.Add(this.AddS);
            this.Controls.Add(this.SaveS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.FilmIDBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.HallBox);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DayOfWeekComboBox);
            this.Controls.Add(this.ScheduleDataGridView);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PremiereBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AboutBox);
            this.Controls.Add(this.DubbingBox);
            this.Controls.Add(this.ActorsBox);
            this.Controls.Add(this.PosterBox);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.DirectorBox);
            this.Controls.Add(this.TrailerBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmsComboBox);
            this.Controls.Add(this.FilmsDataGridView);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilmsDataGridView;
        private System.Windows.Forms.ComboBox FilmsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox TrailerBox;
        private System.Windows.Forms.TextBox DirectorBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox PosterBox;
        private System.Windows.Forms.TextBox ActorsBox;
        private System.Windows.Forms.TextBox DubbingBox;
        private System.Windows.Forms.TextBox AboutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PremiereBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView ScheduleDataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DayOfWeekComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox FilmIDBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox HallBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Button DeleteS;
        private System.Windows.Forms.Button AddS;
        private System.Windows.Forms.Button SaveS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SessionIDBox;
    }
}