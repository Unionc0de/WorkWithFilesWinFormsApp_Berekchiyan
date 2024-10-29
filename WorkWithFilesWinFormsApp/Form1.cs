namespace WorkWithFilesWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void write_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)//���� ���� ���������
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        File.WriteAllText(filePath, writeBox.Text);
                        MessageBox.Show("������ ��������!");
                        string context = File.ReadAllText(filePath);
                        richTextBox1.Text = context;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)//���� ���� ���������
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;//���������� ���� �� ������������
                        //MessageBox.Show(filePath);//������� � ���� ����

                        string context = File.ReadAllText(filePath);
                        richTextBox1.Text = context;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}