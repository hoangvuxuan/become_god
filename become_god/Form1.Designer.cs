namespace become_god
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            mf_show_job = new Panel();
            mf_add_job = new Button();
            mf_pickday = new DateTimePicker();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 591);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(mf_show_job);
            panel2.Controls.Add(mf_add_job);
            panel2.Controls.Add(mf_pickday);
            panel2.Location = new Point(307, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 589);
            panel2.TabIndex = 1;
            // 
            // mf_show_job
            // 
            mf_show_job.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mf_show_job.Location = new Point(3, 42);
            mf_show_job.Name = "mf_show_job";
            mf_show_job.Size = new Size(964, 480);
            mf_show_job.TabIndex = 2;
            // 
            // mf_add_job
            // 
            mf_add_job.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mf_add_job.BackColor = SystemColors.MenuHighlight;
            mf_add_job.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mf_add_job.Location = new Point(3, 528);
            mf_add_job.Name = "mf_add_job";
            mf_add_job.Size = new Size(964, 53);
            mf_add_job.TabIndex = 1;
            mf_add_job.Text = "THÊM VIỆC";
            mf_add_job.UseVisualStyleBackColor = false;
            mf_add_job.Click += mf_add_job_Click;
            // 
            // mf_pickday
            // 
            mf_pickday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mf_pickday.Location = new Point(296, 9);
            mf_pickday.Name = "mf_pickday";
            mf_pickday.Size = new Size(379, 27);
            mf_pickday.TabIndex = 0;
            mf_pickday.ValueChanged += mf_pickday_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 596);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button mf_add_job;
        private DateTimePicker mf_pickday;
        private Panel mf_show_job;
    }
}
