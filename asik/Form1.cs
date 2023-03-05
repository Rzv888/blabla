namespace asik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tombol = textBox1.Text;
            label1.Text = "Halo" + tombol;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}