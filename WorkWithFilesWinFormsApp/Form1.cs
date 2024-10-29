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
                if (openFileDialog.ShowDialog() == DialogResult.OK)//Если окно открылось
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        File.WriteAllText(filePath, writeBox.Text);
                        MessageBox.Show("Данные записаны!");
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
                if (openFileDialog.ShowDialog() == DialogResult.OK)//Если окно открылось
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;//Записываем путь от пользователя
                        //MessageBox.Show(filePath);//Выводим в окне путь

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