using System.Data;
using System.Threading.Tasks.Dataflow;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private Book bufferBook = new Book();
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataTable.Columns.Add(new DataColumn("ID", typeof(int))); ���� ��������� ������� ��� � ������� �� �����
            //���� ���������� ����� � �������, ���� � DataTable
            DataColumn column;
            DataRow row;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Name";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Author";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Genre";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "PublishYear";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Pages";
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Publisher";
            column = new DataColumn();

            dgv_library.Rows.Add("0", "����� � ���", "�.�. �������", "�����-������", "1865", "960", "������� �������");
            dgv_library.Rows.Add("1", "����� ���", "�.�. �������", "�����-������", "1940", "1472", "����� ���");
            dgv_library.Rows.Add("2", "����������� ���� ������", "�. ����", "�������", "1876", "250", "��������");
            dgv_library.Rows.Add("3", "��� ���������", "�. ����", "�����", "1844", "414", "�����");
        }

        private void dgv_library_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows[0].Index >= 0)
                dgv_library.Rows.RemoveAt(dgv_library.SelectedRows[0].Index);
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_library.SelectedRows.Count > 0)
            {
                //���������� ��� DataTable
                bufferBook = new Book(
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[0].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[1].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[2].Value.ToString(),
                    dgv_library.SelectedRows[0].Cells[3].Value.ToString(),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[4].Value.ToString()),
                    Convert.ToInt32(dgv_library.SelectedRows[0].Cells[5].Value.ToString()),
                    dgv_library.SelectedRows[0].Cells[6].Value.ToString());
                EditBook editForm = new EditBook(bufferBook);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    bufferBook = editForm.EditableBook;
                    dgv_library.SelectedRows[0].Cells[0].Value = bufferBook.Id;
                    dgv_library.SelectedRows[0].Cells[1].Value = bufferBook.Name;
                    dgv_library.SelectedRows[0].Cells[2].Value = bufferBook.Author;
                    dgv_library.SelectedRows[0].Cells[3].Value = bufferBook.Genre;
                    dgv_library.SelectedRows[0].Cells[4].Value = bufferBook.PublishYear;
                    dgv_library.SelectedRows[0].Cells[5].Value = bufferBook.Pages;
                    dgv_library.SelectedRows[0].Cells[6].Value = bufferBook.Publisher;
                    editForm.Close();
                }

            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addForm = new AddBook();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //���������� ��� DataTable
                bufferBook = addForm.AddableBook;
                dgv_library.Rows.Add(
                bufferBook.Id,
                bufferBook.Name,
                bufferBook.Author,
                bufferBook.Genre,
                bufferBook.PublishYear,
                bufferBook.Pages,
                bufferBook.Publisher);
            }
        }

        private void nameFilterASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������� ������ � ���� ����� � �������� �� �������� ����������
        }

        private void nameFilterDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������� ������ � ���� ����� � �������� �� �������� ����������
        }
    }
}