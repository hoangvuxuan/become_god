namespace become_god
{
    partial class daily_plain
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
            label1 = new Label();
            dp_pick_day = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dp_title = new TextBox();
            dp_content = new TextBox();
            label6 = new Label();
            dp_nud_from_minute = new NumericUpDown();
            dp_nud_from_h = new NumericUpDown();
            dp_study_times = new NumericUpDown();
            dp_add_job = new Button();
            dp_nup_to_minute = new NumericUpDown();
            dp_nup_to_h = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dp_nud_from_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dp_nud_from_h).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dp_study_times).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dp_nup_to_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dp_nup_to_h).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "THỜI GIAN: ";
            // 
            // dp_pick_day
            // 
            dp_pick_day.Location = new Point(178, 4);
            dp_pick_day.Name = "dp_pick_day";
            dp_pick_day.Size = new Size(283, 27);
            dp_pick_day.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 434);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "LẦN HỌC: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 373);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "KẾT THÚC: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "BẮT ĐẦU: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "TIÊU ĐỀ:";
            // 
            // dp_title
            // 
            dp_title.Location = new Point(178, 80);
            dp_title.Name = "dp_title";
            dp_title.Size = new Size(283, 27);
            dp_title.TabIndex = 6;
            // 
            // dp_content
            // 
            dp_content.Location = new Point(178, 161);
            dp_content.Multiline = true;
            dp_content.Name = "dp_content";
            dp_content.Size = new Size(283, 108);
            dp_content.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 7;
            label6.Text = "NỘI DUNG: ";
            // 
            // dp_nud_from_minute
            // 
            dp_nud_from_minute.Location = new Point(235, 310);
            dp_nud_from_minute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            dp_nud_from_minute.Name = "dp_nud_from_minute";
            dp_nud_from_minute.Size = new Size(51, 27);
            dp_nud_from_minute.TabIndex = 10;
            // 
            // dp_nud_from_h
            // 
            dp_nud_from_h.Location = new Point(178, 310);
            dp_nud_from_h.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            dp_nud_from_h.Name = "dp_nud_from_h";
            dp_nud_from_h.Size = new Size(51, 27);
            dp_nud_from_h.TabIndex = 9;
            // 
            // dp_study_times
            // 
            dp_study_times.Location = new Point(178, 427);
            dp_study_times.Name = "dp_study_times";
            dp_study_times.Size = new Size(108, 27);
            dp_study_times.TabIndex = 13;
            // 
            // dp_add_job
            // 
            dp_add_job.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dp_add_job.BackColor = SystemColors.MenuHighlight;
            dp_add_job.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dp_add_job.Location = new Point(12, 497);
            dp_add_job.Name = "dp_add_job";
            dp_add_job.Size = new Size(461, 29);
            dp_add_job.TabIndex = 14;
            dp_add_job.Text = "THÊM VIỆC";
            dp_add_job.UseVisualStyleBackColor = false;
            dp_add_job.Click += dp_add_job_Click;
            // 
            // dp_nup_to_minute
            // 
            dp_nup_to_minute.Location = new Point(235, 366);
            dp_nup_to_minute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            dp_nup_to_minute.Name = "dp_nup_to_minute";
            dp_nup_to_minute.Size = new Size(51, 27);
            dp_nup_to_minute.TabIndex = 16;
            // 
            // dp_nup_to_h
            // 
            dp_nup_to_h.Location = new Point(178, 366);
            dp_nup_to_h.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            dp_nup_to_h.Name = "dp_nup_to_h";
            dp_nup_to_h.Size = new Size(51, 27);
            dp_nup_to_h.TabIndex = 15;
            // 
            // daily_plain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 538);
            Controls.Add(dp_nup_to_minute);
            Controls.Add(dp_nup_to_h);
            Controls.Add(dp_add_job);
            Controls.Add(dp_study_times);
            Controls.Add(dp_nud_from_minute);
            Controls.Add(dp_nud_from_h);
            Controls.Add(dp_content);
            Controls.Add(label6);
            Controls.Add(dp_title);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dp_pick_day);
            Controls.Add(label1);
            Name = "daily_plain";
            Text = "daily_plain";
            ((System.ComponentModel.ISupportInitialize)dp_nud_from_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)dp_nud_from_h).EndInit();
            ((System.ComponentModel.ISupportInitialize)dp_study_times).EndInit();
            ((System.ComponentModel.ISupportInitialize)dp_nup_to_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)dp_nup_to_h).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dp_pick_day;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox dp_title;
        private TextBox dp_content;
        private Label label6;
        private NumericUpDown dp_nud_from_minute;
        private NumericUpDown dp_nud_from_h;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown dp_study_times;
        private Button dp_add_job;
        private NumericUpDown dp_nup_to_minute;
        private NumericUpDown dp_nup_to_h;
    }
}