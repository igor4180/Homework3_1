using System.Windows.Forms;
namespace TextRedactor
{
    // êíîïêè îòêðûòü è îòìåíèòü íå ðàáîòàþò
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt| Igor Notepad File (*.tnf)|*.tnf";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ôîðìàòToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBoxShow("Ôàéë ñîõðàíåí!");
        }

        private void MessageBoxShow(string v)
        {
            //throw new NotImplementedException();
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            string richTextBox1 = fileText;
            MessageBoxShow("Ôàéë îòêðûò!");

        }

        private void êîïèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void âûðåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void íàñòðîéêèØðèôòàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void íàñòðîéêèÔîíàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }



        //private void ÎòìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (richTextBox1.TextLength > 0)
        //    {
        //        object value = richTextBox1.Cancel();
        //    }
        //}
    }
}