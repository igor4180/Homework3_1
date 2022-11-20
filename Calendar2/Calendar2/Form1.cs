using System.Windows.Forms;

namespace Calendar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_day_TextChanged(object sender, EventArgs e)
        {
            if (tb_day.Text.Length > 0 && tb_month.Text.Length > 0 && tb_year.Text.Length > 0)
            {
                monthCalendar1.SetDate(new DateTime(Int32.Parse(tb_year.Text), Int32.Parse(tb_month.Text), Int32.Parse(tb_day.Text)));
            }
        }

        private void tb_month_TextChanged(object sender, EventArgs e)
        {
            if (tb_day.Text.Length > 0 && tb_month.Text.Length > 0 && tb_year.Text.Length > 0)
            {
                monthCalendar1.SetDate(new DateTime(Int32.Parse(tb_year.Text), Int32.Parse(tb_month.Text), Int32.Parse(tb_day.Text)));
            }
        }

        private void tb_year_TextChanged(object sender, EventArgs e)
        {
            if (tb_day.Text.Length > 0 && tb_month.Text.Length > 0 && tb_year.Text.Length > 0)
            {
                monthCalendar1.SetDate(new DateTime(Int32.Parse(tb_year.Text), Int32.Parse(tb_month.Text), Int32.Parse(tb_day.Text)));
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}