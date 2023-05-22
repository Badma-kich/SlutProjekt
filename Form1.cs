namespace SlutUppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Fönster = new Form2();
            Fönster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Fönster = new Form3();
            Fönster.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Fönster = new Form4();
            Fönster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Fönster = new Form5();
            Fönster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Fönster = new Form6();
            Fönster.Show();
        }
    }
}