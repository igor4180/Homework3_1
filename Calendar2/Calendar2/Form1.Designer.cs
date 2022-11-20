namespace Calendar2
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
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(61, 24);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(45, 23);
            this.tb_day.TabIndex = 0;
            this.tb_day.TextChanged += new System.EventHandler(this.tb_day_TextChanged);
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(112, 24);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(40, 23);
            this.tb_month.TabIndex = 1;
            this.tb_month.TextChanged += new System.EventHandler(this.tb_month_TextChanged);
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(158, 24);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(37, 23);
            this.tb_year.TabIndex = 2;
            this.tb_year.TextChanged += new System.EventHandler(this.tb_year_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(499, 67);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_day;
        private TextBox tb_month;
        private TextBox tb_year;
        private MonthCalendar monthCalendar1;
    }
}