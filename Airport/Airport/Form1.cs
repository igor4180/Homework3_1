using System.Windows.Forms;

namespace Airport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Route> routes = new List<Route>();
        private object listBox1;

        private void Form1_Load(object sender, EventArgs e)
        {
            routes.Add(new Route(1, "������ �.�.", 15, 8, 1647, 16, 09, 2022, 15 / 48, 7, "���������"));
            routes.Add(new Route(2, "����� �.�.", 10, 6, 1043, 16, 09, 2022, 15 / 59, 8, "�����������"));
            routes.Add(new Route(3, "���������� �.�.", 8, 5, 7951, 16, 09, 2022, 16 / 21, 4, "�����������"));
            routes.Add(new Route(4, "������� �.�.", 8, 5, 7951, 16, 09, 2022, 16 / 21, 4, "�����������"));
            routes.Add(new Route(5, "�������� �.�.", 11, 7, 7981, 17, 09, 2022, 09 / 21, 3, "�����������"));
            routes.Add(new Route(6, "��������� �.�.", 8, 5, 7641, 17, 09, 2022, 10 / 15, 3, "������������"));
        }
        
        private void btn_defaultRoute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < routes.Count; i++)
            {
                listBox1.Items.Add(routes[i]);
            }
        }
    }

}
