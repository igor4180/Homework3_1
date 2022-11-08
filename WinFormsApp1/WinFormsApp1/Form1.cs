namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += ShowMesBox;
        }

        private void ShowMesBox(object sender, EventArgs e)
        {
            string[] arr = { "Студент: Игорь Бесклеткин", "Предмет: Windows Forms C#", "Группа: ПВ-111" };
            int element = 0;
            string caption;
            int i = 0;
            while (i < arr.Length)
            {
                element += arr[i].Length;
                caption = (arr.Length - 1 == i) ? $"MessageBox {i + 1}.  {element / arr.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(arr[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
               i++;
            }
        }
    }
}